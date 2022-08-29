import React from 'react';
import { MDBBtn, MDBContainer } from 'mdb-react-ui-kit';
import {FormsPage} from './components/Login1'
// import {NavbarPage} from './components/ClientComponents/NavbarPage'
import ProductsBasket from './components/ClientComponents/ProductsBasket'
// import Products from './components/ClientComponents/Products'
import Product from './components/ClientComponents/Product'
import { Provider } from 'react-redux';
import { myStore } from './Redux/Store';
import {HomePage} from './components/HomePage'
import {About} from './components/About'
import SortedByCategory from './components/ClientComponents/SortByCategory';
import {NotFound} from './components/NotFound'
import { BrowserRouter, Route, Redirect, Switch } from 'react-router-dom';
import {ViewProducts} from './components/ClientComponents/viewProducts'
import Login from './components/Login'
import Register from './components/ClientComponents/Register';
import ManagerMenu from './components/ManegerComponents/ManagerMenu';
import Category from './components/ManegerComponents/Category'
import ProductInManager from './components/ManegerComponents/Product'
import {Nav} from './components/Nav'
// import {
//   BrowserRouter,
//   Routes,
//   Route,
//   Link,
//   Switch
// } from "react-router-dom";

export const App=()=> {
  return <>
  <Provider store={myStore}>
    <BrowserRouter>
    <Nav></Nav>
    <Switch>
            <Route path="/Home" component={HomePage} exact ></Route>
            <Route path="/About" component={About} ></Route>
            <Route path="/Product/:categoryCode" component={Product} ></Route>
            <Route path="/ViewProducts" component={ViewProducts} ></Route>
            <Route path="/Login" component={Login}></Route>
            <Route path="/ProductsBasket" component={ProductsBasket} exact ></Route>
            <Route path="/SortedByCategory" component={SortedByCategory} exact ></Route>
            <Route path="/Register" component={Register} ></Route>
            <Route path="/ManagerMenu" component={ManagerMenu} ></Route>
            <Route path="/ProductInManager" component={ProductInManager} ></Route>
            <Route path="/Category" component={Category} ></Route>
            <Redirect from="/" to="/Home" ></Redirect>
            <Route component={NotFound} />
   </Switch>
 </BrowserRouter>
  </Provider>
  </>
}


