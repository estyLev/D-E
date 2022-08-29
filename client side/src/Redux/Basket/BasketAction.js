export const AddToBasket=(value)=>{
    return {type:"ADD_TO_BASKET",payload:value}
}
export const Increase=(value)=>{
    return {type:"INCREASE",payload:value}
}
export const Decrease=(value)=>{
    return {type:"DECREASE",payload:value}
}
export const Delete=(value)=>{
    return {type:"DELETE",payload:value}
}
export const ChangeAmount=(value)=>{
    return {type:"CHANGE_AMOUNT",payload:value}
}
export const FinishShopping=()=>{
    return {type:"FINISH_SHOPPING"}
}