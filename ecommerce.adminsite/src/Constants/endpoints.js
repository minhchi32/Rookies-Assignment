const Endpoints = {
    authorize: 'api/authorize',
    me: 'api/authorize/me',

    product: 'api/Products',
    productId: (id)=>`api/Products/${id}`,

    category: 'api/Categories',
    categoryOption: (getParam)=>`api/Categories/option?getParam=${getParam}`,
    categoryId: (id)=>`api/Categories/${id}`,

};

export default Endpoints;