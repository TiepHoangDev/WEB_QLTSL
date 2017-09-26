<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Web_QLTSL.Page.KhachHang_ThietBi.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
    <script src="/Content/assets/js/jquery.dataTables.min.js"></script>
    <script src="/Content/assets/js/jquery.dataTables.bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>Danh sách Khách hàng sử dụng thiết bị</h2>
    <div>
        <a href="edit.aspx" runat="server" id="btnThem" visible='<%#allowThem_Sua_Xoa %>' class="btn btn-success">Thêm mới</a>
        <asp:Button Text="Xuất Excel" ID="btnExcel" OnClick="btnExcel_Click" runat="server" />
    </div>
    <table class="table dataTable" id="data-table">
        <thead>
            <tr>
                <td>Tên khách hàng</td>
                <td>Tên thiết bị</td>
                <td>Tốc độ</td>
                <td>Cổng</td>
                <td>Thao tác</td>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="repeater" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><a href='<%#Eval("ID_KHACHHANG","/khach-hang/edit.aspx?={0}") %>'><%#Eval("KHACH_HANG_ObjectJoin.TEN_KHACHHANG") %></a></td>
                        <td><a href='<%#Eval("ID_THIETBI","/thiet-bi/edit.aspx?={0}") %>'><%#Eval("THIET_BI_ObjectJoin.TEN_THIETBI") %></a></td>
                        <td><%#Eval("TOCDO") %></td>
                        <td><%#Eval("CONG") %></td>
                        <td>
                            <a visible='<%#allowThem_Sua_Xoa%>' href='<%#Eval("ID","edit.aspx?={0}") %>' runat="server" class="btn btn-info">Sửa</a>
                            <a visible='<%#allowThem_Sua_Xoa %>' href='<%#Eval("ID","delete.aspx?={0}") %>' runat="server" class="btn btn-warning">Xóa</a>
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
