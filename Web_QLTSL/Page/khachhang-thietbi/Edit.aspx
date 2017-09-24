<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="Web_QLTSL.Page.KhachHang_ThietBi.Edit" %>

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
            <asp:DropDownList ID="dropKhachHang" CssClass="form-control" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" CssClass="text-danger" ControlToValidate="dropKhachHang" InitialValue="-1" ErrorMessage="Vui lòng chọn một giá trị"> </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Thiết bị</label>
            <asp:DropDownList ID="dropThietbi" CssClass="form-control" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" CssClass="text-danger" ControlToValidate="dropThietbi" InitialValue="-1" ErrorMessage="Vui lòng chọn một giá trị"> </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Tốc độ</label>
            <input type="text" required min="0" class="form-control" id="txtTocDo" placeholder="Tốc độ" runat="server">
        </div>
        <div class="form-group">
            <label>Cổng</label>
            <input type="text" required min="0" class="form-control" id="txtCong" placeholder="Cổng" runat="server">
        </div>
    </div>
    <div class="box-footer">
        <asp:Button Text="Hoàn thành" ID="btnOk" CssClass="btn btn-success" OnClick="btnOk_Click" runat="server" />
        <a href="default.aspx" class="btn btn-info">Quay về quản lí</a>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>