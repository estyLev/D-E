using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;
using DTO;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        IPurchaseBLL PurchasesBLL;
        public PurchaseController(IPurchaseBLL _PurchasesBLL)
        {
            PurchasesBLL = _PurchasesBLL;
        }

        [HttpGet("GetAllPurchases")]
        public ActionResult GetAllPurchases()
        {
            return Ok(PurchasesBLL.GetAllPurchases());
        }

        [HttpGet("GetPurchaseByCode/{Code}")]
        public ActionResult GetPurchaseByCode(int Code)
        {
            return Ok(PurchasesBLL.GetPurchaseByCode(Code));
        }

        [HttpPost("AddPurchase")]
        public ActionResult AddPurchase(PurchaseDTO Purchase)
        {
            return Ok(PurchasesBLL.AddPurchase(Purchase));
        }

        [HttpPut("UpdatePurchase/{Code}")]
        public ActionResult UpdatePurchase(int Code, PurchaseDTO Purchase)
        {
            return Ok(PurchasesBLL.UpdatePurchase(Code, Purchase));
        }


        [HttpDelete("DeletePurchase/{Code}")]
        public ActionResult DeletePurchase(int Code)
        {
            return Ok(PurchasesBLL.DeletePurchase(Code));
        }
    }
}