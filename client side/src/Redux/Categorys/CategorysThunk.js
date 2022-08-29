import axios from "axios";


export const GetAllCategorys = async () => {
    let Categorys
    Categorys =await axios.get("https://localhost:44377/api/category/getAllcategorys")
    return Categorys.data
}

export const updateCategory = async (category) => {
    let Categorys
    Categorys =await axios.put("https://localhost:44377/api/category/UpdateCategory/"+category.categoryCode,category)
    return Categorys.data
}

export const deleteCategory = async (categoryCode) => {
    let Categorys
    Categorys =await axios.delete("https://localhost:44377/api/category/DeleteCategory/"+categoryCode)
    return Categorys.data
}

export const addCategory = async (category) => {
    let Categorys
    Categorys =await axios.post("https://localhost:44377/api/category/AddCategory",category)
    return Categorys.data
}