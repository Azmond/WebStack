using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStringStack.Models.Repository;
using WebStringStack.Models;

namespace WebStringStack.Controllers
{
    public class ApiController : Controller
    {
        IStringStackRepository reposetory = null;

        public ApiController(IStringStackRepository repo)
        {
            reposetory = repo;
        }


        // GET/POST: api/push
        public JsonResult Push(string data)
        {
            var result = new ApiResultModel() { data = "", success = true };
            if (Request.HttpMethod.Equals("POST") && data!=null)
                reposetory.Push(data);
            else
                result.success = false;
            return Json(result,JsonRequestBehavior.AllowGet);
        }

        // GET/POST: api/pop
        public JsonResult Pop()
        {
            string str;
            var result = new ApiResultModel() { data = "", success = false };
            if (Request.HttpMethod.Equals("POST"))
            {
                if (reposetory.Pop(out str))
                {
                    result.data = str;
                    result.success = true;
                }
            }
            return Json(result,JsonRequestBehavior.AllowGet);
        }

        // GET/POST: api/peek
        public JsonResult Peek()
        {
            string str;
            var result = new ApiResultModel() { data = "", success = true };
            if (reposetory.Peek(out str))
                result.data = str;
            else
                result.success = false;
            return Json(result,JsonRequestBehavior.AllowGet);
        }

        // GET/POST: api/size

        public JsonResult Size()
        {
            var result = new ApiResultModel() { data = reposetory.Size().ToString(), success = true };
            return Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}