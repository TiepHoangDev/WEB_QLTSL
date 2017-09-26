<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="Web_QLTSL.Page.don_vi.Edit" %>

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
            <label>Tên đơn vị mới</label>
            <input id="txtTenDonVi" type="text" required class="form-control" placeholder="Họ và tên" runat="server">
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
