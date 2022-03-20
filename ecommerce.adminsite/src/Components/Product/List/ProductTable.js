import React, { useState } from "react";
import DeleteIcon from "@material-ui/icons/Delete";
import EditIcon from "@material-ui/icons/Edit";
import { useNavigate } from "react-router";
import ButtonIcon from "../../../Shared-Components/ButtonIcon";
import { NotificationManager } from "react-notifications";

import Table, { SortType } from "../../../Shared-Components/Table";
import Info from "../Info";
import { EDIT_PRODUCT_ID } from "../../../Constants/pages";
import ConfirmModal from "../../../Shared-Components/ConfirmModal";
import { checkStatus } from "../../../Constants/Status/index"

import { DisableProductRequest } from "../services/request";

const columns = [
	{ columnName: "id", columnValue: "Id" },
	{ columnName: "name", columnValue: "Name" },
	{ columnName: "price", columnValue: "Price" },
	{ columnName: "decrease price", columnValue: "DecreasedPrice" },
	{ columnName: "category ID", columnValue: "CategoryID" },
	{ columnName: "quantity sale", columnValue: "QuantitySale" },
	{ columnName: "rate", columnValue: "rate" },
	{ columnName: "status", columnValue: "Status" },
];

const ProductTable = ({
	products,
	handlePage,
	handleSort,
	sortState,
	fetchData,
}) => {
	const [showDetail, setShowDetail] = useState(false);
	const [productDetail, setProductDetail] = useState(null);
	const [disableState, setDisable] = useState({
		isOpen: false,
		id: 0,
		title: "",
		message: "",
		isDisable: true,
	});

	const handleShowInfo = (id) => {
		const product = products?.items.find((item) => item.id === id);

		if (product) {
			setProductDetail(product);
			setShowDetail(true);
		}
	};

	const handleShowDisable = async (id) => {
		setDisable({
			id,
			isOpen: true,
			title: "Are you sure",
			message: "Do you want to disable this Products?",
			isDisable: true,
		});
	};

	const handleCloseDisable = () => {
		setDisable({
			isOpen: false,
			id: 0,
			title: "",
			message: "",
			isDisable: true,
		});
	};

	const handleResult = async (result, message) => {
		if (result) {
			handleCloseDisable();
			await fetchData();
			NotificationManager.success(
				`Remove Product Successful`,
				`Remove Successful`,
				2000,
			);
		} else {
			setDisable({
				...disableState,
				title: "Can not disable Product",
				message,
				isDisable: result,
			});
		}
	};

	const handleConfirmDisable = async () => {
		let isSuccess = await DisableProductRequest(disableState.id);
		if (isSuccess) {
			await handleResult(true, "");
		}
	};

	const handleCloseDetail = () => {
		setShowDetail(false);
	};

	const navigate = useNavigate();
	const handleEdit = (id) => {
		const existProduct = products?.items.find((item) => item.id === Number(id));
		navigate(EDIT_PRODUCT_ID(id), {
			state: { existProduct: existProduct },
		});
	};

	return (
		<>
			<Table
				columns={columns}
				handleSort={handleSort}
				sortState={sortState}
				page={{
					pageIndex: products?.pageIndex,
					pageCount: products?.pageCount,
					handleChange: handlePage,
				}}
			>
				{products &&
					products?.items?.map((data, index) => (
						<tr
							key={index}
							className=""
							onClick={() => handleShowInfo(data.id)}
						>
							<td>{data.id}</td>
							<td>{data.name}</td>
							<td>{data.price}</td>
							<td>{data.decreasedPrice}</td>
							<td>{data.categoryID}</td>
							<td>{data.quantitySale}</td>
							<td>{(data.totalPointRate/data.countRate).toFixed(1)}</td>
							<td>{checkStatus(data.status)}</td>

							<td>
								<div className="d-flex justify-content-center">
									<ButtonIcon
										onClick={() => handleEdit(data.id)}
										className="btn btn-primary p-2"
									>
										<EditIcon fontSize="small" />
									</ButtonIcon>
									&#160;
									<ButtonIcon
										onClick={() => handleShowDisable(data.id)}
										className="btn btn-danger p-2"
									>
										<DeleteIcon fontSize="small" />
									</ButtonIcon>
								</div>
							</td>
						</tr>
					))}
			</Table>
			{productDetail && showDetail && (
				<Info product={productDetail} handleClose={handleCloseDetail} />
			)}
			<ConfirmModal
				title={disableState.title}
				isShow={disableState.isOpen}
				onHide={handleCloseDisable}
			>
				<div>
					<div className="text-center">{disableState.message}</div>
					{disableState.isDisable && (
						<div className="text-center mt-3">
							<button
								className="btn btn-danger mr-3"
								onClick={handleConfirmDisable}
								type="button"
							>
								Disable
							</button>
							&ensp;
							<button
								className="btn btn-outline-secondary"
								onClick={handleCloseDisable}
								type="button"
							>
								Cancel
							</button>
						</div>
					)}
				</div>
			</ConfirmModal>
		</>
	);
};

export default ProductTable;
