using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using TestIdentitySample.Security;
using TestIdentitySmaple.Models;

namespace TestIdentitySmaple.Controllers
{
    public class TestEncyptionController : Controller
    {
        private CryptoHelper cryptoHelper;
        private const  string sharedSecret="sharedKey";

        public TestEncyptionController()
        {
            var salt = "testSaltString";
            cryptoHelper= new CryptoHelper(salt);
        }
        //
        // GET: /TestEncyption/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AES()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AES(EncryptionTestViewModel model)
        {
            try
            {
                model.Destination = cryptoHelper.EncryptStringAES(model.Source, sharedSecret);
            }
            catch (Exception ex)
            {
                model.Destination = ex.Message;
            }
            return View(model);
        }

	}
}