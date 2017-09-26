using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.thiet_bi
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
                ltrAction.Text = (isCreate ? "Thêm mới" : "Sửa") + " nhóm khách hàng";
                LoadData();
            }
        }

        private void LoadData()
        {
            if (!isCreate)
            {
                var ob = new THIET_BI_Bus().GetByID_THIETBI(id);
                if (ob == null) Response.Redirect("default.aspx");
                else
                {
                    txtName.Value = ob.TEN_THIETBI;
                }
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (new THIET_BI_Bus().GetAll().Any(q => q.TEN_THIETBI.Trim().ToLower().Equals(txtName.Value.Trim().ToLower())))
            {
                lblResult.Text = "Tên thiết bị này đã tồn tại, bạn hãy thêm tên khác";
            }
            else
            {
                var ob = new DTO.THIET_BI_Object()
                {
                    TEN_THIETBI = txtName.Value,
                    ID_THIETBI = id
                };
                if (isCreate) new THIET_BI_Bus().Insert(ob);
                else new THIET_BI_Bus().Update(ob);
                new Log_he_thong.LogHeThong().Add(isCreate ? Log_he_thong.LogHeThong.eAction.Add : Log_he_thong.LogHeThong.eAction.Edit);
                Response.Redirect("default.aspx");
            }
        }
    }
}