using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.loai_dich_vu
{
    public partial class Delete : BasePage
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CheckQuyen(Core.eQUYEN.THEM_SUA_XOA) == false) Response.Redirect("/NotQUYEN.aspx");
            if (Request.QueryString[""] == null || !int.TryParse(Request.QueryString[""].ToString(), out id))
            {
                Response.Redirect("default.aspx");
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            new LOAI_DICHVU_Bus().Delete(id);
            new Log_he_thong.LogHeThong().Add(Log_he_thong.LogHeThong.eAction.Delete);
            Response.Redirect("default.aspx");
        }
    }
}