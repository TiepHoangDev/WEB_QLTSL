<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Web_QLTSL.Page.tai_khoan.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="box-header">
        <h2>Đổi mật khẩu</h2>
    </div>
    <div class="box-body">
        <div class="form-group">
            <label>Mật khẩu hiện tại</label>
            <input id="txtPassword" type="password" required class="form-control" placeholder="Nhập mật khẩu" runat="server">
            <asp:Label CssClass="text-danger" ID="lblPass" Text="" runat="server" />
        </div>
        <div class="form-group">
            <label>Mật khẩu mới</label>
            <input id="txtNewPassword" type="password" required class="form-control" placeholder="Nhập mật khẩu mới" runat="server">
            <asp:Label CssClass="text-danger" ID="lblNewPass" Text="" runat="server" />
        </div>
        <div class="form-group">
            <label>Xác nhận mật khẩu mới</label>
            <input id="txtRePassword" type="password" required class="form-control" placeholder="Nhập lại mật khẩu mới" runat="server">
        </div>
    </div>
    <div class="box-footer">
        <asp:Label ID="lblResult" CssClass="text-danger" Text="" runat="server" />
        <asp:Button Text="Hoàn thành" ID="btnOk" CssClass="btn btn-success" OnClick="btnOk_Click" runat="server" />
        <a href="Profile.aspx" class="btn btn-info">Quay về trang cá nhân</a>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
