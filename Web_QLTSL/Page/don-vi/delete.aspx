<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="Web_QLTSL.Page.don_vi.Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="box-body">
        <div class="alert alert-danger alert-dismissible">
            <h4><i class="icon a fa-ban"></i> Cảnh báo!</h4>
            Tất cả Người dùng thuộc đơn vị này sẽ bị xóa bỏ.
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
