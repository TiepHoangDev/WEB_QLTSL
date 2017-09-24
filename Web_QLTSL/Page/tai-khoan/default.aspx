<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Web_QLTSL.Page.tai_khoan.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
    <script src="/Content/assets/js/jquery.dataTables.min.js"></script>
    <script src="/Content/assets/js/jquery.dataTables.bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>Danh sách Khách hàng sử dụng thiết bị</h2>
    <div>
        <a href="edit.aspx" runat="server" id="btnThem" visible='<%# allowThem_Sua_Xoa %>' class="btn btn-success">Thêm mới</a>
    </div>
    <table class="table dataTable" id="data-table">
        <thead>
            <tr>
                <td>Họ tên</td>
                <td>Tên đăng nhập</td>
                <td>Tên đơn vị</td>
                <td>SĐT</td>
                <td>Thao tác</td>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="repeater" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("HO_TEN") %></td>
                        <td><%#Eval("USERNAME") %></td>
                        <td><%#Eval("DON_VI_ObjectJoin.TEN_DONVI") %></td>
                        <td><%#Eval("SDT") %></td>
                        <td>
                            <a visible='<%#allowThem_Sua_Xoa%>' href='<%#Eval("ID_NGUOIDUNG","/page/phan-quyen/edit.aspx?={0}") %>' runat="server" class="btn btn-info">Phân quyền người dùng</a>
                            <a visible='<%#allowThem_Sua_Xoa%>' href='<%#Eval("ID_NGUOIDUNG","edit.aspx?={0}") %>' runat="server" class="btn btn-info">Sửa</a>
                            <a visible='<%#allowThem_Sua_Xoa %>' href='<%#Eval("ID_NGUOIDUNG","delete.aspx?={0}") %>' runat="server" class="btn btn-warning">Xóa</a>
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
