<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="Web_QLTSL.Page.phan_quyen.Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="box-body">
        <div class="alert alert-danger alert-dismissible">
            <h4><i class="icon fa fa-ban"></i> Cảnh báo!</h4>
            Bạn có muốn xóa ko?
            <div>
                <asp:Button ID="btnOk" CssClass="btn btn-success" runat="server" Text="Xác nhận" OnClick="btnOk_Click" />
                <a href="default.aspx" class="btn btn-primary">Quay lại quản lí</a>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
