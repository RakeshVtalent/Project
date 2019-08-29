using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GitCRUD.IRepositary;
using GitCRUD.Models;

namespace GitCRUD.Repositary
{
    public class Reposit : IReposit
    {
        public Employee UpdateEmployee(Employee emp)
        {
            try
            {
                using (TFSDBEntities db = new TFSDBEntities())
                {
                    db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch(Exception Ex)
            {

            }
            return emp;
        }
    }
}