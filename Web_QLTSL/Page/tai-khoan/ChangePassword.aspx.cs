using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.tai_khoan
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (new Core.Login().GetNguoiDung() == null) Response.Redirect("/Login.aspx?=out");
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Value.Trim().Length < 8)
            {
                lblNewPass.Text = "Nhập mật khẩu ít nhất 8 kí tự.";
            }
            else if (!txtNewPassword.Value.Equals(txtRePassword.Value))
            {
                lblNewPass.Text = "Hai mật khẩu không giống nhau. Kiểm tra lại.";
            }
            else
            {
                var acc = new Core.Login().GetNguoiDung();
                if (acc.PASSWORD.Equals(txtPassword.Value))
                {
                    acc.PASSWORD = txtPassword.Value;
                    if (new BUS.NGUOI_DUNG_Bus().Update(acc))
                    {
                        Response.Redirect("Profile.aspx");
                    }
                    else
                    {
                        lblResult.Text = "Đổi mật khẩu thất bại";
                    }
                }
                else
                {
                    lblPass.Text = "Mật khẩu cũ không chính xác, vui lòng kiểm tra lại";
                }
            }
        }
    }
}