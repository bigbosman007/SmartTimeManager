using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STmanager
{
    partial class EventLog
    {
        public enum EventLogType
        {
            Login,
            Logout
        }
    }

    partial class Employee
    {
        //PermissionBase EmployeePermissionObj;
        public enum EmployeePosition
        {
            Administrator,
            Manager,
            Saleperson
        }

        public PermissionBase EmployeePermission {get; private set;}

        private int EmployeePositionConstant;
        public int emp_position
        {
            get { return EmployeePositionConstant; }
            set
            {
                switch (value)
                {
                    case ((int)EmployeePosition.Administrator):
                        EmployeePermission = new AdministratorPermission();
                        break;
                    case ((int)EmployeePosition.Manager):
                        EmployeePermission = new ManagerPermission();
                        break;
                    case ((int)EmployeePosition.Saleperson):
                        EmployeePermission = new SalepersonPermission();
                        break;
                    default:
                        throw new InvalidOperationException(
                            "Employee position value must be selected from Employee.EmployeePosition Enumerator");
                }
                EmployeePositionConstant = value;
            }
        }
    }
}
