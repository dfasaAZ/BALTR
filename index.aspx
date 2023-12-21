<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" MasterPageFile = "~/MasterPage.Master"%>

<asp:content runat="server" ContentPlaceHolderID="body" ID="content">
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Table1.aspx">Первая Таблица</asp:HyperLink>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Table2.aspx">Вторая Таблица</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Login.aspx">Третья Таблица</asp:HyperLink>
        </p>
        </div>
        
    </form>
</asp:content>
