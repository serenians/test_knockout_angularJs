using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using TestIdentitySmaple.Models;

namespace TestIdentitySmaple.Controllers
{
    public class AuthenticationFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            //filterContext.HttpContext.Session[""]
                //filterContext.Controller
            
            if (false)
            {
                filterContext.Result= new HttpUnauthorizedResult();
            }
        }
    }
    public class TestKnockoutJsController : Controller
    {
        //
        // GET: /TestKnockoutJs/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mapping()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetFriend()
        {
            var list = new List<Friend>();
            for (int i = 0; i < 3; i++)
            {
                list.Add(new Friend()
                {
                    Name =(i*3+i*i+1).ToString(),
                    FavoriteJsLibrary =(i*5+3).ToString() ,
                    KnowJs = true
                });
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TestMappingPost()
        {
            return View();
        }
        [HttpPost]
        public JsonResult TestMappingPost(KoTestViewModel model)
        {
            if (model != null)
            {
                return Json(new
                {
                    Success = true,
                    Message = ""
                });
            }
            else
            {
                return Json(new
                {
                    Success = true,
                    Message = ""
                });
            }
        }
    }
}