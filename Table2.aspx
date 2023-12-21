<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Table2.aspx.cs" Inherits="Table2" MasterPageFile = "~/MasterPage.Master" %>

<asp:content runat="server" ContentPlaceHolderID="body" id="content">
    <form id="form1" runat="server">
        <div>
         <asp:TextBox ID="Filter" runat="server" OnTextChanged="Filter_TextChanged" AutoPostBack="True"></asp:TextBox>
        <asp:Button ID="btnAddNewRow" runat="server" Text="Добавить Новую Строку" OnClick="btnAddNewRow_Click" />
        <asp:Label ID="Error" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
        <%--текст ниже большей частью сгенерирован конструктором--%>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Код" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Код" HeaderText="Код" InsertVisible="False" ReadOnly="True" SortExpression="Код" />
                <asp:BoundField DataField="Фамилия" HeaderText="Фамилия" SortExpression="Фамилия" />
                <asp:BoundField DataField="Имя" HeaderText="Имя" SortExpression="Имя" />
                <asp:BoundField DataField="Отчество" HeaderText="Отчество" SortExpression="Отчество" />
                <asp:BoundField DataField="Адрес" HeaderText="Адрес" SortExpression="Адрес" />
                <asp:BoundField DataField="Телефон" HeaderText="Телефон" SortExpression="Телефон" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringCar %>" DeleteCommand="DELETE FROM [Клиенты] WHERE [Код] = ?" InsertCommand="INSERT INTO [Клиенты] ([Код], [Фамилия], [Имя], [Отчество], [Адрес], [Телефон]) VALUES (?, ?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionStringCar.ProviderName %>" SelectCommand="SELECT * FROM [Клиенты]" UpdateCommand="UPDATE [Клиенты] SET [Фамилия] = ?, [Имя] = ?, [Отчество] = ?, [Адрес] = ?, [Телефон] = ? WHERE [Код] = ?">
            <DeleteParameters>
                <asp:Parameter Name="Код" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Код" Type="Int32" />
                <asp:Parameter Name="Фамилия" Type="String" />
                <asp:Parameter Name="Имя" Type="String" />
                <asp:Parameter Name="Отчество" Type="String" />
                <asp:Parameter Name="Адрес" Type="String" />
                <asp:Parameter Name="Телефон" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Фамилия" Type="String" />
                <asp:Parameter Name="Имя" Type="String" />
                <asp:Parameter Name="Отчество" Type="String" />
                <asp:Parameter Name="Адрес" Type="String" />
                <asp:Parameter Name="Телефон" Type="String" />
                <asp:Parameter Name="Код" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
         <asp:Button ID="WordExport" runat="server" OnClick="WordExport_Click" Text="Word" />
         <asp:Button ID="ExcelExport" runat="server" OnClick="ExcelExport_Click" Text="Excel" />
            </div>
    </form></asp:content>

