using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GitCRUD.BusinessAccessLayer;
using GitCRUD.Repositary;
using GitCRUD.Models;

namespace GitCRUD.Controllers
{
    public class OperatorController : ApiController
    {
        public BAL Obj = new BAL(new Reposit());
        [HttpGet]
        [Route("api/Operator/UpdateEmployee")]
        public HttpResponseMessage UpdateEmployee([FromBody] Employee emp)
        {
            var listemp = Obj.UpdateEmployee(emp);
            try
            {
             if(listemp !=null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, listemp);
                }
             else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Record not found");                  
                }
            }
            catch(Exception Ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex.Message.ToString());
            }
        }
    }
    
}
