using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.phan_quyen
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
                ltrAction.Text = (isCreate ? "Thêm mới" : "Sửa") + " quyền của người dùng";
                LoadData();
            }
        }

        private void LoadData()
        {
            var nd = new NGUOI_DUNG_Bus().GetByID_NGUOIDUNG(id);
            if (nd == null) Response.Redirect("/login.aspx?=out");
            else
            {
                txtHoTen.Value = nd.HO_TEN;
                txtIDNguoiDung.Value = nd.ID_NGUOIDUNG.ToString();
                hiddenIDXem.Value = "-1";
                hiddenIDThemSuaXoa.Value = "-1";
                var ob = new Quyen().GetByID_NGUOIDUNG(id);
                if (!isCreate && ob != null)
                {
                    cbThemSuaXoa.Checked = ob.Them_Sua_Xoa;
                    hiddenIDThemSuaXoa.Value = ob.ID_QUYEN_Them_Sua_Xoa.ToString();
                    cbXem.Checked = ob.Xem;
                    hiddenIDXem.Value = ob.ID_QUYEN_Xem.ToString();
                }
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            new Quyen().Update(new Quyen()
            {
                ID_QUYEN_Them_Sua_Xoa = int.Parse(hiddenIDThemSuaXoa.Value),
                ID_QUYEN_Xem = int.Parse(hiddenIDXem.Value),
                NGUOIDUNG = new DTO.NGUOI_DUNG_Object() { ID_NGUOIDUNG = int.Parse(txtIDNguoiDung.Value) },
                Xem = cbXem.Checked,
                Them_Sua_Xoa = cbThemSuaXoa.Checked
            });
            new Log_he_thong.LogHeThong().Add(Log_he_thong.LogHeThong.eAction.Edit);
            Response.Redirect("default.aspx");
        }
    }
}