﻿using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.don_vi
{
    public partial class Default : BasePage
    {
        //biến kiểm tra quyền
        public bool allowThem_Sua_Xoa = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            //gán datasource cho repeater
            repeater.DataSource = new BUS.DON_VI_Bus().GetAll();

            //kiểm tra quyền THEM_SUA_XOA của người cùng
            allowThem_Sua_Xoa = CheckQuyen(Core.eQUYEN.THEM_SUA_XOA);

            //load data cho form
            DataBind();
        }
       
    }
}