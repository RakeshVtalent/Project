using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GitCRUD.IRepositary;
using GitCRUD.Repositary;
using GitCRUD.Models;

namespace GitCRUD.BusinessAccessLayer
{
    public class BAL
    {
        IReposit Iobj;
        public BAL(Reposit _Iobj)
        {
            Iobj = _Iobj;
        }
        public Employee UpdateEmployee(Employee emp)
        {
            return Iobj.UpdateEmployee(emp);
        }
    }
}