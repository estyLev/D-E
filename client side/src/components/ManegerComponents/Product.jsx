import { useState, useEffect } from "react"
import { withRouter } from "react-router-dom"
import { useDispatch, useSelector } from "react-redux";
import { GetAllProducts, deleteProducts, updateProducts } from '../../Redux/Products/ProductsThunk'
import { LoadProducts } from '../../Redux/Products/ProductsAction'
import LoginStyle from '../Style/LoginStyle.css'
//import {PStyle,prod,img} from '../ClientComponents/Product'

export default withRouter(function ProductInManager(props) {

    const [flag, setFlag] = useState(false)
    const [ProdactName, setProdactName] = useState()
    let allProducts = useSelector((store) => { return store.products.Products })

    let myProducts
    let myDis = useDispatch()
    useEffect(async () => {
        myProducts = await GetAllProducts()
        myDis(LoadProducts(myProducts))
    }, [])
    const update = async (prodact) => {
        let newProduct = {
            ...prodact,
            productName: ProdactName
        }
        myProducts = await updateProducts(newProduct)
        myDis(LoadProducts(myProducts))

    }
    const Delete = async (prodact) => {
        myProducts = await deleteProducts(prodact.productCode)
        myDis(LoadProducts(myProducts))
    }
    return <>
        <div id="myForm" id="conteiner">
            <br></br><br></br>
        <div>
                <p>!!!!!אזהרה!</p>
                <p>!!!!!!!!!כפתור המחיקה אכן מוחק מוצרים</p>
                <p>אין רשות ללחוץ עליו</p>
                <p>!!!!!!!ראי הוזהרת</p>
            </div>
            {

                allProducts != undefined &&
                allProducts.length > 0 &&
                allProducts.map((item) => <>
                    <div class="mynewDiv" ><p>{item.description}</p>
                        <img src={`${item.picture}`} id="img" />
                        <br></br><br></br>
                        <input type="button" class="mynewInput" value="update" onClick={() => { setFlag(!flag) }} />
                        {flag && <input type="text" class="mynewInput" placeholder="enter new name" onChange={(e) => { setProdactName(e.target.value) }} />}
                        {flag && <input type="button" class="mynewInput" value="OK" onClick={() => update(item)} />}
                        <input type="button" value="delete 🗑" class="mynewInput" onClick={() => Delete(item)} />
                        <br></br> <br></br>
                    </div>

                </>)
            }
        </div>
    </>
})