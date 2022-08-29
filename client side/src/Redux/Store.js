import { combineReducers, createStore } from "redux";
import {UsersReducer} from './Users/UsersReducer';
import {CategorysReducer} from './Categorys/CategorysReducer';
import {ProductsReducer} from './Products/ProductsReducer';
import {BasketReducer} from './Basket/BasketReducer'

let reducers=combineReducers(
    {
        users:UsersReducer,
        categorys:CategorysReducer,
        products:ProductsReducer,
        basket:BasketReducer
    }
)

export const myStore=createStore(reducers);