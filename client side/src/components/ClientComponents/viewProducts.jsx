import { useEffect, useState } from "react"
import { useDispatch, useSelector } from "react-redux";
import {GetAllProducts} from '../../Redux/Products/ProductsThunk'
import {LoadProducts} from '../../Redux/Products/ProductsAction'
import { AddToBasket } from "../../Redux/Basket/BasketAction";
import { Link } from "react-router-dom"
import {PStyle,prod,img} from './Product'
import {HomePage} from '../HomePage';
import viewProductsStyle from '../Style/viewProductsStyle.css'


export const ViewProducts=()=>{
    let myDis = useDispatch()
    let myProducts
    let allProducts = useSelector((store) => { return store.products.Products })
   
    useEffect(async () => {
          
        myProducts = await GetAllProducts()
        myDis(LoadProducts(myProducts))

    }, [])

   
return <>
<Link to="/Home">Home</Link> 

<div style={viewProductsStyle} id="contiener">
 {
     allProducts!=undefined&&
     allProducts.length>0&&
     allProducts.map((item) => <>
     <div class="myDiv"><p>{item.description}</p>
     <img src={`${item.picture}`} id="img"/>
     <br></br> <br></br>
     </div>
    
     </>)
     
 }
 </div>
</>
}
