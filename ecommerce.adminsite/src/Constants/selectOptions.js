import { getCategoriesOptionRequest } from '../Components/Category/services/request';

export const getCategoriesAsync = async (selectOptionsCategory) => {
    let data = await getCategoriesOptionRequest("");
    if (data)
    {            
        let categories = data.data;
        categories.map((item)=>{
            selectOptionsCategory.push({label:item.categoryName, value:item.categoryId})
        })
    }
    return (selectOptionsCategory)
}