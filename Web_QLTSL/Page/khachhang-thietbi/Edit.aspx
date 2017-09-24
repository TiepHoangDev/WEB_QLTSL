<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Web_QLTSL.Page.KhachHang_ThietBi.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="box-header">
        <h2>
            <asp:Literal ID="ltrAction" Text="" runat="server" />
        </h2>
    </div>
    <div class="box-body">
        <div class="form-group">
            <label>Khách hàng</label>
            <input type="text" class="form-control" id="txtKhachHang" placeholder="Khách hàng" runat="server">
        </div>
        <div class="form-group">
            <label>Thiết bị</label>
            <input type="text" class="form-control" id="txtThietBi" placeholder="Thiết bị" runat="server">
        </div>
        <div class="form-group">
            <label>Tốc độ</label>
            <input type="text" class="form-control" id="txtTocDo" placeholder="Tốc độ" runat="server">
        </div>
        <div class="form-group">
            <label>Cổng</label>
            <input type="text" class="form-control" id="txtCong" placeholder="Cổng" runat="server">
        </div>
    </div>
    <div class="box-footer">
        <asp:Button Text="Hoàn thành" ID="btnOk" CssClass="btn btn-success" OnClick="btnOk_Click" runat="server" />
        <a href="Index.aspx" class="btn btn-info">Quay về quản lí</a>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
