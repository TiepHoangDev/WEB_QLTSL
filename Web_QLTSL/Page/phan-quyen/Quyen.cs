using System.Collections.Generic;
using System.Linq;
using System.Web;
using BUS;
using DTO;

namespace Web_QLTSL.Page.phan_quyen
{
    public class Quyen
    {
        public NGUOI_DUNG_Object NGUOIDUNG { get; set; }

        public bool Xem { get; set; }
        public int ID_QUYEN_Xem { get; set; }

        public bool Them_Sua_Xoa { get; set; }
        public int ID_QUYEN_Them_Sua_Xoa { get; set; }

        public List<Quyen> GetAll()
        {
            List<Quyen> lst = new List<Quyen>();
            var lstQuyen = new NGUOI_DUNG_QUYEN_Bus().GetAll();
            foreach (var item in new NGUOI_DUNG_Bus().GetAll())
            {
                var x = lstQuyen.FirstOrDefault(q => q.ID_NGUOIDUNG == item.ID_NGUOIDUNG && q.QUYEN_ObjectJoin.TEN_QUYEN == "Xem");
                var tsx = lstQuyen.FirstOrDefault(q => q.ID_NGUOIDUNG == item.ID_NGUOIDUNG && q.QUYEN_ObjectJoin.TEN_QUYEN == "Thêm Sửa Xóa");
                var quyen = new Quyen()
                {
                    NGUOIDUNG = new NGUOI_DUNG_Object(),
                    Xem = x != null,
                    ID_QUYEN_Xem = x == null ? 0 : x.ID,
                    ID_QUYEN_Them_Sua_Xoa = tsx == null ? 0 : tsx.ID,
                    Them_Sua_Xoa = tsx != null
                };
                quyen.NGUOIDUNG = item;
                lst.Add(quyen);
            }
            return lst;
        }

        public void Update(Quyen quyen)
        {
            if (quyen.Xem)
            {
                new NGUOI_DUNG_QUYEN_Bus().Insert(new NGUOI_DUNG_QUYEN_Object()
                {
                    ID_NGUOIDUNG = quyen.NGUOIDUNG.ID_NGUOIDUNG,
                    ID_QUYEN = 1
                });
            }
            else if (quyen.ID_QUYEN_Xem > 0)
            {
                new NGUOI_DUNG_QUYEN_Bus().Delete(quyen.ID_QUYEN_Xem);
            }

            if (quyen.Them_Sua_Xoa)
            {
                new NGUOI_DUNG_QUYEN_Bus().Insert(new NGUOI_DUNG_QUYEN_Object()
                {
                    ID_NGUOIDUNG = quyen.NGUOIDUNG.ID_NGUOIDUNG,
                    ID_QUYEN = 2
                });
            }
            else if (quyen.ID_QUYEN_Xem > 0)
            {
                new NGUOI_DUNG_QUYEN_Bus().Delete(quyen.ID_QUYEN_Them_Sua_Xoa);
            }
        }

        public Quyen GetByID_NGUOIDUNG(int id)
        {
            var lst = new NGUOI_DUNG_QUYEN_Bus().GetByID_NGUOIDUNG(id);
            if (lst.Count < 1) return null;
            var x = lst.FirstOrDefault(q => q.QUYEN_ObjectJoin.TEN_QUYEN == "Xem");
            var tsx = lst.FirstOrDefault(q => q.QUYEN_ObjectJoin.TEN_QUYEN == "Thêm Sửa Xóa");
            return new Quyen()
            {
                ID_QUYEN_Them_Sua_Xoa = tsx != null ? tsx.ID : -1,
                ID_QUYEN_Xem = x != null ? x.ID : -1,
                NGUOIDUNG = new NGUOI_DUNG_Bus().GetByID_NGUOIDUNG(id),
                Them_Sua_Xoa = tsx != null,
                Xem = x != null
            };
        }
    }
}