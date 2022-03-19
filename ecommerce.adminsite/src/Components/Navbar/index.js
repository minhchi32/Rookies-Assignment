import React, { useState } from "react";
import { Link, Outlet } from "react-router-dom";
import "./Navbar.css";
import { NavItemData } from "./NavItemData";
import "./Navbar.css";
import { IconContext } from "react-icons/lib";

export default function Navbar() {
	const [navItem, setNavItem] = useState(false);

	const showNavItem = () => setNavItem(!navItem);
	return (
		<>
			<IconContext.Provider value={{ color: "#fff" }}>
				<nav className="navbar navbar-expand-lg navbar-light shadow">
					<div className="container d-flex justify-content-between align-items-center">
						<a
							className="navbar-brand text-success logo h1 align-self-center"
							href="/"
						>
							{/* <img src="./Logo.png" alt="Logo" className="img-fluid" /> */}
							eCommerce.AdminSite
						</a>

						<button
							className="navbar-toggler border-0"
							type="button"
							data-bs-toggle="collapse"
							data-bs-target="#templatemo_main_nav"
							aria-controls="navbarSupportedContent"
							aria-expanded="false"
							aria-label="Toggle navigation"
						>
							<span className="navbar-toggler-icon"></span>
						</button>

						<div
							className="align-self-center collapse navbar-collapse flex-fill  d-lg-flex justify-content-lg-between"
							id="templatemo_main_nav"
						>
							<ul className="nav navbar-nav d-flex justify-content-between mx-lg-auto">
								{NavItemData.map((item, index) => {
									return (
										<li key={index} className={item.cName}>
											<Link to={item.path}>
												{item.icon}
												<span>{item.title}</span>
											</Link>
										</li>
									);
								})}
							</ul>
							<div className="navbar align-self-center d-flex">
								<div className="d-lg-none flex-sm-fill mt-3 mb-4 col-7 col-sm-auto pr-3">
									<div className="input-group">
										<input
											type="text"
											className="form-control"
											id="inputMobileSearch"
											placeholder="Search ..."
										/>
										<div className="input-group-text">
											<i className="fa fa-fw fa-search"></i>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</nav>
				<Outlet />
			</IconContext.Provider>
		</>
	);
}
