import produce from 'immer';

const ProductsIntialState = {
    Products: []
}

export const ProductsReducer = produce((state, action) => {
    switch (action.type) {
        case "LOAD_PRODUCTS":
            state.Products = action.payload;
            break;
      default:
            break;
    }
}, ProductsIntialState)