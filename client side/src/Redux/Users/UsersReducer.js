import produce from 'immer';

const UsersIntialState = {
    Users: [],
    currentUser:undefined,
    managerCode:104
}

export const UsersReducer = produce((state, action) => {
    switch (action.type) {
        case "LOAD_USERS":
            state.Users = action.payload;
            break;
        case "UPDATE_CURRENT_USER":{
            state.currentUser=action.payload
            break;
        }
        case "AFTER_ADD_USER":{
            state.Users=action.payload
        }
       default:
            break;
    }
}, UsersIntialState)