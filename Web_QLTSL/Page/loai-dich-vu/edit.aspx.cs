using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.loai_dich_vu
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
                var ob = new LOAI_DICHVU_Bus().GetByID_LOAI_DICHVU(id);
                if (ob == null) Response.Redirect("default.aspx");
                else
                {
                    txtTenLoaiDichVu.Value = ob.TEN_LOAI_DICHVU;
                }
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (new LOAI_DICHVU_Bus().GetAll().Any(q => q.TEN_LOAI_DICHVU.Trim().ToLower().Equals(txtTenLoaiDichVu.Value.Trim().ToLower())))
            {
                lblResult.Text = "Loại dịch vụ này đã tồn tại, bạn hãy thêm tên khác";
            }
            else
            {
                var ob = new DTO.LOAI_DICHVU_Object()
                {
                    TEN_LOAI_DICHVU = txtTenLoaiDichVu.Value,
                    ID_LOAI_DICHVU = id
                };
                if (isCreate) new LOAI_DICHVU_Bus().Insert(ob);
                else new LOAI_DICHVU_Bus().Update(ob);
                new Log_he_thong.LogHeThong().Add(isCreate ? Log_he_thong.LogHeThong.eAction.Add : Log_he_thong.LogHeThong.eAction.Edit);
                Response.Redirect("default.aspx");
            }
        }
    }
}