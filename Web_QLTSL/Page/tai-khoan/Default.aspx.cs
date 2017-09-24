using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.tai_khoan
{
    public partial class Default : BasePage
    {
        //biến kiểm tra quyền
        public bool allowThem_Sua_Xoa = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            var acc = new Core.Login().GetNguoiDung();
            //gán datasource cho repeater
            repeater.DataSource = new BUS.NGUOI_DUNG_Bus().GetAll().Where(q => q.ID_NGUOIDUNG != acc.ID_NGUOIDUNG);

            //kiểm tra quyền THEM_SUA_XOA của người cùng
            allowThem_Sua_Xoa = CheckQuyen(Core.eQUYEN.THEM_SUA_XOA);

            //load data cho form
            DataBind();
        }

        protected void btnRset_Click(object sender, EventArgs e)
        {

        }
    }
}