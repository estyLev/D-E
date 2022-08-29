import { useEffect, useState } from "react"
import { useDispatch, useSelector } from "react-redux";
import { Decrease,Increase,Delete,ChangeAmount,FinishShopping} from "../../Redux/Basket/BasketAction";
import {AddPurchase,AddPurchaseDetail} from '../../Redux/Basket/BasketTHunk'
//import {PStyle,prod,img} from './Product'
// import { Link } from "react-router-dom"
import {withRouter} from "react-router-dom"
import {BasketStyle}from '../Style/BasketStyle.css'
import Product from "../ClientComponents/Product";

export default withRouter(function ProductsBasket(props){


let myDis=useDispatch();
let myBasket=useSelector((store)=>{return store.basket.Products})
let currentUser=useSelector((store)=>{return store.users.currentUser})
let finalPrice=useSelector((store)=>{return store.basket.FinalPrice})

const increase=(item)=>{
    myDis(Increase(item));
}
const decrease=(item)=>{
    myDis(Decrease(item));
}
const deleteItem=(item)=>{
    myDis(Delete(item))
}
const change=(item,amount)=>{
    let help={item:item,
             amount:amount }
    myDis(ChangeAmount(help))
}
const ChangeRoute=()=>{
    props.history.push({pathname:'/Product/' +currentUser})
}
const payment=()=>{
    let purchase={
        PurchaseCode:finalPrice,
        PurchaseDate:new Date(),
        UserCode:currentUser.UserCode,
        Sum:finalPrice
    }
    AddPurchase(purchase);
    for (let i = 0; i < myBasket.length; i++) {
        let element = myBasket[i];
        AddPurchaseDetail(element)
    }
    myDis(FinishShopping())
    props.history.push({pathname:'/Home/'})
}

    return <>
    <div style={BasketStyle} id="mainBasket">
    <br></br>
    <div><h1><b>הסל שלי</b></h1></div>
    <p>לתשלום:{finalPrice}</p>
    {/* <Link to="/Product/">Products</Link>  */}
    <input type="button" class="myInput" value="בחזרה למוצרים" onClick={()=>{ChangeRoute()}}/>
    <br/><br/>
    <input type="button" class="myInput" value="לתשלום" onClick={()=>{payment()}}/>
    <div id="conteiner">
        { 
            myBasket.map((item)=><>
                <div class="myDivBas"><p>{item.Description}</p>
                <img src={`${item.Picture}`}id="img"/>
            <br/> <br/>
                <input type="button" value="-"  class="mybtn" onClick={()=>{decrease(item)}}/>
                 <select value={item.Amount} class="mybtn" onChange={(e)=>{change(item,e.target.value)}}  >
                    <option class="mybtn">1</option >
                    <option class="mybtn">2</option>
                    <option class="mybtn">3</option>
                    <option class="mybtn">4</option>
                    <option class="mybtn">5</option>
                    <option class="mybtn">6</option>
                    <option class="mybtn">7</option>
                    <option class="mybtn">8</option>
                    <option class="mybtn">9</option>
                    <option class="mybtn">10</option>
                    <option class="mybtn">11</option>
                </select>
                <input type="button" value="+" class="mybtn" onClick={()=>{increase(item)}}/>
                <input type="button" value="🗑" class="mybtn" onClick={()=>{deleteItem(item)}}/>
                <br/>
                
                <label>מחיר ליחידה:{item.Cost}</label>
               <p>מחיר כללי:{item.finalPrice}</p>
                </div>
            </>)
        }
    </div>
    </div>
    </>
    })