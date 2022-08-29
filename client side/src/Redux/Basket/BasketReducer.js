import produce from 'immer';

const BasketsIntialState = {
    Products: [],
    FinalPrice:0
}

export const BasketReducer = produce((state, action) => {
    switch (action.type) {
        case "ADD_TO_BASKET":{
            let item=undefined;
            item=state.Products.find(i=>i.ProductCode==action.payload.ProductCode);
            if(item==undefined){
                state.Products.push(action.payload);
            }
           else{
            item.Amount++
            item.finalPrice+=item.Cost
           }
           state.FinalPrice+=action.payload.Cost
           break;
        }
        case "INCREASE":{
            let item=state.Products.find(i=>i.ProductCode==action.payload.ProductCode);
            item.Amount++
            item.finalPrice+=item.Cost
            state.FinalPrice+=action.payload.Cost
            break;
        }
        case "DECREASE":{
        let index=state.Products.findIndex(i=>i.ProductCode==action.payload.ProductCode);
        if(state.Products[index].Amount==1){
            state.Products.splice(index,1)
        }
        else{
            state.Products[index].Amount--
        state.Products[index].finalPrice-=state.Products[index].Cost
        }
        state.FinalPrice-=action.payload.Cost
        break;
        }
        case "DELETE":{
            let index=state.Products.findIndex(i=>i.ProductCode==action.payload.ProductCode);
            state.FinalPrice-=action.payload.Cost*action.payload.Amount
            state.Products.splice(index,1)
           
            break;
        }
        case "CHANGE_AMOUNT":{
            let index=state.Products.findIndex(i=>i.ProductCode==action.payload.item.ProductCode);
            let addAmount=action.payload.amount-state.Products[index].Amount;
            state.Products[index].Amount=action.payload.amount
            state.Products[index].finalPrice+=state.Products[index].Cost*addAmount
            state.FinalPrice+=state.Products[index].Cost*addAmount;
             break;
            }
         case "FINISH_SHOPPING":{
             state.Products=[]
             state.FinalPrice=0
         }   
        default:
            break;
    }
}, BasketsIntialState)