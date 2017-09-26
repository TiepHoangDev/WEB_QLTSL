using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.tai_khoan
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var acc = new Core.Login().GetNguoiDung();
            if (acc == null) Response.Redirect("/Login.aspx");
            else if (!IsPostBack)
            {
                txtHoTen.Value = acc.HO_TEN;
                txtSDT.Value = acc.SDT.ToString();
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            var acc = new Core.Login().GetNguoiDung();
            if (txtPassword.Value.Trim().Equals(acc.PASSWORD))
            {
                acc.HO_TEN = txtHoTen.Value;
                acc.SDT = int.Parse(txtSDT.Value);
                lblReslut.Text = new BUS.NGUOI_DUNG_Bus().Update(acc) ? "Sửa thông tin thành công" : "Sửa thông tin thất bại";
            }
            else
            {
                lblPass.Text = "Nhập mật khẩu không chính xác. Xin hãy nhập lại";
            }
        }
    }
}