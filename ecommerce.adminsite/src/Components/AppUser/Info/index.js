import React from "react";
import { Modal } from "react-bootstrap";

import { checkRole } from "../../../Constants/Check/checkRole"

const Info = ({ appUser, handleClose }) => {
	const getFormatDateTime=(date)=>{
		const DATE_OPTIONS = { weekday: 'short', year: 'numeric', month: 'short', day: 'numeric' };
		return new Date(date).toLocaleDateString('en-US', DATE_OPTIONS);
	  }
	return (
		<>
			<Modal show={true} onHide={handleClose} size="xl">
				<Modal.Header closeButton>
					<Modal.Title id="login-modal">
						Detailed User Information
					</Modal.Title>
				</Modal.Header>

				<Modal.Body>
					<table className="table table-borderless container-fluid">
						<thead>
							<tr className="d-flex">
								<th scope="col" className="col-md-2"></th>
								<th scope="col" className="col-md-10"></th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<th scope="row" className="col-md-2">
									Id:{" "}
								</th>
								<td className="col-md-10">{appUser.id}</td>
							</tr>
							<tr>
								<th scope="row">Name:</th>
								<td>{appUser.name}</td>
							</tr>
							<tr>
								<th scope="row">Username:</th>
								<td>{appUser.userName}</td>
							</tr>
							<tr>
								<th scope="row">Email:</th>
								<td>{appUser.email}</td>
							</tr>
							<tr>
								<th scope="row">Phone number:</th>
								<td>{appUser.phoneNumber}</td>
							</tr>

							<tr>
								<th scope="row">Date of birth:</th>
								<td>{getFormatDateTime(appUser.dob)}</td>
							</tr>

							<tr>
								<th scope="row">Role:</th>
								<td>{checkRole(appUser.roleId)}</td>
							</tr>
						</tbody>
					</table>
				</Modal.Body>
			</Modal>
		</>
	);
};

export default Info;
