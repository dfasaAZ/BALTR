<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Страница логина</title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div style="text-align:center;margin:0 auto; width: 300px;">
            
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringPerevoz %>" ProviderName="<%$ ConnectionStrings:ConnectionStringPerevoz.ProviderName %>" SelectCommand="SELECT * FROM [SignIn]"></asp:SqlDataSource>
            <asp:Label ID="Label1" runat="server" Text="Логин"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <p>
            <asp:Label ID="Label2" runat="server" Text="Пароль"></asp:Label>
        
        <br/>
            <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
        </p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx">Назад</asp:HyperLink>
        <asp:Button ID="Button1" runat="server" Text="Войти" OnClick="Button1_Click" />
        </div>
       
    </form>
</body>
</html>
