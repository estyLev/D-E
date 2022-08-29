import { withRouter } from "react-router-dom"
import { useEffect, useState } from "react"
import { useDispatch, useSelector } from "react-redux";
import { GetALlUsers } from '../Redux/Users/UsersThunk'
import { LoadUsers } from '../Redux/Users/UsersAction'
//import { PStyle, prod, img } from './ClientComponents/Product'
import { UpdateCurrentUser } from '../Redux/Users/UsersAction'
import LoginStyle from './Style/LoginStyle.css'

export default withRouter(function Login(props) {
    let myUsers
    let result
    const [isExist, setIsExist] = useState(false)
    let myDis = useDispatch()
    let allUsers = useSelector((store) => { return store.users.Users })
    let managmer = useSelector((store) => { return store.users.managerCode })

    useEffect(async () => {
        myUsers = await GetALlUsers()
        myDis(LoadUsers(myUsers))
        // console.log(allUsers);

    }, [])

    const check = (Cname, code) => {

        result = allUsers.find((user) => user.userCode == code)
        if (result == undefined) {
            props.history.push({ pathname: '/Register' })
            return;
        }
        else {
            let User = {
                UserCode: result.userCode,
                UserId: result.userId,
                UserName: result.userName,
                UserPhone: result.userPhone,
                UserAddress: result.userAddress
            }
            myDis(UpdateCurrentUser(User))
            if (result.userCode != managmer) {
                props.history.push({ pathname: '/SortedByCategory' })
            }
            else {
                props.history.push({ pathname: '/ManagerMenu' })
            }

        }

    }
    return <>
        <div style={LoginStyle}>
            <br></br>
            <br></br>
         <div id="myForm">
                <form  onSubmit={() => {
                    check(Cname.value, code.value)
                }}>
                    <input type="text" placeholder="הכנס שם" id="Cname" class= "myInput"/>
                    <br /><br />
                    <input type="password" placeholder="הכנס סיסמא" id="code"class= "myInput" />
                    <br /><br />
                    <input type="submit" value="OK" class= "mybtn"/>
                </form>
            </div>
        </div>
    </>
}
)