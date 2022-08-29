import { useState, useEffect } from "react"
import { withRouter } from "react-router-dom"
import { updateCategory, GetAllCategorys, deleteCategory,addCategory } from "../../Redux/Categorys/CategorysThunk"
import { useDispatch, useSelector } from "react-redux";
import { LoadCategorys } from '../../Redux/Categorys/CategorysActions'
import LoginStyle from '../Style/LoginStyle.css'

export default withRouter(function Category(props) {

    let allCategorys = useSelector((store) => { return store.categorys.Categorys })
    const [flagU, setFlagU] = useState(false)
    const [flagD, setFlagD] = useState(false)
    const [flagA, setFlagA] = useState(false)
    let result
    let categorys
    let myDis = useDispatch()

    useEffect(async () => {

        categorys = await GetAllCategorys()
        myDis(LoadCategorys(categorys))

    }, [])

    const update = async (e) => {
        e.preventDefault();
        result = allCategorys.find((cat) => cat.categoryName == e.target.catName.value)
        let newCategory = {
            categoryCode: result.categoryCode,
            categoryName: e.target.newCatName.value
        }
        categorys = await updateCategory(newCategory)
        myDis(LoadCategorys(categorys))
        setFlagU(false)
    }
    const Delete = async (e)=>{
        e.preventDefault();
        result = allCategorys.find((cat) => cat.categoryName == e.target.value)
        let catCode=result.categoryCode
        categorys = await deleteCategory(catCode)
        myDis(LoadCategorys(categorys))
        setFlagD(false)
    }
    const Add = async (e)=>{
        e.preventDefault();
        debugger
        let newCategory = {
            CategoryCode: e.target.catCode.value,
            CategoryName: e.target.newCatName.value
        }
        categorys = await addCategory(newCategory)
        myDis(LoadCategorys(categorys))
        setFlagA(false)
    }

    return <>
    <div style={LoginStyle} id="myForm">   
    <br></br><br></br>
        <input type="button" class="myInput" value="updateCategory" onClick={() => { setFlagU(true),setFlagD(false), setFlagA(false) }}></input>
        <input type="button" class="myInput" value="deleteCategory" onClick={() => { setFlagD(true) ,setFlagU(false), setFlagA(false)}}></input>
        <input type="button" class="myInput" value="addCategory" onClick={() => { setFlagA(true) ,setFlagD(false) ,setFlagU(false)}}></input>

        {
            flagU &&
            <form onSubmit={(e) => update(e)}>
                <select >
                    {
                        allCategorys != undefined &&
                        allCategorys.length > 0 &&
                        allCategorys.map((item) => <>
                            <option >{item.categoryName}</option>

                        </>)
                    }
                </select>
                <input type="text" placeholder="insert new name" id="newCatName" />
                <input type="submit" placeholder="lunch" />
            </form>
        }
        {
            flagD &&
            <select id="catName" onChange={(e) => Delete(e)}>
                {
                    allCategorys != undefined &&
                    allCategorys.length > 0 &&
                    allCategorys.map((item) => <>
                        <option >{item.categoryName}</option>

                    </>)
                }
            </select>
        }
        {
            flagA &&
            <form onSubmit={(e) => Add(e)}>
                <input type="text" placeholder="insert new code" id="catCode" />
                <input type="text" placeholder="insert new name" id="newCatName" />
                <input type="submit" placeholder="lunch" />
            </form>
        }
        </div>
    </>
})