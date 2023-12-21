using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    

    protected void Button1_Click(object sender, EventArgs e)
    {
        string pass=null;
        SqlDataSource sqlDS = this.SqlDataSource1;
        sqlDS.SelectCommand = "SELECT [Пароль] FROM SignIn where [Логин] = @login";
        SqlDataSource1.SelectParameters.Add("@login", TextBox1.Text);
        var dt = sqlDS.Select(new DataSourceSelectArguments());
        if (dt != null)
        {
            pass = dt.Cast<DataRowView>()
                   .Select(x => x[0]!=DBNull.Value?(string)x[0]:"")
                   .FirstOrDefault();
        }
        if (pass != null && pass == TextBox2.Text)
        {
            TextBox1.Text = "";
            TextBox2.Text = string.Empty;
            Response.Redirect("Table3.aspx");
            
        }else
        Response.Write("Неправильные данные");
        dt = null;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
}