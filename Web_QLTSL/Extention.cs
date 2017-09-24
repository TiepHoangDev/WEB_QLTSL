using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI.WebControls;

namespace Web_QLTSL
{
    public static class Extention
    {
        //hàm load gia trị lên dropdownlist.
        public static void LoadDropDownList<T, TField, YField>(this DropDownList drop, IEnumerable<T> data, Expression<Func<T, TField>> DataValueField, Expression<Func<T, YField>> DataTextField, string SelectedValue = null)
        {
            drop.DataSource = data;
            drop.DataValueField = ((MemberExpression)DataValueField.Body).Member.Name;
            drop.DataTextField = ((MemberExpression)DataTextField.Body).Member.Name;
            if (!string.IsNullOrWhiteSpace(SelectedValue)) drop.SelectedValue = SelectedValue;
            drop.DataBind();
            drop.Items.Insert(0, new ListItem("Chọn một giá trị", "-1"));
        }
    }
}