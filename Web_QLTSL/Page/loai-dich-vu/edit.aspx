<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="Web_QLTSL.Page.loai_dich_vu.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="box-header">
        <h2>
            <asp:Literal ID="ltrAction" Text="" runat="server" />
        </h2>
    </div>
    <div class="box-body">
        <asp:HiddenField runat="server" ID="txtID"/>
        <div class="form-group">
            <label>Tên Loại dịch vụ</label>
            <input id="txtTenLoaiDichVu" type="text" required class="form-control" placeholder="Tên Loại dịch vụ" runat="server">
            <asp:Label Text="" ID="lblResult" CssClass="text-danger" runat="server" />
        </div>
    </div>
    <div class="box-footer">
        <asp:Button Text="Hoàn thành" ID="btnOk" CssClass="btn btn-success" OnClick="btnOk_Click" runat="server" />
        <a href="default.aspx" class="btn btn-info">Quay về quản lí</a>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
