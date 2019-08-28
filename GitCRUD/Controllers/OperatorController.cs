using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GitCRUD.BusinessAccessLayer;
using GitCRUD.Repositary;

namespace GitCRUD.Controllers
{
    public class OperatorController : ApiController
    {
        public BAL Obj = new BAL(new Reposit());
    }
}
