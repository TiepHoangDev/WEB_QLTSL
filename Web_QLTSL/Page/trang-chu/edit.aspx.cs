using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.trang_chu
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
                ltrAction.Text = (isCreate ? "Thêm mới" : "Sửa") + " khách hàng";
                LoadData();
            }
        }

        private void LoadData()
        {
            dropKhachHang.LoadDropDownList(new KHACH_HANG_Bus().GetAll(), q => q.ID_KHACHHANG, q => q.TEN_KHACHHANG);
            dropNhomKhachHang.LoadDropDownList(new NHOM_KHACH_HANG_Bus().GetAll(), q => q.ID_NHOMKHACHHANG, q => q.TEN_NHOMKHACHHANG);
            dropTrangThai.LoadDropDownList(new TRANG_THAI_Bus().GetAll(), q => q.ID_TRANGTHAI, q => q.TEN_TRANGTHAI);
            dropVungKetNoi.LoadDropDownList(new VUNGKETNOI_Bus().GetAll(), q => q.ID_VUNGKETNOI, q => q.TEN_VUNGKETNOI);
            if (!isCreate)
            {
                var ob = new KHACH_HANG_Bus().GetByID_KHACHHANG(id);
                if (ob == null) Response.Redirect("default.aspx");
                else
                {
                    txtIDKhachHang.Value = ob.ID_KHACHHANG.ToString();
                    dropKhachHang.SelectedValue = ob.ID_KHACHHANG.ToString();
                    dropNhomKhachHang.SelectedValue = ob.ID_NHOMKHACHHANG.ToString();
                    dropTrangThai.SelectedValue = ob.ID_TRANGTHAI.ToString();
                    dropVungKetNoi.SelectedValue = ob.ID_VUNGKETNOI.ToString();
                    CVLAN.Value = ob.CVLAN.ToString();
                    IPGATEWAY.Value = ob.IPGATEWAY;
                    IPLAN.Value = ob.IPLAN;
                    IPWAN.Value = ob.IPWAN;
                    SVLAN.Value = ob.SVLAN.ToString();
                    txtTenKhachHang.Value = ob.TEN_KHACHHANG;
                    date.Value = ob.THOIGIAN_CUNGCAP.ToString();
                }
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            var ob = new DTO.KHACH_HANG_Object()
            {
                ID_KHACHHANG = int.Parse(txtIDKhachHang.Value),
                ID_LOAIDICHVU = int.Parse(dropNhomKhachHang.SelectedValue),
                ID_NHOMKHACHHANG = int.Parse(dropNhomKhachHang.SelectedValue),
                ID_TRANGTHAI = int.Parse(dropTrangThai.SelectedValue),
                ID_VUNGKETNOI = int.Parse(dropVungKetNoi.SelectedValue),
                CVLAN = int.Parse(CVLAN.Value),
                IPGATEWAY = IPGATEWAY.Value,
                IPLAN = IPLAN.Value,
                IPWAN = IPWAN.Value,
                SVLAN = int.Parse(SVLAN.Value),
                TEN_KHACHHANG = txtTenKhachHang.Value,
                THOIGIAN_CUNGCAP = DateTime.Parse(date.Value)
            };
            if (isCreate) new KHACH_HANG_Bus().Insert(ob);
            else new KHACH_HANG_Bus().Update(ob);
            Response.Redirect("default.aspx");
        }
    }
}