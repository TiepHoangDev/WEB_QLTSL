<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Web_QLTSL.Page.Log_he_thong._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>LOG HỆ THỐNG</h2>
    <div>
        <asp:Label Text="Chọn thời gian xem log của hệ thống" runat="server" />
        <input type="date" runat="server" id="date" name="name" value="" class="form-control"/>
        <asp:Button Text="Xem" ID="btnXem" OnClick="btnXem_Click" runat="server" />
    </div>
    <asp:Literal Text="Không có nhật kí nào." runat="server" ID="ltrLog"/>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
