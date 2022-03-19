import React, { useState } from "react";
import DeleteIcon from "@material-ui/icons/Delete";
import EditIcon from "@material-ui/icons/Edit";
import { useNavigate } from "react-router";
import ButtonIcon from "../../../Shared-Components/ButtonIcon";
import { NotificationManager } from "react-notifications";
import "../Category.css";

import Table, { SortType } from "../../../Shared-Components/Table";
import Info from "../Info";
import { EDIT_CATEGORY_ID } from "../../../Constants/pages";
import ConfirmModal from "../../../Shared-Components/ConfirmModal";
import {
	CheckActive,
	CheckActiveLabel,
	CheckInActiveLabel,
} from "../../../Constants/Category/CategoryConstants";
import { DisableCategoryRequest } from "../services/request";

const columns = [
	{ columnName: "id ", columnValue: "Id" },
	{ columnName: "name ", columnValue: "Name" },
	{ columnName: "status ", columnValue: "Status" },
];

const CategoryTable = ({
	categories,
	handlePage,
	handleSort,
	sortState,
	fetchData,
}) => {
	const [showDetail, setShowDetail] = useState(false);
	const [categoryDetail, setCategoryDetail] = useState(null);
	const [disableState, setDisable] = useState({
		isOpen: false,
		id: 0,
		title: "",
		message: "",
		isDisable: true,
	});

	const handleShowInfo = (id) => {
		const category = categories?.items.find((item) => item.id === id);

		if (category) {
			setCategoryDetail(category);
			setShowDetail(true);
		}
	};

	const getIsActive = (id) => {
		return id == CheckActive ? CheckActiveLabel : CheckInActiveLabel;
	};

	const handleShowDisable = async (id) => {
		setDisable({
			id,
			isOpen: true,
			title: "Are you sure",
			message: "Do you want to disable this Categories?",
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
				`Remove Category Successful`,
				`Remove Successful`,
				2000,
			);
		} else {
			setDisable({
				...disableState,
				title: "Can not disable Category",
				message,
				isDisable: result,
			});
		}
	};

	const handleConfirmDisable = async () => {
		let isSuccess = await DisableCategoryRequest(disableState.id);
		if (isSuccess) {
			await handleResult(true, "");
		}
	};

	const handleCloseDetail = () => {
		setShowDetail(false);
	};

	const navigate = useNavigate();
	const handleEdit = (id) => {
		const existCategory = categories?.items.find(
			(item) => item.id === Number(id),
		);
		navigate(EDIT_CATEGORY_ID(id), {
			state: { existCategory: existCategory },
		});
	};

	return (
		<>
			<Table
				columns={columns}
				handleSort={handleSort}
				sortState={sortState}
				page={{
					pageIndex: categories?.pageIndex,
					pageCount: categories?.pageCount,
					handleChange: handlePage,
				}}
			>
				{categories &&
					categories?.items?.map((data, index) => (
						<tr
							key={index}
							className=""
							onClick={() => handleShowInfo(data.id)}
						>
							<td>{data.id}</td>
							<td>{data.name}</td>
							<td>{getIsActive(data.status)}</td>

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
			{categoryDetail && showDetail && (
				<Info category={categoryDetail} handleClose={handleCloseDetail} />
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

export default CategoryTable;
