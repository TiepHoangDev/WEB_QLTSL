<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Web_QLTSL.Page.trang_thai.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
    <script src="/Content/assets/js/jquery.dataTables.min.js"></script>
    <script src="/Content/assets/js/jquery.dataTables.bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>Danh sách Trạng thái</h2>
    <div>
        <a href="edit.aspx" runat="server" id="btnThem" visible='<%# allowThem_Sua_Xoa %>' class="btn btn-success">Thêm mới</a>
    </div>
    <table class="table dataTable" id="data-table">
        <thead>
            <tr>
                <td>Tên Trạng thái</td>
                <td>Thao tác</td>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="repeater" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("TEN_TRANGTHAI") %></td>
                        <td>
                            <a visible='<%#allowThem_Sua_Xoa%>' href='<%#Eval("ID_TRANGTHAI","edit.aspx?={0}") %>' runat="server" class="btn btn-info">Sửa</a>
                            <a visible='<%#allowThem_Sua_Xoa %>' href='<%#Eval("ID_TRANGTHAI","delete.aspx?={0}") %>' runat="server" class="btn btn-warning">Xóa</a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
    <script>
        //hàm dataTable cho table data-table.
        $('#data-table').dataTable();
    </script>
</asp:Content>
