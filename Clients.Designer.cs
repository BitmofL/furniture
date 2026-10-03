namespace Mebel_predpr
{
    partial class Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mebel_predprDataSet = new Mebel_predpr.Mebel_predprDataSet();
            this.klientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientsTableAdapter = new Mebel_predpr.Mebel_predprDataSetTableAdapters.KlientsTableAdapter();
            this.iDklientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clients_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebel_predprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDklientDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // mebel_predprDataSet
            // 
            this.mebel_predprDataSet.DataSetName = "Mebel_predprDataSet";
            this.mebel_predprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientsBindingSource
            // 
            this.klientsBindingSource.DataMember = "Klients";
            this.klientsBindingSource.DataSource = this.mebel_predprDataSet;
            // 
            // klientsTableAdapter
            // 
            this.klientsTableAdapter.ClearBeforeFill = true;
            // 
            // iDklientDataGridViewTextBoxColumn
            // 
            this.iDklientDataGridViewTextBoxColumn.DataPropertyName = "ID_klient";
            this.iDklientDataGridViewTextBoxColumn.HeaderText = "№ Клиента";
            this.iDklientDataGridViewTextBoxColumn.Name = "iDklientDataGridViewTextBoxColumn";
            this.iDklientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "Fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Эл-почта";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Clients_btn
            // 
            this.Clients_btn.Location = new System.Drawing.Point(312, 297);
            this.Clients_btn.Name = "Clients_btn";
            this.Clients_btn.Size = new System.Drawing.Size(135, 50);
            this.Clients_btn.TabIndex = 8;
            this.Clients_btn.Text = "На главную";
            this.Clients_btn.UseVisualStyleBackColor = true;
            this.Clients_btn.Click += new System.EventHandler(this.Clients_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(153, 297);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(135, 50);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 297);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(135, 50);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 359);
            this.Controls.Add(this.Clients_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Clients";
            this.Text = "Мебельное предприятие(Клиенты)";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebel_predprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Mebel_predprDataSet mebel_predprDataSet;
        private System.Windows.Forms.BindingSource klientsBindingSource;
        private Mebel_predprDataSetTableAdapters.KlientsTableAdapter klientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDklientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Clients_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_button;
    }
}