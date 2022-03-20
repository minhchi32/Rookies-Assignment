import React, { useEffect, useState } from "react";
import SearchIcon from "@material-ui/icons/Search";

import { Link } from "react-router-dom";
import ProductTable from "./ProductTable";

import { getProductsRequest } from "../services/request";
import {
	ACCSENDING,
	DECSENDING,
	DEFAULT_PRODUCT_SORT_COLUMN_NAME,
	DEFAULT_PAGE_LIMIT,
} from "../../../Constants/paging";

const ListProduct = () => {
	const [query, setQuery] = useState({
		pageIndex: 1,
		pageSize: DEFAULT_PAGE_LIMIT,
		sortOrder: ACCSENDING,
		sortColumn: DEFAULT_PRODUCT_SORT_COLUMN_NAME,
	});

	const [search, setSearch] = useState("");
	const [products, setProducts] = useState("");

	const [selectedType, setSelectedType] = useState([
		{ id: 1, label: "All", value: 0 },
	]);

	const handleType = (selected) => {

		const selectedAll = selected.find((item) => item.id === 1);

		setSelectedType((prevSelected) => {
			if (!prevSelected.some((item) => item.id === 1) && selectedAll) {
				setQuery({
					...query,
					types: [],
				});

				return [selectedAll];
			}

			const newSelected = selected.filter((item) => item.id !== 1);
			const types = newSelected.map((item) => item.value);

			setQuery({
				...query,
				types,
			});

			return newSelected;
		});
	};

	const handleChangeSearch = (e) => {
		e.preventDefault();

		const search = e.target.value;
		setSearch(search);
	};

	const handlePage = (pageIndex) => {
		setQuery({
			...query,
			pageIndex,
		});
	};

	const handleSearch = () => {
		setQuery({
			...query,
			search,
		});
	};

	const handleSort = (sortColumn) => {
		const sortOrder = query.sortOrder === ACCSENDING ? DECSENDING : ACCSENDING;

		setQuery({
			...query,
			sortColumn,
			sortOrder,
		});
	};

	const fetchDataCallbackAsync = async () => {
		let data = await getProductsRequest(query);
		console.log("fetchDataCallbackAsync");
		console.log(data);
		setProducts(data);
	};

	useEffect(() => {
		async function fetchDataAsync() {
			let result = await getProductsRequest(query);
			setProducts(result.data);
		}

		fetchDataAsync();
	}, [query, products]);

	return (
		<>
			<div className="container-fluid">
				<br />
				<h2>Product list</h2>
				<div className="d-flex intro-x">
					<div className="d-flex align-items-center w-ld ml-auto">
						<div className="input-group">
							<input
								onChange={handleChangeSearch}
								value={search}
								type="text"
								className="form-control"
							/>
							<span onClick={handleSearch} className="border p-2 pointer">
								<SearchIcon />
							</span>
						</div>
					</div>
					&ensp;
					<div className="d-flex">
						<Link to="/product/create" type="button" className="btn btn-danger">
							Create new Product
						</Link>
					</div>
				</div>
				<br />

				<ProductTable
					products={products}
					handlePage={handlePage}
					handleSort={handleSort}
					sortState={{
						columnValue: query.sortColumn,
						orderBy: query.sortOrder,
					}}
					fetchData={fetchDataCallbackAsync}
				/>
			</div>
		</>
	);
};

export default ListProduct;
