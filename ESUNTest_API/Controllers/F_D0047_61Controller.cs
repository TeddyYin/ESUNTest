using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ESUNTest_API.Models;
using Newtonsoft.Json;
using RestSharp;
using ViewModels.API.F_D0047_61;

namespace ESUNTest_API.Controllers
{
    public class F_D0047_61Controller : BaseController
    {
        private ESUNTestContext db = new ESUNTestContext();

        #region -- GET: api/F_D0047_61 --
        /// <summary>
        /// api/F_D0047_61
        /// </summary>
        /// <returns>mF_D0047_61</returns>
        public IHttpActionResult GetF_D0047_61()
        {
            string sUrl = sApiAddress + sAuthorization + "&elementName=Td&limit=1&locationName=文山區&timeFrom=2021-02-26T00%3A00%3A00&timeTo=2021-02-26T09%3A00%3A00";

            RestClient rcClient = new RestClient(sUrl);
            RestRequest request = new RestRequest();

            IRestResponse<List<mF_D0047_61>> response = rcClient.Execute<List<mF_D0047_61>>(request);

            mF_D0047_61 oData = JsonConvert.DeserializeObject<mF_D0047_61>(response.Content.ToString());

            return Ok(oData);
        } 
        #endregion
    }
}
