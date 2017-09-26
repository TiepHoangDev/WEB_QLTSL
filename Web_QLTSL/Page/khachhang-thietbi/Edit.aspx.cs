using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.KhachHang_ThietBi
{
    public partial class Edit : BasePage
    {
        bool isCreate;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                isCreate = Request.QueryString[""] == null || !int.TryParse(Request.QueryString[""].ToString(), out id);
                ltrAction.Text = (isCreate ? "Thêm mới" : "Sửa") + " Khách hàng sử dụng thiết bị";
                if (!isCreate) LoadData();
            }
        }

        private void LoadData()
        {
            dropKhachHang.LoadDropDownList(new KHACH_HANG_Bus().GetAll(), q => q.ID_KHACHHANG, q => q.TEN_KHACHHANG);
            dropThietbi.LoadDropDownList(new THIET_BI_Bus().GetAll(), q => q.ID_THIETBI, q => q.TEN_THIETBI);
            var ob = new KHACHHANG_THIETBI_Bus().GetByID(id);
            if (ob == null) Response.Redirect("default.aspx");
            else
            {
                dropKhachHang.SelectedValue = ob.ID_KHACHHANG.ToString();
                dropThietbi.SelectedValue = ob.ID_THIETBI.ToString();
                txtTocDo.Value = ob.TOCDO;
                txtCong.Value = ob.CONG;
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            var ob = new DTO.KHACHHANG_THIETBI_Object()
            {
                ID = id,
                CONG = txtCong.Value,
                ID_KHACHHANG = int.Parse(dropKhachHang.SelectedValue),
                ID_THIETBI = int.Parse(dropThietbi.SelectedValue),
                TOCDO = txtTocDo.Value
            };
            if (isCreate) new KHACHHANG_THIETBI_Bus().Insert(ob);
            else new KHACHHANG_THIETBI_Bus().Update(ob);
            new Log_he_thong.LogHeThong().Add(isCreate ? Log_he_thong.LogHeThong.eAction.Add : Log_he_thong.LogHeThong.eAction.Edit);
            Response.Redirect("default.aspx");
        }
    }
}