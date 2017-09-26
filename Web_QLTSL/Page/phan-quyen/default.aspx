<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Web_QLTSL.Page.phan_quyen.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
    <script src="/Content/assets/js/jquery.dataTables.min.js"></script>
    <script src="/Content/assets/js/jquery.dataTables.bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <style>
        .True {
            color: green;
            font-weight: bold;
        }

        .False {
            color: #808080;
            font-weight: bold;
        }
    </style>
    <h2>Phân quyền cho người dùng</h2>
    <div>
        <a href="edit.aspx" runat="server" id="btnThem" visible='<%# allowThem_Sua_Xoa %>' class="btn btn-success">Thêm mới</a>
    </div>
    <table class="table dataTable" id="data-table">
        <thead>
            <tr>
                <td>Họ tên</td>
                <td>Quyền Xem</td>
                <td>Quyền Thêm sửa xóa</td>
                <td>Thao tác</td>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="repeater" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("NGUOIDUNG.HO_TEN") %></td>
                        <td class='<%#Eval("Xem") %>'><%#(bool)Eval("Xem")?"Cho phép":"Không cho phép" %></td>
                        <td class='<%#Eval("Them_Sua_Xoa") %>'><%#(bool)Eval("Them_Sua_Xoa")?"Cho phép":"Không cho phép" %></td>
                        <td>
                            <a visible='<%#allowThem_Sua_Xoa %>' href='<%#Eval("NGUOIDUNG.ID_NGUOIDUNG","edit.aspx?={0}") %>' runat="server" class="btn btn-info">Sửa</a>
                            <a visible='<%#allowThem_Sua_Xoa %>' href='<%#Eval("NGUOIDUNG.ID_NGUOIDUNG","delete.aspx?={0}") %>' runat="server" class="btn btn-warning">Xóa</a>
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
