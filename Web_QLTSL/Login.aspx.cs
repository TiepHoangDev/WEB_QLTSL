using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString[""] != null)
            {
                new Core.Login().Logout();
            }
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            if (new Core.Login().CheckLogin(txtUsername.Value, txtPassword.Value))
            {
                Response.Redirect("/page/trang-chu");
            }
            else
            {
                lblResult.InnerText = "Sai tên đăng nhập hoặc mật khẩu";
            }
        }
    }
}