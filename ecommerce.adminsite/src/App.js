import React, { lazy } from "react";
import "./App.css";
import Home from "./Components/Home/Home";
import Navbar from "./Components/Navbar";
import { Route, Routes } from "react-router-dom";
import { CATEGORY } from "./Constants/pages";


const Category = lazy(() => import('./Components/Category'));


export default function App() {
  return (
    <>
      <Routes>
        <Route path="/" element={<Navbar />}>
          <Route index element={<Home />} />
          <Route
            path={CATEGORY}
            element={
              <React.Suspense fallback={<>...</>}>
                <Category />
              </React.Suspense>
            }
            />
            <Route path="*" element={<h2>404</h2>} />
        </Route>
      </Routes>


    </>
  );
}
