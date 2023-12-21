using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

public partial class Table2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Error.Text = "";
    }
    //Названия таблицы и колонки, по которым идёт фильтрация
    const string Table = "[Клиенты]";
    const string Column = "[Фамилия]";
    //стиль таблицы, название брать из стилей имеющихся в ворде
    string tableStyle = "Таблица простая 1";
    protected void Filter_TextChanged(object sender, EventArgs e)
    {

        string filter = Filter.Text;
        if (filter != "")
        {//Если не пустой, фильтруем
            SqlDataSource1.SelectCommand = "SELECT * FROM " + Table + " WHERE " + Column + " LIKE '%' + @Filter + '%'";
            SqlDataSource1.SelectParameters.Clear();
            //Заменяем параметр фильтр на значение текстбокса
            SqlDataSource1.SelectParameters.Add("@Filter", filter);
        }
        else
        {//Если пустой, выбирам все строки
            SqlDataSource1.SelectCommand = "SELECT * FROM " + Table;
        }


        GridView1.DataBind();
    }
    protected void btnAddNewRow_Click(object sender, EventArgs e)
    {

        //Этот блок для получения максимального значения айди
        SqlDataSource sqlDS = this.SqlDataSource1;
        sqlDS.SelectCommand = "SELECT max(Код)+1 as max_val FROM "+Table;
        var dt = sqlDS.Select(new DataSourceSelectArguments()) ;
        int max= dt.Cast<DataRowView>()
               .Select(x => (int)x[0])
               .FirstOrDefault();
       

        // Reset SelectCommand
        sqlDS.SelectCommand = "SELECT * FROM " + Table;



        SqlDataSource1.InsertCommand = "INSERT INTO " + Table + " ([Код]) VALUES ("+max+")";
        try
        {
            SqlDataSource1.Insert();
            GridView1.DataBind();
        }
        catch (Exception)
        {
            Error.Text = "Коды строк неуникальны";
            throw ;
        }

    }
    protected void WordExport_Click(object sender, EventArgs e)
    {
       

        object oMissing = System.Reflection.Missing.Value;
        object oEndOfDoc = "\\endofdoc";


        SqlDataSource sqlDS = this.SqlDataSource1;
        string BackupCommand = sqlDS.SelectCommand;
        sqlDS.SelectCommand = "SELECT * FROM " + Table;//прописать запрос, который мы хотим увидеть
        DataView view = (DataView)sqlDS.Select(new DataSourceSelectArguments());
        System.Data.DataTable dt = view.ToTable();
        sqlDS.SelectCommand = BackupCommand;


        var apl = new Word.Application();
        var doc = apl.Documents.Add(ref oMissing, ref oMissing,
ref oMissing, ref oMissing);


        apl.Visible = true;
        object start = 0;
        object end = 0;
        doc.Range().InsertParagraphBefore();
        Word.Range tableLocation = doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
        // Word.Range tableLocation = doc.Range(start,end);
        Word.Table table = doc.Tables.Add(tableLocation, dt.Rows.Count + 1, dt.Columns.Count, ref oMissing, ref oMissing);
        tableLocation.InsertParagraphBefore();


        //Применение стиля
        table.ApplyStyleDirectFormatting(tableStyle);

        for (var c = 0; c < dt.Columns.Count; c++)
            table.Cell(1, c + 1).Range.Text = dt.Columns[c].ColumnName;

        for (var r = 0; r < dt.Rows.Count; r++)
        {
            for (var c = 0; c < dt.Columns.Count; c++)
                table.Cell(r + 2, c + 1).Range.Text = dt.Rows[r][c].ToString();
        }
        var p = doc.Paragraphs[1];
        p.Range.InsertBefore("Отчет по " + Table);
        p.Range.Font.Bold = 1;
        p.Range.Font.Underline = WdUnderline.wdUnderlineDashHeavy;


    }

    protected void ExcelExport_Click(object sender, EventArgs e)
    {
        SqlDataSource sqlDS = this.SqlDataSource1;
        string BackupCommand = sqlDS.SelectCommand;
        sqlDS.SelectCommand = "SELECT * FROM " + Table;//прописать запрос, который мы хотим увидеть
        DataView view = (DataView)sqlDS.Select(new DataSourceSelectArguments());
        System.Data.DataTable dt = view.ToTable();
        sqlDS.SelectCommand = BackupCommand;


        var apl = new Excel.Application();
        var wb = apl.Workbooks.Add();
        apl.Visible = true;

        //Позиция левого угла таблицы(от 1 до как угодно)
        int tableRow = 2;
        int tableCol = 2;
        // Add the header row
        for (int i = 0; i < dt.Columns.Count; i++)
        {
            apl.Cells[1 + tableRow, i + tableCol] = dt.Columns[i].ColumnName;
        }

        // Add the data rows
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                apl.Cells[i + 2 + tableRow, j + tableCol] = dt.Rows[i][j].ToString();
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
}