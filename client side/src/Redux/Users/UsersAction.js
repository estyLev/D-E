export const LoadUsers = (value) => {
    return { type: "LOAD_USERS", payload: value }
}
export const UpdateCurrentUser = (value) => {
    return { type: "UPDATE_CURRENT_USER", payload: value }
}
export const AfterAddUser = (value) => {
    return { type: "AFTER_ADD_USER", payload: value }
}
