import { Link } from "react-router-dom"
import HomePageStile from './Style/HomePageStile.css'
import {Advertisment} from './Advertisment'


export const Nav=()=>{


    return<>
   <div style={HomePageStile}>
    
<ul>
  <img id="logo" src="/logo.jpg" width="150px" height="150px" title="בחזרה לדף הבית"/>
  <li><Link to="/Home">Home</Link> <hr/> </li>
  <li><Link to="/ViewProducts">ViewProducts</Link> <hr/> </li>
  <li><Link to="/About">About :)</Link> <hr/> </li>
  <li><Link to="/Login">Login</Link> <hr/></li>
  <li><Link to="/Register">Register</Link> <hr/></li>
  

</ul>

</div>
<br></br>
<br></br><br></br><br></br>

    </>
}