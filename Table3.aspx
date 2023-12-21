<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Table3.aspx.cs" Inherits="Table3" MasterPageFile = "~/MasterPage.Master" %>



<asp:content runat="server" ContentPlaceHolderID="body" id="content">
    <form id="form1" runat="server">
       
        <br>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Выйти" />
        <div>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Сбросить фильтр" Width="105px" />
            <asp:DropDownList ID="Filter" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="Фамилия" DataValueField="Код" OnSelectedIndexChanged="Filter_TextChanged">
            </asp:DropDownList>
         
        

       

        <asp:Button ID="btnAddNewRow" runat="server" Text="Добавить Новую Строку" OnClick="btnAddNewRow_Click" />
        <asp:Label ID="Error" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
            <%--текст ниже большей частью сгенерирован конструктором--%>

        <div>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Код" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="Код" HeaderText="Код" InsertVisible="False" ReadOnly="True" SortExpression="Код" />
                    <asp:TemplateField HeaderText="Автомобиль" SortExpression="Автомобиль">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource3" DataTextField="Марка" DataValueField="Код" SelectedValue='<%# Bind("Автомобиль") %>'>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource3" DataTextField="Марка" DataValueField="Код" Enabled="False" SelectedValue='<%# Bind("Автомобиль") %>'>
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Клиент" SortExpression="Клиент">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Фамилия" DataValueField="Код" SelectedValue='<%# Bind("Клиент") %>'>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Фамилия" DataValueField="Код" Enabled="False" SelectedValue='<%# Bind("Клиент") %>'>
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Дата выдачи" HeaderText="Дата выдачи" SortExpression="Дата выдачи" />
                    <asp:BoundField DataField="Дата возврата" HeaderText="Дата возврата" SortExpression="Дата возврата" />
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
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringCar %>" DeleteCommand="DELETE FROM [Прокат] WHERE [Код] = ?" InsertCommand="INSERT INTO [Прокат] ([Код], [Автомобиль], [Клиент], [Дата выдачи], [Дата возврата]) VALUES (?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionStringCar.ProviderName %>" SelectCommand="SELECT * FROM [Прокат]" UpdateCommand="UPDATE [Прокат] SET [Автомобиль] = ?, [Клиент] = ?, [Дата выдачи] = ?, [Дата возврата] = ? WHERE [Код] = ?">
            <DeleteParameters>
                <asp:Parameter Name="Код" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Код" Type="Int32" />
                <asp:Parameter Name="Автомобиль" Type="Int32" />
                <asp:Parameter Name="Клиент" Type="Int32" />
                <asp:Parameter Name="Дата выдачи" Type="DateTime" />
                <asp:Parameter Name="Дата возврата" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Автомобиль" Type="Int32" />
                <asp:Parameter Name="Клиент" Type="Int32" />
                <asp:Parameter Name="Дата выдачи" Type="DateTime" />
                <asp:Parameter Name="Дата возврата" Type="DateTime" />
                <asp:Parameter Name="Код" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
              <asp:Button ID="WordExport" runat="server" OnClick="WordExport_Click" Text="Word" />
         <asp:Button ID="ExcelExport" runat="server" OnClick="ExcelExport_Click" Text="Excel" />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringCar %>" ProviderName="<%$ ConnectionStrings:ConnectionStringCar.ProviderName %>" SelectCommand="SELECT * FROM [Клиенты]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringCar %>" ProviderName="<%$ ConnectionStrings:ConnectionStringCar.ProviderName %>" SelectCommand="SELECT * FROM [Автомобили]"></asp:SqlDataSource>
       
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringCar %>" ProviderName="<%$ ConnectionStrings:ConnectionStringCar.ProviderName %>" SelectCommand="SELECT Прокат.Код, Автомобили.Марка, Клиенты.Фамилия, Прокат.[Дата выдачи], Прокат.[Дата возврата] FROM ((Прокат INNER JOIN Клиенты ON Прокат.Клиент = Клиенты.Код) INNER JOIN Автомобили ON Прокат.Автомобиль = Автомобили.Код)"></asp:SqlDataSource>
       
            </div>
    </form></asp:content>

