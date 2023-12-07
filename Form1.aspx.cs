using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Form1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //Событие по нажатии на кнопку
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Чтобы использовать в этом файле элементы с формы, нужно у них там прописать свойство runat="server"
        var Name =TextBox2.Text;
        var Surname = TextBox1.Text;
        var Lastname= TextBox3.Text;
        priglashenie.Text = "Здравствуйте, "+Surname+" "+Name+" "+Lastname+"! Добро пожаловать в приложение ASP.NET";
    }
    //Событие по нажатии на чекбокс
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        //Переключаем видимость объекта, где мы храним всё связанное с отчеством, чтобы галочка работала, нужно у неё установить свойство AutoPostBack="True"
        Lastname.Visible = !Lastname.Visible;
        //Очищаем поле отчества и строку с приветствием
        TextBox3.Text = "";
        priglashenie.Text = "";

    }
}