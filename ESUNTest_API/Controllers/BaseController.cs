using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ESUNTest_API.Controllers
{
    public class BaseController : ApiController
    {
        protected string sApiAddress = System.Configuration.ConfigurationManager.AppSettings["ApiUri"];

        protected string sAuthorization = System.Configuration.ConfigurationManager.AppSettings["Authorization"];
    }
}