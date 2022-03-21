import React, { lazy } from 'react';
import { Route, Routes } from 'react-router-dom';

import { CREATE_APPUSER, EDIT_APPUSER } from '../../Constants/pages';

const CreateAppUser = lazy(() => import("./Create"));
const ListAppUser = lazy(() => import("./List"));
const UpdateAppUser = lazy(() => import("./Update"))

const AppUser = () => {
    return (
    <Routes>
        <Route index
            element={<ListAppUser />} 
        />
        <Route 
            path={CREATE_APPUSER}
            element={<CreateAppUser />} 
        />
        <Route 
            path={EDIT_APPUSER}
            element={<UpdateAppUser />} 
        />
    </Routes>
    )
};

export default AppUser;