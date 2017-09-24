<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="Web_QLTSL.Page.trang_chu.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="box-header">
        <h2>
            <asp:Literal ID="ltrAction" Text="" runat="server" />
        </h2>
    </div>
    <div class="box-body">
        <asp:HiddenField runat="server" ID="txtPASSWORD" />
        <div class="form-group">
            <label>Họ và tên</label>
            <input id="txtHoTen" type="text" required class="form-control" placeholder="Họ và tên" runat="server">
        </div>
        <div class="form-group">
            <label>Tên đăng nhập</label>
            <input id="txtUsername" type="text" required class="form-control" placeholder="Tên đăng nhập" runat="server">
        </div>
        <div class="form-group">
            <label>Số điện thoại</label>
            <input id="txtSDT" type="number" required min="0" class="form-control" placeholder="Số điện thoại" runat="server">
        </div>
        <div class="form-group">
            <label>Đơn vị</label>
            <asp:DropDownList CssClass="form-control" ID="dropDonVi" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator ControlToValidate="dropDonVi" CssClass="text-danger" runat="server" InitialValue="-1" ErrorMessage="Vui lòng chọn một giá trị"> </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="box-footer">
        <asp:Button Text="Hoàn thành" ID="btnOk" CssClass="btn btn-success" OnClick="btnOk_Click" runat="server" />
        <a href="default.aspx" class="btn btn-info">Quay về quản lí</a>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
