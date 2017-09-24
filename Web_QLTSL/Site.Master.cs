using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;

namespace Web_QLTSL
{
    public partial class SiteMaster : MasterPage
    {
        public NGUOI_DUNG_Object User = new Core.Login().GetNguoiDung();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}