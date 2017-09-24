<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reset.aspx.cs" Inherits="Web_QLTSL.Page.tai_khoan.reset" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>Reset mật khẩu người dùng: <asp:Literal Text="" ID="txtName" runat="server" /></h2>
    <asp:Literal Text="" ID="result" runat="server" />
    <div class="form-group">
        <label>Nhập mật khẩu của bạn để xác nhận</label>
        <input id="txtPassword" type="text" required class="form-control" placeholder="Nhập mật khẩu của bạn..." runat="server">
    </div>
    <div class="box-footer">
        <asp:Button Text="Hoàn thành" ID="btnOk" CssClass="btn btn-success" OnClick="btnOk_Click" runat="server" />
        <a href="default.aspx" class="btn btn-info">Quay về quản lí</a>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
