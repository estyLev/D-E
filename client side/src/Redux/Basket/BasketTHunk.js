import axios from "axios";

export const AddPurchase = async (purchase) => {
   await axios.post("https://localhost:44377/api/Purchase/AddPurchase/",purchase)
 }
 export const AddPurchaseDetail = async (purchaseDetails) => {
    await axios.post("https://localhost:44377/api/PurchaseDitail/AddPurchaseDitail/",purchaseDetails)
  }