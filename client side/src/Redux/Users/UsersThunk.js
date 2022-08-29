import axios from "axios";

export const GetALlUsers = async () => {
    let users
    users = await axios.get("https://localhost:44377/api/user/getAllUsers")
    return users.data
}
export const AddUser = async (newUser) => {
   let users
    users = await axios.post("https://localhost:44377/api/user/AddUser",newUser)
    return users.data
}