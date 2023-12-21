<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Table2.aspx.cs" Inherits="Table2" MasterPageFile = "~/MasterPage.Master" %>

<asp:content runat="server" ContentPlaceHolderID="body" id="content">
    <form id="form1" runat="server">
        <div>
         <asp:TextBox ID="Filter" runat="server" OnTextChanged="Filter_TextChanged" AutoPostBack="True"></asp:TextBox>
        <asp:Button ID="btnAddNewRow" runat="server" Text="Добавить Новую Строку" OnClick="btnAddNewRow_Click" />
        <asp:Label ID="Error" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
        <%--текст ниже большей частью сгенерирован конструктором--%>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Код" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Код" HeaderText="Код" InsertVisible="False" ReadOnly="True" SortExpression="Код" />
                <asp:BoundField DataField="Название" HeaderText="Название" SortExpression="Название" />
                <asp:BoundField DataField="Дальность" HeaderText="Дальность" SortExpression="Дальность" />
                <asp:BoundField DataField="Дней в пути" HeaderText="Дней в пути" SortExpression="Дней в пути" />
                <asp:BoundField DataField="Оплата" HeaderText="Оплата" SortExpression="Оплата" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringPerevoz %>" DeleteCommand="DELETE FROM [Маршруты] WHERE [Код] = ?" InsertCommand="INSERT INTO [Маршруты] ([Код], [Название], [Дальность], [Дней в пути], [Оплата]) VALUES (?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionStringPerevoz.ProviderName %>" SelectCommand="SELECT * FROM [Маршруты]" UpdateCommand="UPDATE [Маршруты] SET [Название] = ?, [Дальность] = ?, [Дней в пути] = ?, [Оплата] = ? WHERE [Код] = ?">
            <DeleteParameters>
                <asp:Parameter Name="Код" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Код" Type="Int32" />
                <asp:Parameter Name="Название" Type="String" />
                <asp:Parameter Name="Дальность" Type="String" />
                <asp:Parameter Name="Дней в пути" Type="Int32" />
                <asp:Parameter Name="Оплата" Type="Decimal" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Название" Type="String" />
                <asp:Parameter Name="Дальность" Type="String" />
                <asp:Parameter Name="Дней в пути" Type="Int32" />
                <asp:Parameter Name="Оплата" Type="Decimal" />
                <asp:Parameter Name="Код" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
         <asp:Button ID="WordExport" runat="server" OnClick="WordExport_Click" Text="Word" />
         <asp:Button ID="ExcelExport" runat="server" OnClick="ExcelExport_Click" Text="Excel" />
            </div>
    </form></asp:content>

