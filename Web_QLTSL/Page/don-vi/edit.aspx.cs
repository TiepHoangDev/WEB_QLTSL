using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.don_vi
{
    public partial class Edit : BasePage
    {
        bool isCreate;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CheckQuyen(Core.eQUYEN.THEM_SUA_XOA) == false) Response.Redirect("/NotQUYEN.aspx");
            isCreate = Request.QueryString[""] == null || !int.TryParse(Request.QueryString[""].ToString(), out id);
            if (!IsPostBack)
            {
                ltrAction.Text = (isCreate ? "Thêm mới" : "Sửa") + " đơn vị";
                LoadData();
            }
        }

        private void LoadData()
        {
            if (!isCreate)
            {
                var ob = new DON_VI_Bus().GetByID_DONVI(id);
                if (ob == null) Response.Redirect("default.aspx");
                else
                {
                    txtTenDonVi.Value = ob.TEN_DONVI;
                }
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (new DON_VI_Bus().GetAll().Any(q => q.TEN_DONVI.Trim().ToLower().Equals(txtTenDonVi.Value.Trim().ToLower())))
            {
                lblResult.Text = "Đơn vị này đã tồn tại, bạn hãy thêm tên khác";
            }
            else
            {
                var ob = new DTO.DON_VI_Object()
                {
                    TEN_DONVI = txtTenDonVi.Value,
                    ID_DONVI = id
                };
                if (isCreate) new DON_VI_Bus().Insert(ob);
                else new DON_VI_Bus().Update(ob);
                new Log_he_thong.LogHeThong().Add(isCreate ? Log_he_thong.LogHeThong.eAction.Add : Log_he_thong.LogHeThong.eAction.Edit);
                Response.Redirect("default.aspx");
            }
        }
    }
}