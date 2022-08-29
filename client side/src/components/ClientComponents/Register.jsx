import { withRouter } from "react-router-dom"
import { useEffect, useState } from "react"
import { useDispatch, useSelector } from "react-redux";
import {AddUser} from '../../Redux/Users/UsersThunk'
import {AfterAddUser,UpdateCurrentUser} from '../../Redux/Users/UsersAction'
import LoginStyle from '../Style/LoginStyle.css'

export default withRouter(function Register(props) {
    let myUsers
    let myDis = useDispatch()
    let allUsers = useSelector((store) => { return store.users.Users })
    const registing=async (e,code,id,name,phone,address)=>{
        debugger
        e.preventDefault();
        let newUser={
            UserCode:code,
            UserId:id,
            UserName:name,
            UserPhone:phone,
            UserAddress:address
        }
        debugger
        myUsers=await AddUser(newUser)
        debugger
        myDis(AfterAddUser(myUsers))
        myDis(UpdateCurrentUser(newUser))
        debugger
        props.history.push({ pathname: '/Product' })
    }

    return <>
    <div style={LoginStyle}>
        <br></br>
    <div id="myForm">
    <div><h1><b>טופס הרשמה:</b></h1></div>
    <br /><br />
        
            <form  onSubmit={(e) => {
                registing(e,code.value,id.value,Uname.value,phone.value,address.value)
            }}>
                <input type="password" placeholder="הכנס קוד" id="code" class= "myInput" />
                <br /><br />
                <input type="number" placeholder="הכנס תעודת זהות" id="id" class= "myInput" />
                <br /><br />
                <input type="text" placeholder="הכנס שם" id="Uname" class= "myInput" />
                <br /><br />
                <input type="text" placeholder="הכנס טלפון" id="phone" class= "myInput" />
                <br /><br />
                <input type="text" placeholder="הכנס כתובת" id="address" class= "myInput" />
                <br /><br />
                <input type="submit" value="OK" class= "mybtn" />
            </form>
        </div>
        </div>
    </>
}
)
