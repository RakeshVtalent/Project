using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitCRUD.Models;

namespace GitCRUD.IRepositary
{
   public interface IReposit
    {
        List<Department> DepartmentData();
        List<Employee> AllEmployeeData();
        Employee InsertEmployee(Employee emp);
        
        Employee UpdateEmployee(Employee emp);
    }
}
