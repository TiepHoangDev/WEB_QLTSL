<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_QLTSL.Page.trang_chu.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="style" runat="server">
    <script src="/Content/assets/js/jquery.dataTables.min.js"></script>
    <script src="/Content/assets/js/jquery.dataTables.bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>Danh sách Khách hàng</h2>
    <div>
        <a href="edit.aspx" runat="server" id="btnThem" visible='<%# allowThem_Sua_Xoa %>' class="btn btn-success">Thêm mới</a>
        <asp:Button Text="Xuất Excel" runat="server" CssClass="btn btn-primary" ID="btnExcel" OnClick="btnExcel_Click" />

    </div>
    <table class="table dataTable" id="data-table">
        <thead>
            <tr>
                <td>Khách hàng</td>
                <td>Thời gian cung cấp</td>
                <td>IPGATEWAY</td>
                <td>IPLAN</td>
                <td>IPWAN</td>
                <td>SVLAN</td>
                <td>CVLAN</td>
                <td>Loại dịch vụ</td>
                <td>Nhóm khách hàng</td>
                <td>Vùng kết nối</td>
                <td>Trạng thái</td>
                <td>Thao tác</td>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="repeater" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><a href="<%#Eval("ID_KHACHHANG","/page/khachhang-thietbi/edit.aspx?={0}") %>"><%#Eval("TEN_KHACHHANG") %></a></td>
                        <td><%#((DateTime)Eval("THOIGIAN_CUNGCAP")).ToString("dd-MM-yyyy") %></td>
                        <td><%#Eval("IPGATEWAY") %></td>
                        <td><%#Eval("IPLAN") %></td>
                        <td><%#Eval("IPWAN") %></td>
                        <td><%#Eval("SVLAN") %></td>
                        <td><%#Eval("CVLAN") %></td>
                        <td><a href='<%#Eval("ID_LOAIDICHVU","/page/loai-dich-vu/edit.aspx?={0}") %>'><%#Eval("LOAI_DICHVU_ObjectJoin.TEN_LOAI_DICHVU") %></a></td>
                        <td><a href="<%#Eval("ID_NHOMKHACHHANG","/page/nhom-khach-hang/edit.aspx?={0}") %>"><%#Eval("NHOM_KHACH_HANG_ObjectJoin.TEN_NHOMKHACHHANG") %></a></td>
                        <td><a href='<%#Eval("ID_VUNGKETNOI","/page/vung-ket-noi/edit.aspx?={0}") %>'><%#Eval("VUNGKETNOI_ObjectJoin.TEN_VUNGKETNOI") %></a></td>
                        <td><a href='<%#Eval("ID_TRANGTHAI","/page/trang-thai/edit.aspx?={0}") %>'><%#Eval("TRANG_THAI_ObjectJoin.TEN_TRANGTHAI") %></a></td>
                        <td>
                            <a visible='<%#allowThem_Sua_Xoa%>' href='<%#Eval("ID_KHACHHANG","edit.aspx?={0}") %>' runat="server" class="btn btn-info">Sửa</a>
                            <a visible='<%#allowThem_Sua_Xoa %>' href='<%#Eval("ID_KHACHHANG","delete.aspx?={0}") %>' runat="server" class="btn btn-warning">Xóa</a>
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
