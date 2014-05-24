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
                Screen.PrimaryScreen.WorkingArea.Width, 
                Screen.PrimaryScreen.WorkingArea.Height);
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