import produce from 'immer';

const CategorysIntialState = {
    Categorys: [],
    currentCategory:0
}

export const CategorysReducer = produce((state, action) => {
    switch (action.type) {
        case "LOAD_CATEGORYS":
            state.Categorys = action.payload;
            break;
        case "CHANGE_CURRENT_CATEGORY":
            state.currentCategory = action.payload;
            break;
        default:
            break;
    }
}, CategorysIntialState)