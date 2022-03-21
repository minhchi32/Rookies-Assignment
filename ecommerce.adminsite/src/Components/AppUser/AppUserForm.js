import React, { useEffect, useState } from "react";
import { Formik, Form } from "formik";
import * as Yup from "yup";
import { Link, useNavigate } from "react-router-dom";
import { NotificationManager } from "react-notifications";

import TextField from "../../Shared-Components/FormInputs/TextField";
import TextAreaField from "../../Shared-Components/FormInputs/TextAreaField";
import SelectField from "../../Shared-Components/FormInputs/SelectField";
import { LIST_APPUSER } from "../../Constants/pages";
import {
	createAppUserRequest,
	UpdateAppUserRequest,
} from "./services/request";

const initialFormValues = {
	name: "",
	description: "",
};

const validationSchema = Yup.object().shape({
	name: Yup.string().required("Required"),
});

const AppUserFormContainer = ({
	initialAppUserForm = {
		...initialFormValues,
	},
}) => {
	const [loading, setLoading] = useState(false);

	const isUpdate = initialAppUserForm.id ? true : false;

	const navigate = useNavigate();

	const handleResult = (result, message) => {
		if (result) {
			NotificationManager.success(
				`${isUpdate ? "Updated" : "Created"} Successful AppUser ${message}`,
				`${isUpdate ? "Update" : "Create"} Successful`,
				2000,
			);

			setTimeout(() => {
				navigate(LIST_APPUSER);
			}, 1000);
		} else {
			NotificationManager.error(message, "Create failed", 2000);
		}
	};

	const updateAppUserAsync = async (form) => {
		console.log("update appuser async");
		let data = await UpdateAppUserRequest(form.formValues);
		if (data) {
			handleResult(true, data.name);
		}
	};

	const createAppUserAsync = async (form) => {
		console.log("create appuser async");
		let data = await createAppUserRequest(form.formValues);
		if (data) {
			handleResult(true, data.name);
		}
	};

	return (
		<Formik
			initialValues={initialAppUserForm}
			enableReinitialize
			validationSchema={validationSchema}
			onSubmit={(values) => {
				setLoading(true);

				setTimeout(() => {
					if (isUpdate) {
						updateAppUserAsync({ formValues: values });
					} else {
						createAppUserAsync({ formValues: values });
					}

					setLoading(false);
				}, 1000);
			}}
		>
			{(actions) => (
				<Form className="container intro-y col-lg-6 col-12">
					<TextField
						name="name"
						label="Name"
						placeholder="input appuser name"
						isrequired="true"
					/>
					<br />
					<div className="row">
						<button
							className="btn btn-danger col-lg-5 col-12"
							type="submit"
							disabled={loading}
						>
							Save{" "}
							{loading && (
								<img src="/oval.svg" className="w-4 h-4 ml-2 inline-block" />
							)}
						</button>
						<div className="col-lg-2">
							<br />
						</div>
						<Link
							to={LIST_APPUSER}
							className="btn btn-outline-secondary col-lg-5 col-12"
						>
							Cancel
						</Link>
					</div>
				</Form>
			)}
		</Formik>
	);
};

export default AppUserFormContainer;
