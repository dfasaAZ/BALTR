<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Forma.aspx.cs" Inherits="Forma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 155px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Фамилия"></asp:Label>
            <asp:TextBox ID="Surname" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Имя"></asp:Label>
            <%--Пробелы, чтобы поля ровно стояли--%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
  
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        </p>
        <%--В этот div мы запихнули текстбокс и надпись про отчество, чтобы включать\выключать их одновременно--%>
        <div id="group" runat="server">
            <asp:Label ID="Label3" runat="server" Text="Отчество"></asp:Label>
            <asp:TextBox ID="Lastnam" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Checked="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Ввести отчество" />
        </p>

        <p>
            <%--Элемент в который мы записываем получившуюся строку--%>
            <asp:Label ID="stroka" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="XX-Large" Font-Underline="False" ForeColor="Red"></asp:Label><br/>
        <asp:Button ID="SendButton" runat="server" Text="Отправить" OnClick="SendButton_Click" />
        </p>
    </form>
</body>
</html>
