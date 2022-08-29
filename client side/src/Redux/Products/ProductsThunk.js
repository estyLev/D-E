import axios from "axios";


export const GetAllProducts = async () => {
   
    let products
    products =await axios.get("https://localhost:44377/api/product/getAllProducts")
    return products.data
}
export const GetProductsByCategory = async (code) => {
   
    let products
    products =await axios.get("https://localhost:44377/api/product/GetProductListByCategory/"+code)
    return products.data
}

export const updateProducts = async (product) => {
    let products
    products =await axios.put("https://localhost:44377/api/product/UpdateProduct/"+product.productCode,product)
    return products.data
}

export const deleteProducts = async (productCode) => {
    let products
    products =await axios.delete("https://localhost:44377/api/product/DeleteProduct/"+productCode)
    return products.data
}