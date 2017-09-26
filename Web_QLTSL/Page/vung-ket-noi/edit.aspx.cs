using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.vung_ket_noi
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
                ltrAction.Text = (isCreate ? "Thêm mới" : "Sửa") + " vùng kết nối";
                LoadData();
            }
        }

        private void LoadData()
        {
            if (!isCreate)
            {
                var ob = new VUNGKETNOI_Bus().GetByID_VUNGKETNOI(id);
                if (ob == null) Response.Redirect("default.aspx");
                else
                {
                    txtName.Value = ob.TEN_VUNGKETNOI;
                }
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (new VUNGKETNOI_Bus().GetAll().Any(q => q.TEN_VUNGKETNOI.Trim().ToLower().Equals(txtName.Value.Trim().ToLower())))
            {
                lblResult.Text = "Vùng kết nối này đã tồn tại, bạn hãy thêm tên khác";
            }
            else
            {
                var ob = new DTO.VUNGKETNOI_Object()
                {
                    TEN_VUNGKETNOI = txtName.Value,
                    ID_VUNGKETNOI = id
                };
                if (isCreate) new VUNGKETNOI_Bus().Insert(ob);
                else new VUNGKETNOI_Bus().Update(ob);
                new Log_he_thong.LogHeThong().Add(isCreate ? Log_he_thong.LogHeThong.eAction.Add : Log_he_thong.LogHeThong.eAction.Edit);
                Response.Redirect("default.aspx");
            }
        }
    }
}