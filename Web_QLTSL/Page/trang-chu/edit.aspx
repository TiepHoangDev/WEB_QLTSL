<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="Web_QLTSL.Page.trang_chu.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <script src="/Content/assets/js/bootstrap-datepicker.min.js"></script>
    <div class="box-header">
        <h2>
            <asp:Literal ID="ltrAction" Text="" runat="server" />
        </h2>
    </div>
    <div class="box-body">
        <asp:HiddenField runat="server" ID="txtIDKhachHang" />
        <div class="form-group">
            <label>Họ tên khách hàng</label>
            <input type="text" required class="form-control" id="txtTenKhachHang" placeholder="Họ tên khách hàng" runat="server">
        </div>
        <div class="form-group">
            <label>Thời gian cung cấp</label>
            <input type="text" required class="form-control" id="txtdate" runat="server">
            <script>
                $("#body_txtdate").datepicker({
                    format: 'dd-mm-yyyy'
                });
            </script>
        </div>
        <script src="../../Content/assets/js/bootstrap-datepicker.min.js"></script>
        <div class="form-group">
            <label>IPGATEWAY</label>
            <input type="text" required class="form-control" id="IPGATEWAY" placeholder="IPGATEWAY" runat="server">
        </div>
        <div class="form-group">
            <label>IPLAN</label>
            <input type="text" required class="form-control" id="IPLAN" placeholder="IPLAN" runat="server">
        </div>
        <div class="form-group">
            <label>IPWAN</label>
            <input type="text" required class="form-control" id="IPWAN" placeholder="IPWAN" runat="server">
        </div>
        <div class="form-group">
            <label>SVLAN</label>
            <input type="number" min="0" required class="form-control" id="SVLAN" placeholder="SVLAN" runat="server">
        </div>
        <div class="form-group">
            <label>CVLAN</label>
            <input type="number" min="0" required class="form-control" id="CVLAN" placeholder="CVLAN" runat="server">
        </div>

        <div class="form-group">
            <label>Loại dịch vụ</label>
            <asp:DropDownList ID="dropKhachHang" CssClass="form-control" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" CssClass="text-danger" ControlToValidate="dropKhachHang" InitialValue="-1" ErrorMessage="Vui lòng chọn một giá trị"> </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Nhóm khách hàng</label>
            <asp:DropDownList CssClass="form-control" ID="dropNhomKhachHang" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" CssClass="text-danger" ControlToValidate="dropNhomKhachHang" InitialValue="-1" ErrorMessage="Vui lòng chọn một giá trị"> </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Vùng kết nối</label>
            <asp:DropDownList CssClass="form-control" ID="dropVungKetNoi" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" CssClass="text-danger" ControlToValidate="dropVungKetNoi" InitialValue="-1" ErrorMessage="Vui lòng chọn một giá trị"> </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Trạng thái</label>
            <asp:DropDownList CssClass="form-control" ID="dropTrangThai" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" CssClass="text-danger" ControlToValidate="dropTrangThai" InitialValue="-1" ErrorMessage="Vui lòng chọn một giá trị"> </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="box-footer">
        <asp:Button Text="Hoàn thành" ID="btnOk" CssClass="btn btn-success" OnClick="btnOk_Click" runat="server" />
        <a href="default.aspx" class="btn btn-info">Quay về quản lí</a>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
