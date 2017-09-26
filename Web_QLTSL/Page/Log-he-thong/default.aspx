<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Web_QLTSL.Page.Log_he_thong._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
    <script src="/Content/assets/js/bootstrap-datepicker.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>LOG HỆ THỐNG</h2>
    <div>
        <asp:Label Text="Chọn thời gian xem log của hệ thống" runat="server" />
        <input type="text" runat="server" id="txtdate" class="form-control"/>
        <asp:Button Text="Xem" ID="btnXem" OnClick="btnXem_Click" runat="server" CssClass="btn btn-success"/>
    </div>
    <asp:Literal Text="Không có nhật kí nào." runat="server" ID="ltrLog"/>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
    <script>
        $("#body_txtdate").datepicker({
            format: 'dd-mm-yyyy'
        });
    </script>
</asp:Content>
