import { Link,withRouter } from "react-router-dom"
import { useEffect, useState } from "react"
import { useDispatch, useSelector } from "react-redux";
import {LoadCategorys} from '../../Redux/Categorys/CategorysActions'
import {GetAllCategorys} from '../../Redux/Categorys/CategorysThunk'
import {ChangeCurrentCategory} from '../../Redux/Categorys/CategorysActions'
import Product from '../ClientComponents/Product'
import {LoadProducts} from '../../Redux/Products/ProductsAction'
import {GetAllProducts} from '../../Redux/Products/ProductsThunk'
import {GetProductsByCategory} from '../../Redux/Products/ProductsThunk'
import {Sort} from '../Style/Sort.css'


export  default withRouter(function SortedByCategory(props){

    let myDis = useDispatch()
    let myCategorys
    let products
    let allCategorys = useSelector((store) => { return store.categorys.Categorys })
    let allProducts = useSelector((store) => {return store.products.Products })
    let currentCategory=useSelector((store)=>{return store.categorys.currentCategory})
    // let myBasket=useSelector((store)=>{return store.basket.Products})
    // c
    useEffect(async () => {
          
        myCategorys = await GetAllCategorys()
        myDis(LoadCategorys(myCategorys))

    }, [])

const getProdacts = async(code) => {
myDis(ChangeCurrentCategory(code))
products=await GetProductsByCategory(currentCategory);
myDis(LoadProducts(products))
props.history.push({pathname:'/Product/' +code})
} 

    return <>
    <div style={Sort}>
    <br></br><br></br>
    <div id="divCat">
        {
            allCategorys!=undefined&&
            allCategorys.length>0&&
            allCategorys.map(item=><>
            <input type="button" class="cat" value={item.categoryName} onClick={()=>getProdacts(item.categoryCode)}/>
            </>)
        }
    </div>
    {/* <Product props={currentCategory}></Product> */}
    </div>
    </>
})