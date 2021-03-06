﻿using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.nhom_khach_hang
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
                ltrAction.Text = (isCreate ? "Thêm mới" : "Sửa") + " nhóm khách hàng";
                LoadData();
            }
        }

        private void LoadData()
        {
            if (!isCreate)
            {
                var ob = new NHOM_KHACH_HANG_Bus().GetByID_NHOMKHACHHANG(id);
                if (ob == null) Response.Redirect("default.aspx");
                else
                {
                    txtTenNhomKhachhang.Value = ob.TEN_NHOMKHACHHANG;
                }
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (new NHOM_KHACH_HANG_Bus().GetAll().Any(q => q.TEN_NHOMKHACHHANG.Trim().ToLower().Equals(txtTenNhomKhachhang.Value.Trim().ToLower())))
            {
                lblResult.Text = "Nhóm khách hàng này đã tồn tại, bạn hãy thêm tên khác";
            }
            else
            {
                var ob = new DTO.NHOM_KHACH_HANG_Object()
                {
                    TEN_NHOMKHACHHANG = txtTenNhomKhachhang.Value,
                    ID_NHOMKHACHHANG = id
                };
                if (isCreate) new NHOM_KHACH_HANG_Bus().Insert(ob);
                else new NHOM_KHACH_HANG_Bus().Update(ob);
                new Log_he_thong.LogHeThong().Add(isCreate ? Log_he_thong.LogHeThong.eAction.Add : Log_he_thong.LogHeThong.eAction.Edit);
                Response.Redirect("default.aspx");
            }
        }
    }
}