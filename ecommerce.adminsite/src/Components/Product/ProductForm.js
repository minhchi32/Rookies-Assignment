import React, { useEffect, useState } from "react";
import { Formik, Form } from "formik";
import * as Yup from "yup";
import { Link, useNavigate } from "react-router-dom";
import { NotificationManager } from "react-notifications";

import TextField from "../../Shared-Components/FormInputs/TextField";
import TextAreaField from "../../Shared-Components/FormInputs/TextAreaField";
import SelectField from "../../Shared-Components/FormInputs/SelectField";
import FileUpload from "../../Shared-Components/FormInputs/FileUpload";
import { getCategoriesAsync } from "../../Constants/selectOptions";
import { LIST_PRODUCT } from "../../Constants/pages";
import { createProductRequest, UpdateProductRequest } from "./services/request";
import { getCategoriesOptionRequest } from "../Category/services/request";

const initialFormValues = {
	name: "",
	price: "",
	decreasedPrice: "",
	categoryId: "",
};

const validationSchema = Yup.object().shape({
	name: Yup.string().required("Required"),
	price: Yup.string().required("Required"),
	decreasedPrice: Yup.string(),
	categoryId: Yup.string().required("Required"),
});

const ProductFormContainer = ({
	initialProductForm = {
		...initialFormValues,
	},
}) => {
	const [loading, setLoading] = useState(false);
	const [selectCategoryOption, setSelectCategoryOptions] = useState([]);

	const isUpdate = initialProductForm.id ? true : false;

	const navigate = useNavigate();

	useEffect(() => {
		async function fetchDataAsync() {
			let categoryResult = await getCategoriesOptionRequest("child");
			setSelectCategoryOptions(categoryResult.data);
		}

		fetchDataAsync();
	}, []);

	const handleResult = (result, message) => {
		if (result) {
			NotificationManager.success(
				`${isUpdate ? "Updated" : "Created"} Successful Product ${message}`,
				`${isUpdate ? "Update" : "Create"} Successful`,
				2000,
			);

			setTimeout(() => {
				navigate(LIST_PRODUCT);
			}, 1000);
		} else {
			NotificationManager.error(message, "Create failed", 2000);
		}
	};

	const updateProductAsync = async (form) => {
		let data = await UpdateProductRequest(form.formValues);
		if (data) {
			handleResult(true, data.name);
		}
		console.log("update product async");
	};

	const createProductAsync = async (form) => {
		let data = await createProductRequest(form.formValues);
		if (data) {
			handleResult(true, data.name);
		}
		console.log("create product async");
	};
	const selectOptionsCategory = [];
	getCategoriesAsync(selectOptionsCategory);
	return (
		<Formik
			initialValues={initialProductForm}
			enableReinitialize
			validationSchema={validationSchema}
			onSubmit={(values) => {
				setLoading(true);

				setTimeout(() => {
					if (isUpdate) {
						updateProductAsync({ formValues: values });
					} else {
						createProductAsync({ formValues: values });
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
						placeholder="input product name"
						isrequired
					/>
					<TextField
						name="price"
						label="Price"
						placeholder="input product price"
						isrequired
					/>
					<TextField
						name="decreasedPrice"
						label="Decrease Price"
						placeholder="input product decrease price"
					/>
					<SelectField
						name="categoryId"
						label="CategoryId"
						options={selectCategoryOption.map((item) => {
							return { id: item.id, label: item.name, value: item.id };
						})}
						isrequired
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
							to={LIST_PRODUCT}
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

export default ProductFormContainer;
