using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_QLTSL
{
    public class BasePage : System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            var acc = new Core.Login().GetNguoiDung();
            if (acc == null)
            {
                Response.Redirect("/Login");
            }
            base.OnLoad(e);
        }
    }
}