import {withRouter} from "react-router-dom"
import LoginStyle from '../Style/LoginStyle.css'
export default withRouter(function ManagerMenu(props){
    const Category=()=>{
        props.history.push({ pathname: '/Category' })
    }
    const Product=()=>{
        props.history.push({ pathname: '/ProductInManager' })
    }
    return<>
    <div style={LoginStyle} id="myForm">
    <br></br><br></br>
    <input type="button" value="category" onClick={()=>{Category()}} class="myInput"></input>
    <input type="button" value="product" onClick={()=>{Product()}}  class="myInput"></input>
    </div>
    </>
})