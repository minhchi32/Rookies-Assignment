import React, { useState } from "react";
import DeleteIcon from "@material-ui/icons/Delete";
import EditIcon from "@material-ui/icons/Edit";
import { useNavigate } from "react-router";
import ButtonIcon from "../../../Shared-Components/ButtonIcon";
import { NotificationManager } from "react-notifications";

import Table, { SortType } from "../../../Shared-Components/Table";
import Info from "../Info";
import { EDIT_APPUSER_ID } from "../../../Constants/pages";
import ConfirmModal from "../../../Shared-Components/ConfirmModal";
import { checkRole } from "../../../Constants/Check/checkRole"

import { DisableAppUserRequest } from "../services/request";

const columns = [
	{ columnName: "id", columnValue: "Id" },
	{ columnName: "name", columnValue: "Name" },
	{ columnName: "username", columnValue: "Username" },
	{ columnName: "phone number", columnValue: "phoneNumber" },
	{ columnName: "date of birth", columnValue: "dob" },
	{ columnName: "role", columnValue: "roleId" },
];

const AppUserTable = ({
	appUsers,
	handlePage,
	handleSort,
	sortState,
	fetchData,
}) => {
	const [showDetail, setShowDetail] = useState(false);
	const [appUserDetail, setAppUserDetail] = useState(null);
	const [disableState, setDisable] = useState({
		isOpen: false,
		id: 0,
		title: "",
		message: "",
		isDisable: true,
	});

	const handleShowInfo = (id) => {
		const appUser = appUsers?.items.find((item) => item.id === id);

		if (appUser) {
			setAppUserDetail(appUser);
			setShowDetail(true);
		}
	};

	const handleShowDisable = async (id) => {
		setDisable({
			id,
			isOpen: true,
			title: "Are you sure",
			message: "Do you want to disable this AppUsers?",
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
				`Remove AppUser Successful`,
				`Remove Successful`,
				2000,
			);
		} else {
			setDisable({
				...disableState,
				title: "Can not disable AppUser",
				message,
				isDisable: result,
			});
		}
	};

	const handleConfirmDisable = async () => {
		let isSuccess = await DisableAppUserRequest(disableState.id);
		if (isSuccess) {
			await handleResult(true, "");
		}
	};

	const handleCloseDetail = () => {
		setShowDetail(false);
	};

	const navigate = useNavigate();
	const handleEdit = (id) => {
		const existAppUser = appUsers?.items.find((item) => item.id === Number(id));
		navigate(EDIT_APPUSER_ID(id), {
			state: { existAppUser: existAppUser },
		});
	};
	const getFormatDateTime=(date)=>{
		const DATE_OPTIONS = { weekday: 'short', year: 'numeric', month: 'short', day: 'numeric' };
		return new Date(date).toLocaleDateString('en-US', DATE_OPTIONS);
	  }
	return (
		<>
			<Table
				columns={columns}
				handleSort={handleSort}
				sortState={sortState}
				page={{
					pageIndex: appUsers?.pageIndex,
					pageCount: appUsers?.pageCount,
					handleChange: handlePage,
				}}
			>
				{appUsers &&
					appUsers?.items?.map((data, index) => (
						<tr
							key={index}
							className=""
							onClick={() => handleShowInfo(data.id)}
						>
							<td>{data.id}</td>
							<td>{data.name}</td>
							<td>{data.userName}</td>
							<td>{data.phoneNumber}</td>
							<td>{getFormatDateTime(data.dob)}</td>
							<td>{checkRole(data.roleId)}</td>

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
			{appUserDetail && showDetail && (
				<Info appUser={appUserDetail} handleClose={handleCloseDetail} />
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

export default AppUserTable;
