using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.trang_thai
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
                var ob = new TRANG_THAI_Bus().GetByID_TRANGTHAI(id);
                if (ob == null) Response.Redirect("default.aspx");
                else
                {
                    txtName.Value = ob.TEN_TRANGTHAI;
                }
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (new TRANG_THAI_Bus().GetAll().Any(q => q.TEN_TRANGTHAI.Trim().ToLower().Equals(txtName.Value.Trim().ToLower())))
            {
                lblResult.Text = "Tên trạng thái này đã tồn tại, bạn hãy thêm tên khác";
            }
            else
            {
                var ob = new DTO.TRANG_THAI_Object()
                {
                    TEN_TRANGTHAI = txtName.Value,
                    ID_TRANGTHAI = id
                };
                if (isCreate) new TRANG_THAI_Bus().Insert(ob);
                else new TRANG_THAI_Bus().Update(ob);
                new Log_he_thong.LogHeThong().Add(isCreate ? Log_he_thong.LogHeThong.eAction.Add : Log_he_thong.LogHeThong.eAction.Edit);
                Response.Redirect("default.aspx");
            }
        }
    }
}