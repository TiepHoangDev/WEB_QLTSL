using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_QLTSL
{
    public class BasePage : System.Web.UI.Page
    {
        /// <summary>
        /// Hàm kiểm tra người dùng đã đăng nhập hay chưa và kiểm tra có quyền xem hay ko, nếu ko sẽ redirect về trang login
        /// </summary>
        /// <param name="e">Tên quyền</param>
        protected override void OnLoad(EventArgs e)
        {
            //Lấy tài khoản người dùng
            var acc = new Core.Login().GetNguoiDung();

            //kiểm tra null và check quyền
            if (acc == null || CheckQuyen(Core.eQUYEN.XEM) == false)
            {
                //nếu ko có quyền sẽ chuyển sang trang login
                Response.Redirect("/Login.aspx");
            }

            //nếu có quyền sẽ tiếp tục
            base.OnLoad(e);
        }

        /// <summary>
        /// check quyền người dùng muốn kiểm tra
        /// </summary>
        /// <param name="quyen"></param>
        /// <returns></returns>
        public bool CheckQuyen(Core.eQUYEN quyen)
        {
            //lấy tất cả quyền mà người dùng có
            var lstQuyen = new Core.Login().GetAllQuyen();

            //xét quyền đang muốn kiểm tra
            //hàm Any trả về true nếu có ít nhất một đối tượng thỏa mãn điều kiện, ngược lại trả về false (đây là LinQ)
            switch (quyen)
            {
                //Core.eQUYEN.THEM_SUA_XOA tương đương với "Thêm Sửa Xóa"
                case Core.eQUYEN.THEM_SUA_XOA:
                    //so sánh tên quyền đối tượng q với tên quyền
                    return lstQuyen.Any(q => q.QUYEN_ObjectJoin.TEN_QUYEN == "Thêm Sửa Xóa");

                //tương tự
                case Core.eQUYEN.XEM:
                    return lstQuyen.Any(q => q.QUYEN_ObjectJoin.TEN_QUYEN == "Xem");

                //ngoài hai quyền trên sẽ cho phép
                default:
                    return true;
            }
        }
    }
}