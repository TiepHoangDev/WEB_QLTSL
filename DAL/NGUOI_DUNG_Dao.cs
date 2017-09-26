
using System;
using System.Collections.Generic;
using DTO;
using DAL.Entities;

namespace DAL
{
    public class NGUOI_DUNG_Dao
    {
        /// <summary>
        /// Lấy tất cả danh sách người dùng
        /// </summary>
        /// <returns></returns>
        public List<NGUOI_DUNG_Object> GetAll()
        {
            //thực hiện procedure lấy danh sách người dùng bằng entity
            var list = new dbQLTSLEntities().SP_NGUOI_DUNG_GetAll();

            //khai bào danh sách để chứa danh sách người dùng
            List<NGUOI_DUNG_Object> lst = new List<NGUOI_DUNG_Object>();

            //duyệt lần lượt các đối tượng trong danh sách người dùng lấy về
            foreach (var item in list)
            {
                //khai báo đối tượng người dùng
                var obj = new NGUOI_DUNG_Object();

                //lần lượt gán các giá trị cho thuộc tính
                obj.HO_TEN = item.HO_TEN;
                obj.ID_DONVI = item.ID_DONVI;
                obj.ID_NGUOIDUNG = item.ID_NGUOIDUNG;
                obj.SDT = item.SDT;
                obj.USERNAME = item.USERNAME;

                //đối tượng đơn vị 
                obj.DON_VI_ObjectJoin = new DON_VI_Object()
                {

                    ID_DONVI = (System.Int32)item.ID_DONVI,
                    TEN_DONVI = item.TEN_DONVI_DON_VIJoin
                };

                //thêm người dùng vào danh sách
                lst.Add(obj);
            }

            //trả về danh sách
            return lst;
        }

        /// <summary>
        /// Hàm lấy người dùng theo ID
        /// </summary>
        /// <param name="ID_NGUOIDUNG"></param>
        /// <returns></returns>
        public NGUOI_DUNG_Object GetByID_NGUOIDUNG(System.Int32 ID_NGUOIDUNG)
        {

            //thực hiện procedure có tham số là ID
            var list = new dbQLTSLEntities().SP_NGUOI_DUNG_GetByID_NGUOIDUNG(ID_NGUOIDUNG);

            //duyệt kết quả của entity trả về, phải dùng foreach.
            foreach (var item in list)
            {

                //khai báo đối tượng người dùng
                var obj = new NGUOI_DUNG_Object();

                obj.HO_TEN = item.HO_TEN;
                obj.ID_DONVI = item.ID_DONVI;
                obj.ID_NGUOIDUNG = item.ID_NGUOIDUNG;
                obj.SDT = item.SDT;
                obj.USERNAME = item.USERNAME;
                obj.DON_VI_ObjectJoin = new DON_VI_Object()
                {

                    ID_DONVI = (System.Int32)item.ID_DONVI,
                    TEN_DONVI = item.TEN_DONVI_DON_VIJoin
                };

                //trả về người dùng và kết thúc vòng foreach
                return obj;
            }

            //trả về null nếu ko tồn tại người dùng
            return null;
        }


        /// <summary>
        /// Hàm thêm mới người dùng
        /// </summary>
        /// <param name="ob"></param>
        /// <returns></returns>
        public bool Insert(NGUOI_DUNG_Object ob)
        {
            //khởi tạo entity
            var entity = new dbQLTSLEntities();

            //chạy hàm thêm bằng procedure
            var kq = entity.SP_NGUOI_DUNG_Insert(ob.HO_TEN, ob.ID_DONVI, ob.PASSWORD, ob.SDT, ob.USERNAME);

            //trả về thành công hay ko nếu kq>0 hoặc ngược lạ
            return kq > 0;
        }

        /// <summary>
        /// Xóa người dùng
        /// </summary>
        /// <param name="ID_NGUOIDUNG"></param>
        /// <returns></returns>
        public bool Delete(System.Int32 ID_NGUOIDUNG)
        {
            //viết tắt, khởi tạo entity, chạy procedure, lớn hơn 0 thì thành công, ngược lại thất bại
            return new dbQLTSLEntities().SP_NGUOI_DUNG_Delete(ID_NGUOIDUNG) > 0;
        }

        /// <summary>
        /// Chỉnh sửa người dùng
        /// </summary>
        /// <param name="ob"></param>
        /// <returns></returns>
        public bool Update(NGUOI_DUNG_Object ob)
        {
            //tương tự thêm
            return new dbQLTSLEntities().SP_NGUOI_DUNG_Update(ob.HO_TEN, ob.ID_DONVI, ob.ID_NGUOIDUNG, ob.PASSWORD, ob.SDT, ob.USERNAME) > 0;
        }

        /// <summary>
        /// Check login người dùng bằng username và password, nếu tồn tại thì trả về người dùng, ngược lại trả về null.
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public NGUOI_DUNG_Object CheckLogin(string Username, string Password)
        {
            foreach (var item in new dbQLTSLEntities().SP_CheckLogin(Username, Password))
            {
                return new NGUOI_DUNG_Object()
                {
                    USERNAME = item.USERNAME,
                    SDT = item.SDT,
                    ID_NGUOIDUNG = item.ID_NGUOIDUNG,
                    ID_DONVI = item.ID_DONVI,
                    HO_TEN = item.HO_TEN,
                    DON_VI_ObjectJoin = new DON_VI_Object()
                    {
                        ID_DONVI = (System.Int32)item.ID_DONVI,
                        TEN_DONVI = item.TEN_DONVI_DON_VIJoin
                    }
                };
            }
            return null;
        }

        public bool ResetPassword(int ID_admin, string repass, int id_user)
        {
            //gọi hàm từ procedure.
            return new dbQLTSLEntities().SP_NGUOI_DUNG_ResetPassword(ID_admin, repass, id_user) > 0;
        }
    }
}
