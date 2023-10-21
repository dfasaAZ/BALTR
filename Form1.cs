using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessProxyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDCafeDataSet.Рецепты". При необходимости она может быть перемещена или удалена.
            this.рецептыTableAdapter.Fill(this.bDCafeDataSet.Рецепты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDCafeDataSet.Ингредиенты". При необходимости она может быть перемещена или удалена.
            this.ингредиентыTableAdapter.Fill(this.bDCafeDataSet.Ингредиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDCafeDataSet.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter.Fill(this.bDCafeDataSet.Блюда);
            

           

            // Refresh TableAdapter to reset data
            this.блюдаTableAdapter.Fill(this.bDCafeDataSet.Блюда);
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            ingredientGridView.Rows.RemoveAt(ingredientGridView.SelectedCells[0].RowIndex);
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            dishGridView.Rows.RemoveAt(dishGridView.SelectedCells[0].RowIndex);
        }

        private void deleteButton3_Click(object sender, EventArgs e)
        {
            recipeGridView.Rows.RemoveAt(recipeGridView.SelectedCells[0].RowIndex);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            рецептыBindingSource.Filter="Dish = "+comboBox1.SelectedValue;
        }

        private void recipeGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Для заполнения таблицы необходимо очистить фильтры");
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            рецептыBindingSource.Filter = "Ingredient = " + comboBox2.SelectedValue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            блюдаBindingSource.Filter="DishName like '*"+textBox1.Text+"*'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ингредиентыBindingSource.Filter="ProductName like '*"+textBox2.Text+"*'";  
        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            IngredientsAdapter.Update(bDCafeDataSet);
        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            DishesAdapter.Update(bDCafeDataSet);
        }

        private void SaveButton3_Click(object sender, EventArgs e)
        {
            RecipesAdapter.Update(bDCafeDataSet);
        }

        

       
    }
}
