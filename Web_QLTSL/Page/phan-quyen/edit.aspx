<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="Web_QLTSL.Page.phan_quyen.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="box-header">
        <h2>
            <asp:Literal ID="ltrAction" Text="" runat="server" />
        </h2>
    </div>
    <div class="box-body">
        <asp:HiddenField runat="server" ID="txtIDNguoiDung" />
        <div class="form-group">
            <label>Họ và tên</label>
            <input type="text" required class="form-control" id="txtHoTen" disabled placeholder="Họ và tên" runat="server">
        </div>
        <div class="form-group">
            <input type="checkbox" runat="server" id="cbXem" />
            <asp:HiddenField ID="hiddenIDXem" runat="server" />
            <label for="body_cbXem">Xem</label>
        </div>
        <div class="form-group">
            <input type="checkbox" runat="server" id="cbThemSuaXoa" />
            <asp:HiddenField ID="hiddenIDThemSuaXoa" runat="server" />
            <label for="body_cbThemSuaXoa">Thêm sửa xóa</label>
        </div>
    </div>
    <div class="box-footer">
        <asp:Button Text="Hoàn thành" ID="btnOk" CssClass="btn btn-success" OnClick="btnOk_Click" runat="server" />
        <a href="default.aspx" class="btn btn-info">Quay về quản lí</a>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
