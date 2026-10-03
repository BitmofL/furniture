using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mebel_predpr.Mebel_predprDataSetTableAdapters;

namespace Mebel_predpr
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebel_predprDataSet.Zakazi". При необходимости она может быть перемещена или удалена.
            this.zakaziTableAdapter.Fill(this.mebel_predprDataSet.Zakazi);

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем доступ к DataSet через BindingSource
                var bindingSource = (BindingSource)dataGridView1.DataSource;
                var dataSet = (Mebel_predprDataSet)bindingSource.DataSource;

                // Завершаем редактирование
                dataGridView1.EndEdit();
                bindingSource.EndEdit();

                // Проверяем изменения
                if (dataSet.HasChanges())
                {
                    // Получаем TableAdapter
                    var tableAdapter = new Mebel_predprDataSetTableAdapters.ZakaziTableAdapter();

                    // Сохраняем изменения
                    tableAdapter.Update(dataSet.Zakazi);

                    // Обновляем данные
                    dataSet.Zakazi.AcceptChanges();

                    MessageBox.Show("Данные сохранены!");
                }
                else
                {
                    MessageBox.Show("Нет изменений для сохранения");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int delete = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delete);
        }

        private void Clients_btn_Click(object sender, EventArgs e)
        {
            Clients  Form = new Clients();
            Form.Show();
            this.Hide();

        }

        private void TZ_btn_Click(object sender, EventArgs e)
        {
            TZ Form = new TZ();
            Form.Show();
            this.Hide();
        }
    }
}
