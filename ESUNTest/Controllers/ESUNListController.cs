using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ESUNTest.Models.F_D0047_61;
using RestSharp;
using ViewModels.API.F_D0047_61;

namespace ESUNTest.Controllers
{
    public class ESUNListController : BaseController
    {
        // GET: ESUNList
        public ActionResult Index()
        {
            string sUrl = ApiAddress + "api/F_D0047_61";

            RestClient client = new RestClient(sUrl);

            RestRequest request = new RestRequest();

            IRestResponse<mF_D0047_61> response = client.Execute<mF_D0047_61>(request);

            mF_D0047_61 oData = response.Data;

            VMF_D0047_61 vm = new VMF_D0047_61(oData);

            return View(vm);
        }
    }
}
