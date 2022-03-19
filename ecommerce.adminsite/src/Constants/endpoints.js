const Endpoints = {
    authorize: 'api/authorize',
    me: 'api/authorize/me',

    product: 'api/products',
    productId: (id)=>`api/products/${id}`,

    category: 'api/Categories',
    categoryOption: (getParam)=>`api/categories/option?getParam=${getParam}`,
    categoryId: (id)=>`api/categories/${id}`,

};

export default Endpoints;