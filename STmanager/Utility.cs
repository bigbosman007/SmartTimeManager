using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace STmanager
{
    class Utility
    {
        public static void MaximizeForm(Form DestinationForm)
        {
            DestinationForm.Size = new System.Drawing.Size(
                Screen.PrimaryScreen.Bounds.Width, 
                Screen.PrimaryScreen.Bounds.Height);
        }

        public static void TestAddBranch()
        {
            using (SmartTimeModel DbContext = new SmartTimeModel())
            {
                Branch HQ = new Branch
                {
                    branch_name = "Headquarter",
                    branch_add = "Prachinburi",
                };
                DbContext.Branches.Add(HQ);
                DbContext.SaveChanges();
            }
        }

        public static void TestDelete()
        {
            using (SmartTimeModel DbContext = new SmartTimeModel())
            {
                var empToDelete = (from d in DbContext.Employees
                                   where d.emp_id == "EMP1212312121"
                                   select d).FirstOrDefault<Employee>();
                DbContext.Employees.Remove(empToDelete);
                DbContext.SaveChanges();
            }
        }
        public static void TestEditBranch()
        {
            using (SmartTimeModel DbContext = new SmartTimeModel())
            {
                var HQ = (from b in DbContext.Branches
                          where b.branch_id == 1
                          select b).FirstOrDefault<Branch>();
                HQ.branch_add = "Kabinburi";
                DbContext.SaveChanges();
            }
        }

        public static void TestJoin()
        {
            using (SmartTimeModel DbContext = new SmartTimeModel())
            {
                var empInKabin = from emp in DbContext.Employees
                                 join bran in DbContext.Branches on emp.Branch_branch_id equals bran.branch_id
                                 where bran.branch_add == "Kabinburi"
                                 select new
                                 {
                                     emp.emp_id,
                                     emp.emp_tel,
                                     bran.branch_add
                                 };
                foreach (var e in empInKabin)
                    MessageBox.Show(e.emp_id);
            }
        }

        public static dynamic testjoinn()
        {
            using (SmartTimeModel DbContext = new SmartTimeModel())
            {
                var empin = from emp in DbContext.Employees
                            join branch in DbContext.Branches on emp.Branch_branch_id equals branch.branch_id
                            where branch.branch_name == "Headquarter"
                            select new { emp, branch };
                return empin.ToList();
            }
        
        }

        public static void addemp()
        {
            using (SmartTimeModel DbContext = new SmartTimeModel())
            {
                Employee emp = new Employee
                {
                    emp_id = "EMP1212312121",
                    emp_name = "หล่อมาก",
                    emp_last = "บอส",
                    emp_tel = "0909828780",
                    Branch_branch_id = 1
                };
                DbContext.Employees.Add(emp);
                DbContext.SaveChanges();
            }
            
        
        }
        public static bool TestLogin(string UserID)
        {
            using (SmartTimeModel DbContext = new SmartTimeModel())
            {
                var User = (from s in DbContext.Employees
                            where s.emp_id == UserID 
                            select s).ToList();

                if (User.Count == 0)
                    return false;
                else return true;
            }
        }
    }

    public sealed class SingletonForm<T> where T : Form, new()
    {
        private static Lazy<T> lazy = new Lazy<T>(() => new T());
        public static T Instance
        {
            get
            {
                if (lazy.Value.IsDisposed)
                    lazy = new Lazy<T>(() => new T());
                return lazy.Value;
            }
        }
    }
}