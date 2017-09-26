<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Web_QLTSL.Page.tai_khoan.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="box-header">
        <h2>Sửa thông tin cá nhân</h2>
    </div>
    <div class="box-body">
        <div class="form-group">
            <label>Họ và tên</label>
            <input id="txtHoTen" type="text" required class="form-control" placeholder="Họ và tên" runat="server">
        </div>
        <div class="form-group">
            <label>Số điện thoại</label>
            <input id="txtSDT" type="number" required min="0" class="form-control" placeholder="Số điện thoại" runat="server">
        </div>
        <div class="form-group">
            <label>Mật khẩu hiện tại</label>
            <input id="txtPassword" type="password" required class="form-control" placeholder="Nhập mật khẩu" runat="server">
            <asp:Label ID="lblPass" CssClass="text-danger" Text="" runat="server" />
        </div>
    </div>
    <div class="box-footer">
        <p><asp:Label ID="lblReslut" Text="" runat="server" /></p>
        <asp:Button Text="Hoàn thành" ID="btnOk" CssClass="btn btn-success" OnClick="btnOk_Click" runat="server" />
        <a href="/login.aspx?=out" class="btn btn-info">Đăng xuất</a>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
