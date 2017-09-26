using BUS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Web_QLTSL.Page.trang_chu
{
    public partial class Default : BasePage
    {
        //biến kiểm tra quyền
        public bool allowThem_Sua_Xoa = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            //gán datasource cho repeater
            repeater.DataSource = new BUS.KHACH_HANG_Bus().GetAll();

            //kiểm tra quyền THEM_SUA_XOA của người cùng
            allowThem_Sua_Xoa = CheckQuyen(Core.eQUYEN.THEM_SUA_XOA);

            //load data cho form
            DataBind();
        }

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            //khởi tạo GridView lưu kết quả
            GridView grv = new GridView();

            //gán source cho GridView, đây là LinQ
            grv.DataSource = (from k in new KHACH_HANG_Bus().GetAll()
                              orderby k.THOIGIAN_CUNGCAP descending
                              select new
                              {
                                  Thời_gian_cung_cấp = k.THOIGIAN_CUNGCAP,
                                  Tên_khách_hàng = k.TEN_KHACHHANG,
                                  Trạng_thái = k.TRANG_THAI_ObjectJoin.TEN_TRANGTHAI,
                                  Loại_dịch_vụ = k.LOAI_DICHVU_ObjectJoin.TEN_LOAI_DICHVU,
                                  Nhóm_khách_hàng = k.NHOM_KHACH_HANG_ObjectJoin.TEN_NHOMKHACHHANG,
                                  Vùng_kết_nối = k.VUNGKETNOI_ObjectJoin.TEN_VUNGKETNOI,
                                  k.CVLAN,
                                  k.IPGATEWAY,
                                  k.IPLAN,
                                  k.IPWAN,
                                  k.SVLAN
                              });

            //đổ data lên GridView
            grv.DataBind();

            //lần lượt hàm xuất Excel
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", string.Format("attachment;filename=all-khach-hang-ngay-{0}.xls", DateTime.Now.ToString("ddMMyyy_hhMMss")));
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            grv.RenderControl(hw);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
            new Log_he_thong.LogHeThong().Add(Log_he_thong.LogHeThong.eAction.Expert_Excel);
        }
    }
}