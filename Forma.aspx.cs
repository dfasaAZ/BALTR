using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forma : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    //Событие по нажатии на чекбокс
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        //Переключаем видимость объекта, где мы храним всё связанное с отчеством, чтобы галочка работала, нужно у неё установить свойство AutoPostBack="True"
        group.Visible = !group.Visible;
        //Очищаем поле отчества и строку с приветствием
        Lastnam.Text = "";
        stroka.Text = "";

    }

    //Событие по нажатии на кнопку
    protected void SendButton_Click(object sender, EventArgs e)
    {
        //Чтобы использовать в этом файле элементы с формы, нужно у них там прописать свойство runat="server"
        stroka.Text = "Здравствуйте, " + Surname.Text + " " + Name.Text + " " + Lastnam.Text + "! Добро пожаловать в приложение ASP.NET";
    }
}