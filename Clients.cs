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
    
    public partial class Clients : Form
    {
        
      
        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebel_predprDataSet.Klients". При необходимости она может быть перемещена или удалена.
            this.klientsTableAdapter.Fill(this.mebel_predprDataSet.Klients);
           

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            klientsTableAdapter.Update(mebel_predprDataSet);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int delete = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delete);
        }

        private void Clients_btn_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
            this.Close();
        }
    }
}
