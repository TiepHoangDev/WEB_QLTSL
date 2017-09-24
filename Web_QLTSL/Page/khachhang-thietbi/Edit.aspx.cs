using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.KhachHang_ThietBi
{
    public partial class Edit : System.Web.UI.Page
    {
        bool isCreate;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                isCreate = Request.QueryString[""] == null || !int.TryParse(Request.QueryString[""].ToString(), out id);
                ltrAction.Text = isCreate ? "Thêm mới" : "Sửa";
                if (!isCreate) LoadData();
            }
        }

        private void LoadData()
        {
            var ob = new KHACHHANG_THIETBI_Bus().GetByID(id);
            if (ob == null) Response.Redirect("Index.aspx");
            else
            {
                txtKhachHang.Value = ob.KHACH_HANG_ObjectJoin.TEN_KHACHHANG;
                txtThietBi.Value = ob.THIET_BI_ObjectJoin.TEN_THIETBI;
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
                ID_KHACHHANG = int.Parse(txtKhachHang.Value),
                ID_THIETBI = int.Parse(txtThietBi.Value),
                TOCDO = txtTocDo.Value
            };
            if (isCreate) new KHACHHANG_THIETBI_Bus().Insert(ob);
            else new KHACHHANG_THIETBI_Bus().Update(ob);
            Response.Redirect("Index.aspx");
        }
    }
}