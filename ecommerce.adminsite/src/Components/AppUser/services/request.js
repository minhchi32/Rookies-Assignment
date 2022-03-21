import { AxiosResponse } from "axios";
import qs from 'qs';

import RequestService from '../../../Services/request';
import EndPoints from '../../../Constants/endpoints';

export function createAppUserRequest(appUserForm) {
    const formData = new FormData();

    Object.keys(appUserForm).forEach(key => {
        formData.append(key, appUserForm[key]);
    });

    return RequestService.axios.post(EndPoints.appUser, formData);
}

export function getAppUsersRequest(query) {
    return RequestService.axios.get(EndPoints.appUser, {
        params: query,
        paramsSerializer: params => qs.stringify(params),
    });
}

export function UpdateAppUserRequest(appUserForm) {
    const formData = new FormData();

    Object.keys(appUserForm).forEach(key => {
        formData.append(key, appUserForm[key]);
    });

    return RequestService.axios.put(EndPoints.appUserId(appUserForm.id ?? - 1), formData);
}

export function DisableAppUserRequest(appUserId) {
    return RequestService.axios.delete(EndPoints.appUserId(appUserId));
}