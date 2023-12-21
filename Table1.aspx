<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Table1.aspx.cs" Inherits="_Default" MasterPageFile = "~/MasterPage.Master"%>



<asp:content runat="server" ContentPlaceHolderID="body" ID="content">
    <form id="form1" runat="server">
        <div>
        <asp:TextBox ID="Filter" runat="server" OnTextChanged="Filter_TextChanged" AutoPostBack="True"></asp:TextBox>

        

        

        <asp:Button ID="btnAddNewRow" runat="server" Text="Добавить Новую Строку" OnClick="btnAddNewRow_Click" />
        <asp:Label ID="Error" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
        <%--текст ниже большей частью сгенерирован конструктором--%>
        
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Код" DataSourceID="SqlDataSource1" GridLines="Horizontal" ShowHeaderWhenEmpty="True">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Код" HeaderText="Код" InsertVisible="False" ReadOnly="True" SortExpression="Код" />
                <asp:BoundField DataField="Марка" HeaderText="Марка" SortExpression="Марка" />
                <asp:BoundField DataField="Стоимость" HeaderText="Стоимость" SortExpression="Стоимость" />
                <asp:BoundField DataField="Стоимость проката" HeaderText="Стоимость проката" SortExpression="Стоимость проката" />
                <asp:BoundField DataField="Тип" HeaderText="Тип" SortExpression="Тип" />
            </Columns>
            <EditRowStyle BorderStyle="None" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringCar %>" DeleteCommand="DELETE FROM [Автомобили] WHERE [Код] = ?" ProviderName="<%$ ConnectionStrings:ConnectionStringCar.ProviderName %>" SelectCommand="SELECT * FROM [Автомобили]" UpdateCommand="UPDATE [Автомобили] SET [Марка] = ?, [Стоимость] = ?, [Стоимость проката] = ?, [Тип] = ? WHERE [Код] = ?" InsertCommand="INSERT INTO [Автомобили] ([Код], [Марка], [Стоимость], [Стоимость проката], [Тип]) VALUES (?, ?, ?, ?, ?)">
            <DeleteParameters>
                <asp:Parameter Name="Код" Type="Int32" />
            </DeleteParameters>
          
            <InsertParameters>
                <asp:Parameter Name="Код" Type="Int32" />
                <asp:Parameter Name="Марка" Type="String" />
                <asp:Parameter Name="Стоимость" Type="Decimal" />
                <asp:Parameter Name="Стоимость проката" Type="Decimal" />
                <asp:Parameter Name="Тип" Type="String" />
            </InsertParameters>
          
            <UpdateParameters>
                <asp:Parameter Name="Марка" Type="String" />
                <asp:Parameter Name="Стоимость" Type="Decimal" />
                <asp:Parameter Name="Стоимость проката" Type="Decimal" />
                <asp:Parameter Name="Тип" Type="String" />
                <asp:Parameter Name="Код" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <%--Здесь кончается конструктор--%>
        <asp:Button ID="WordExport" runat="server" OnClick="WordExport_Click" Text="Word" />
        <asp:Button ID="ExcelExport" runat="server" OnClick="ExcelExport_Click" Text="Excel" />
            </div>
    </form>
</asp:content>
