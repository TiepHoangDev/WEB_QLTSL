using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.KhachHang_ThietBi
{
    public partial class Delete : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString[""] == null || !int.TryParse(Request.QueryString[""].ToString(), out id))
            {
                Response.Redirect("Index.aspx");
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            new KHACHHANG_THIETBI_Bus().Delete(id);
            Response.Redirect("Index.aspx");
        }
    }
}