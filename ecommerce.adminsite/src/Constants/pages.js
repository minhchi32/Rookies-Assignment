export const LOGIN='/login';
export const AUTH='/authentication/:action';
export const HOME='/';

export const CATEGORY = '/category/*';
export const LIST_CATEGORY = '/category';
export const CREATE_CATEGORY = '/create';
export const EDIT_CATEGORY = '/edit/:id';
export const EDIT_CATEGORY_ID = (id) => `/category/edit/${id}`;

export const UNAUTHORIZE = '/unauthorize';
export const NOTFOUND = '/notfound';