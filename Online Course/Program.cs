using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Course
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
           // Session session = Session.Instance;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());

            /*switch (session.Name)
            {
                case "Admin":
                    Application.Run(new FormMenu());
                    break;

                default:
                    break;
            }*/
        }
    }
}
