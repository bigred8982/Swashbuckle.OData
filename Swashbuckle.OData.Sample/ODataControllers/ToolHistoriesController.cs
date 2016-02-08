using SwashbuckleODataSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.OData;
using System.Web.OData.Routing;

namespace SwashbuckleODataSample.ODataControllers
{
    public class ToolHistoriesController : ODataController
    {
        [EnableQuery]
        public IHttpActionResult Get()
        {
            throw new NotImplementedException();
        }

        [EnableQuery]
        public IHttpActionResult Get([FromODataUri] int key)
        {
            throw new NotImplementedException();
        }

        [EnableQuery]
        [ODataRoute("ToolHistories({code})")]
        //[ResponseType(typeof(ToolHistory))]
        public IHttpActionResult GetByCode([FromODataUri] string code)
        {
            throw new NotImplementedException();
        }
    }
}