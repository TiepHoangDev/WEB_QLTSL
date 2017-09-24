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
                ltrAction.Text = (isCreate ? "Thêm mới" : "Sửa") + " tài khoản người dùng";
                LoadData();
            }
        }

        private void LoadData()
        {
            dropDonVi.LoadDropDownList(new DON_VI_Bus().GetAll(), q => q.ID_DONVI, q => q.TEN_DONVI);
            if (!isCreate)
            {
                var ob = new NGUOI_DUNG_Bus().GetByID_NGUOIDUNG(id);
                if (ob == null) Response.Redirect("default.aspx");
                else
                {
                    dropDonVi.SelectedValue = ob.ID_DONVI.ToString();
                    txtUsername.Value = ob.USERNAME;
                    txtPASSWORD.Value = ob.PASSWORD;
                    txtHoTen.Value = ob.HO_TEN;
                    txtSDT.Value = ob.SDT.ToString();
                }
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            var ob = new DTO.NGUOI_DUNG_Object()
            {
                ID_NGUOIDUNG = id,
                HO_TEN = txtHoTen.Value,
                ID_DONVI = int.Parse(dropDonVi.SelectedValue),
                PASSWORD = "12345678",
                USERNAME = txtUsername.Value,
                SDT = int.Parse(txtSDT.Value)
            };
            if (isCreate) new NGUOI_DUNG_Bus().Insert(ob);
            else new NGUOI_DUNG_Bus().Update(ob);
            Response.Redirect("default.aspx");
        }
    }
}