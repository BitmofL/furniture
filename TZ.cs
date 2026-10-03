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
    public partial class TZ : Form
    {
        public TZ()
        {
            InitializeComponent();
        }

        private void TZ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebel_predprDataSet.Tech_zadan". При необходимости она может быть перемещена или удалена.
            this.tech_zadanTableAdapter.Fill(this.mebel_predprDataSet.Tech_zadan);

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

        private void save_button_Click(object sender, EventArgs e)
        {
            tech_zadanTableAdapter.Update(mebel_predprDataSet);
        }
    }
}
