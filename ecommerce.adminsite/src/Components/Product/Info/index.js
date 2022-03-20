import React from "react";
import { Modal } from "react-bootstrap";

import { checkStatus } from "../../../Constants/Status/index"

const Info = ({ product, handleClose }) => {

	return (
		<>
			<Modal show={true} onHide={handleClose} size="xl">
				<Modal.Header closeButton>
					<Modal.Title id="login-modal">
						Detailed Product Information
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
								<td className="col-md-10">{product.id}</td>
							</tr>
							<tr>
								<th scope="row">Name:</th>
								<td>{product.name}</td>
							</tr>
							<tr>
								<th scope="row">Price:</th>
								<td>{product.price}</td>
							</tr>
							<tr>
								<th scope="row">DecreasePrice:</th>
								<td>{product.decreasedPrice}</td>
							</tr>
							<tr>
								<th scope="row">Quantity sale:</th>
								<td>{product.quantitySale}</td>
							</tr>

							<tr>
								<th scope="row">Rate:</th>
								<td>{product.totalPointRate/[product.countRate]}</td>
							</tr>

							<tr>
								<th scope="row">Status:</th>
								<td>{checkStatus(product.status)}</td>
							</tr>
						</tbody>
					</table>
				</Modal.Body>
			</Modal>
		</>
	);
};

export default Info;
