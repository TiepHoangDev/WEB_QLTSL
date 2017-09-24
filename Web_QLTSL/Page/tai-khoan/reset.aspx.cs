using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;

namespace Web_QLTSL.Page.tai_khoan
{
    public partial class reset : BasePage
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString[""] == null || !int.TryParse(Request.QueryString[""].ToString(), out id)) Response.Redirect("default.aspx");
            var ob = new NGUOI_DUNG_Bus().GetByID_NGUOIDUNG(id);
            if (ob == null) Response.Redirect("default.aspx");
            txtName.Text = ob.HO_TEN;

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if(new NGUOI_DUNG_Bus().ResetPassword(new Core.Login().GetNguoiDung().ID_NGUOIDUNG,txtPassword.Value,id)) Response.Redirect("default.aspx");
            else result.Text = "Reset thất bại, hãy kiểm tra lại.";
        }
    }
}