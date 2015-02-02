using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuildApp3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TestFunction();
            }

        }

        protected void TestFunction()
        {
            string TestUser = string.Empty;
            string Testuser2 = string.Empty;

            TestUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToUpper();



        }
    }
}