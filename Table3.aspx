<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Table3.aspx.cs" Inherits="Table3" MasterPageFile = "~/MasterPage.Master" %>



<asp:content runat="server" ContentPlaceHolderID="body" id="content">
    <form id="form1" runat="server">
       
        <br>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Выйти" />
        <div>
            <asp:TextBox ID="Filter" runat="server" AutoPostBack="True" OnTextChanged="Filter_TextChanged"></asp:TextBox>
         
        

       

        <asp:Button ID="btnAddNewRow" runat="server" Text="Добавить Новую Строку" OnClick="btnAddNewRow_Click" />
        <asp:Label ID="Error" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
            <%--текст ниже большей частью сгенерирован конструктором--%>

        <div>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Код" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="Код" HeaderText="Код" InsertVisible="False" ReadOnly="True" SortExpression="Код" />
                    <asp:TemplateField HeaderText="Маршрут" SortExpression="Маршрут">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource3" DataTextField="Название" DataValueField="Код" SelectedValue='<%# Bind("Маршрут") %>'>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource3" DataTextField="Название" DataValueField="Код" Enabled="False" SelectedValue='<%# Bind("Маршрут") %>'>
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Водитель" SortExpression="Водитель">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Фамилия" DataValueField="Код" SelectedValue='<%# Bind("Водитель") %>'>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Фамилия" DataValueField="Код" Enabled="False" SelectedValue='<%# Bind("Водитель") %>'>
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Дата отправки" HeaderText="Дата отправки" SortExpression="Дата отправки" />
                    <asp:BoundField DataField="Дата возвращения" HeaderText="Дата возвращения" SortExpression="Дата возвращения" />
                    <asp:BoundField DataField="Премия" HeaderText="Премия" SortExpression="Премия" />
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
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringPerevoz %>" DeleteCommand="DELETE FROM [Выезды] WHERE [Код] = ?" InsertCommand="INSERT INTO [Выезды] ([Код], [Маршрут], [Водитель], [Дата отправки], [Дата возвращения], [Премия]) VALUES (?, ?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionStringPerevoz.ProviderName %>" SelectCommand="SELECT * FROM [Выезды]" UpdateCommand="UPDATE [Выезды] SET [Маршрут] = ?, [Водитель] = ?, [Дата отправки] = ?, [Дата возвращения] = ?, [Премия] = ? WHERE [Код] = ?">
            <DeleteParameters>
                <asp:Parameter Name="Код" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Код" Type="Int32" />
                <asp:Parameter Name="Маршрут" Type="Int32" />
                <asp:Parameter Name="Водитель" Type="Int32" />
                <asp:Parameter Name="Дата отправки" Type="DateTime" />
                <asp:Parameter Name="Дата возвращения" Type="DateTime" />
                <asp:Parameter Name="Премия" Type="Decimal" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Маршрут" Type="Int32" />
                <asp:Parameter Name="Водитель" Type="Int32" />
                <asp:Parameter Name="Дата отправки" Type="DateTime" />
                <asp:Parameter Name="Дата возвращения" Type="DateTime" />
                <asp:Parameter Name="Премия" Type="Decimal" />
                <asp:Parameter Name="Код" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
              <asp:Button ID="WordExport" runat="server" OnClick="WordExport_Click" Text="Word" />
         <asp:Button ID="ExcelExport" runat="server" OnClick="ExcelExport_Click" Text="Excel" />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringPerevoz %>" ProviderName="<%$ ConnectionStrings:ConnectionStringPerevoz.ProviderName %>" SelectCommand="SELECT * FROM [Водители]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringPerevoz %>" ProviderName="<%$ ConnectionStrings:ConnectionStringPerevoz.ProviderName %>" SelectCommand="SELECT * FROM [Маршруты]"></asp:SqlDataSource>
       
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringPerevoz %>" ProviderName="<%$ ConnectionStrings:ConnectionStringPerevoz.ProviderName %>" SelectCommand="SELECT Выезды.Код, Маршруты.Название, Водители.Фамилия, Выезды.[Дата отправки], Выезды.[Дата возвращения], Выезды.Премия FROM ((Выезды INNER JOIN Маршруты ON Выезды.Маршрут = Маршруты.Код) INNER JOIN Водители ON Выезды.Водитель = Водители.Код)"></asp:SqlDataSource>
       
            </div>
    </form></asp:content>

