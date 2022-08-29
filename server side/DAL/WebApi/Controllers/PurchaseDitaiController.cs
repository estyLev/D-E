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
    public class PurchaseDitailController : ControllerBase
    {
        IPurchaseDitailBLL PurchaseDitailsBLL;
        public PurchaseDitailController(IPurchaseDitailBLL _PurchaseDitailsBLL)
        {
            PurchaseDitailsBLL = _PurchaseDitailsBLL;
        }

        [HttpGet("GetAllPurchaseDitails")]
        public ActionResult GetAllPurchaseDitails()
        {
            return Ok(PurchaseDitailsBLL.GetAllPurchaseDitails());
        }

        [HttpGet("GetPurchaseDitailByCode/{Code}")]
        public ActionResult GetPurchaseDitailByCode(int Code)
        {
            return Ok(PurchaseDitailsBLL.GetPurchaseDitailByCode(Code));
        }

        [HttpPost("AddPurchaseDitail")]
        public ActionResult AddPurchaseDitail(PurchaseDitailDTO PurchaseDitail)
        {
            return Ok(PurchaseDitailsBLL.AddPurchaseDitail(PurchaseDitail));
        }

        [HttpPut("UpdatePurchaseDitail/{Code}")]
        public ActionResult UpdatePurchaseDitail(int Code, PurchaseDitailDTO PurchaseDitail)
        {
            return Ok(PurchaseDitailsBLL.UpdatePurchaseDitail(Code, PurchaseDitail));
        }


        [HttpDelete("DeletePurchaseDitail/{Code}")]
        public ActionResult DeletePurchaseDitail(int Code)
        {
            return Ok(PurchaseDitailsBLL.DeletePurchaseDitail(Code));
        }
    }
}