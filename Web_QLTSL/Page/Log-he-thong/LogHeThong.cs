using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Web_QLTSL.Page.Log_he_thong
{
    public class LogHeThong
    {
        public enum eAction
        {
            Add, Edit, Delete
        }

        public string LoadOfDate(DateTime? date = null)
        {
            if (File.Exists(GetName(date)))
            {
                return File.ReadAllText(GetName(date));
            }
            else return "Hệ thống ngày " + (date.HasValue ? date.Value : DateTime.Now).ToShortDateString() + " không có sự kiện nào.";
        }


        public string GetName(DateTime? date = null)
        {
            return HttpContext.Current.Server.MapPath("/Page/Log-he-thong") + string.Format("/_log.{0}.txt", (date.HasValue ? date.Value : DateTime.Now).ToString("ddMMyyyy"));
        }

        public void Add(eAction action)
        {
            var acc = new Core.Login().GetNguoiDung();
            if (acc == null) return;
            string link = HttpContext.Current.Request.Url.ToString();
            string message = string.Format("[{0}] >> Người dùng [{1}] thao tác [{2}] tại [{3}] <a href='{4}'>{4}</a>.", DateTime.Now, acc.HO_TEN, action.ToString(), link.Split('/')[4], link);
            var file = GetName();
            if (File.Exists(file))
                using (StreamWriter sw = File.AppendText(file))
                {
                    sw.WriteLine(message);
                }
            else
                using (StreamWriter sw = File.CreateText(file))
                {
                    sw.WriteLine(message);
                }
        }

        public string[] GetLog(DateTime? date = null)
        {
            var file = GetName(date);
            if (File.Exists(file)) return File.ReadAllLines(file);
            else return new string[] {};
        }
    }
}