<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Table1.aspx.cs" Inherits="_Default" MasterPageFile = "~/MasterPage.Master"%>



<asp:content runat="server" ContentPlaceHolderID="body" ID="content">
    <form id="form1" runat="server">
        <div>
        <asp:TextBox ID="Filter" runat="server" OnTextChanged="Filter_TextChanged" AutoPostBack="True"></asp:TextBox>

        

        

        <asp:Button ID="btnAddNewRow" runat="server" Text="Добавить Новую Строку" OnClick="btnAddNewRow_Click" />
        <asp:Label ID="Error" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
        <%--текст ниже большей частью сгенерирован конструктором--%>
        
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="Код" DataSourceID="SqlDataSource1" GridLines="Horizontal" ShowHeaderWhenEmpty="True">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Код" HeaderText="Код" InsertVisible="False" ReadOnly="True" SortExpression="Код" />
                <asp:BoundField DataField="Фамилия" HeaderText="Фамилия" SortExpression="Фамилия" />
                <asp:BoundField DataField="Имя" HeaderText="Имя" SortExpression="Имя" />
                <asp:BoundField DataField="Отчество" HeaderText="Отчество" SortExpression="Отчество" />
                <asp:BoundField DataField="Стаж" HeaderText="Стаж" SortExpression="Стаж" />
            </Columns>
            <EditRowStyle BorderStyle="None" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringPerevoz %>" DeleteCommand="DELETE FROM [Водители] WHERE [Код] = ?" ProviderName="<%$ ConnectionStrings:ConnectionStringPerevoz.ProviderName %>" SelectCommand="SELECT * FROM [Водители]" UpdateCommand="UPDATE [Водители] SET [Фамилия] = ?, [Имя] = ?, [Отчество] = ?, [Стаж] = ? WHERE [Код] = ?" InsertCommand="INSERT INTO [Водители] ([Код], [Фамилия], [Имя], [Отчество], [Стаж]) VALUES (?, ?, ?, ?, ?)">
            <DeleteParameters>
                <asp:Parameter Name="Код" Type="Int32" />
            </DeleteParameters>
          
            <InsertParameters>
                <asp:Parameter Name="Код" Type="Int32" />
                <asp:Parameter Name="Фамилия" Type="String" />
                <asp:Parameter Name="Имя" Type="String" />
                <asp:Parameter Name="Отчество" Type="String" />
                <asp:Parameter Name="Стаж" Type="String" />
            </InsertParameters>
          
            <UpdateParameters>
                <asp:Parameter Name="Фамилия" Type="String" />
                <asp:Parameter Name="Имя" Type="String" />
                <asp:Parameter Name="Отчество" Type="String" />
                <asp:Parameter Name="Стаж" Type="String" />
                <asp:Parameter Name="Код" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <%--Здесь кончается конструктор--%>
        <asp:Button ID="WordExport" runat="server" OnClick="WordExport_Click" Text="Word" />
        <asp:Button ID="ExcelExport" runat="server" OnClick="ExcelExport_Click" Text="Excel" />
            </div>
    </form>
</asp:content>
