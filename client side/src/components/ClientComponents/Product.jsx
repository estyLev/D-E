import { useEffect, useState } from "react"
   
import React, { Fragment } from "react";

import { useDispatch, useSelector } from "react-redux";
import {GetAllProducts} from '../../Redux/Products/ProductsThunk'
import {LoadProducts} from '../../Redux/Products/ProductsAction'
import { AddToBasket } from "../../Redux/Basket/BasketAction";
import { Link } from "react-router-dom"
import {GetProductsByCategory} from '../../Redux/Products/ProductsThunk'
import {withRouter} from "react-router-dom"
import ProductsStyle from '../Style/ProductsStyle.css'
import { MDBBtn } from "mdb-react-ui-kit";
import SortedByCategory from './SortByCategory'
import {ChangeCurrentCategory} from '../../Redux/Categorys/CategorysActions'

export default withRouter(function Product(props){
   let myDis = useDispatch()
    let products
    let allProducts = useSelector((store) => {return store.products.Products })
    let myBasket=useSelector((store)=>{return store.basket.Products})
    let currentUser=useSelector((store)=>{return store.users.currentUser})
    let currentCategory=useSelector((store)=>{return store.categorys.currentCategory})
    useEffect(async () => {
        let categoryCode=props.match.params.categoryCode;
        myDis(ChangeCurrentCategory(categoryCode))
        products=await GetProductsByCategory(categoryCode);
        myDis(LoadProducts(products))
     }, [])

    const Add=(item)=>{
        let newItem={
            ProductCode:item.productCode,
            ProductName:item.productName,
            Description:item.description,
            CategoryCode:item.categoryCode,
            Cost:item.cost,
            Picture:item.picture,
            Amount:1,
            finalPrice:item.cost
        }
        myDis(AddToBasket(newItem))
        console.log(myBasket);
    }
return <>
<SortedByCategory prodCode={currentCategory}></SortedByCategory>
<div style={ProductsStyle} id="contiener">
<Link to="/ProductsBasket">Basket</Link> 
<br></br>

<div>
 {
     allProducts!=undefined&&
     allProducts.length>0&&
     allProducts.map((item) => <>
     <div class="myDiv"><p>{item.description}</p>
     <img src={`/${item.picture}`}id="img"/>
     <br></br> 
     <input type="button" value="הוסף לסל"  onClick={()=>{Add(item)}} class="btn"/>
     
     </div>
    
     </>)
     
 }
 </div>
 </div>
</>
})
// export const PStyle={
//     disply:"flex",
//     flexWrap:"wrap",
//     alignItems:"flex start",
//     flexDirection:"row",
//     disply:"inline block",
//     textAlign:"center",
//     align:"center"

    
// }
// export const img={

//     width:"70px",
//     height:"70px"
// }
// export const prod={

//     flex:"200px",
//     height:"80x"
// }