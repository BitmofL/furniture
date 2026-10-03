namespace Mebel_predpr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDzakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datevipolnenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDizdelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summzakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakaziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mebel_predprDataSet = new Mebel_predpr.Mebel_predprDataSet();
            this.zakaziTableAdapter = new Mebel_predpr.Mebel_predprDataSetTableAdapters.ZakaziTableAdapter();
            this.save_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.TZ_btn = new System.Windows.Forms.Button();
            this.Clients_btn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebel_predprDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDzakDataGridViewTextBoxColumn,
            this.iDclientDataGridViewTextBoxColumn,
            this.datevipolnenDataGridViewTextBoxColumn,
            this.tzDataGridViewTextBoxColumn,
            this.iDizdelDataGridViewTextBoxColumn,
            this.summzakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zakaziBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDzakDataGridViewTextBoxColumn
            // 
            this.iDzakDataGridViewTextBoxColumn.DataPropertyName = "ID_zak";
            this.iDzakDataGridViewTextBoxColumn.HeaderText = "№ Заказа";
            this.iDzakDataGridViewTextBoxColumn.Name = "iDzakDataGridViewTextBoxColumn";
            this.iDzakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDclientDataGridViewTextBoxColumn
            // 
            this.iDclientDataGridViewTextBoxColumn.DataPropertyName = "ID_client";
            this.iDclientDataGridViewTextBoxColumn.HeaderText = "№ Клиента";
            this.iDclientDataGridViewTextBoxColumn.Name = "iDclientDataGridViewTextBoxColumn";
            // 
            // datevipolnenDataGridViewTextBoxColumn
            // 
            this.datevipolnenDataGridViewTextBoxColumn.DataPropertyName = "Date_vipolnen";
            this.datevipolnenDataGridViewTextBoxColumn.HeaderText = "Дата сдачи ";
            this.datevipolnenDataGridViewTextBoxColumn.Name = "datevipolnenDataGridViewTextBoxColumn";
            // 
            // tzDataGridViewTextBoxColumn
            // 
            this.tzDataGridViewTextBoxColumn.DataPropertyName = "Tz";
            this.tzDataGridViewTextBoxColumn.HeaderText = "Тех-задание";
            this.tzDataGridViewTextBoxColumn.Name = "tzDataGridViewTextBoxColumn";
            // 
            // iDizdelDataGridViewTextBoxColumn
            // 
            this.iDizdelDataGridViewTextBoxColumn.DataPropertyName = "ID_izdel";
            this.iDizdelDataGridViewTextBoxColumn.HeaderText = "№ На складе";
            this.iDizdelDataGridViewTextBoxColumn.Name = "iDizdelDataGridViewTextBoxColumn";
            // 
            // summzakDataGridViewTextBoxColumn
            // 
            this.summzakDataGridViewTextBoxColumn.DataPropertyName = "Summ_zak";
            this.summzakDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.summzakDataGridViewTextBoxColumn.Name = "summzakDataGridViewTextBoxColumn";
            // 
            // zakaziBindingSource
            // 
            this.zakaziBindingSource.DataMember = "Zakazi";
            this.zakaziBindingSource.DataSource = this.mebel_predprDataSet;
            // 
            // mebel_predprDataSet
            // 
            this.mebel_predprDataSet.DataSetName = "Mebel_predprDataSet";
            this.mebel_predprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakaziTableAdapter
            // 
            this.zakaziTableAdapter.ClearBeforeFill = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(3, 342);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(135, 50);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 315);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(144, 342);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(135, 50);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // TZ_btn
            // 
            this.TZ_btn.Location = new System.Drawing.Point(512, 342);
            this.TZ_btn.Name = "TZ_btn";
            this.TZ_btn.Size = new System.Drawing.Size(135, 50);
            this.TZ_btn.TabIndex = 4;
            this.TZ_btn.Text = "К ТЗ";
            this.TZ_btn.UseVisualStyleBackColor = true;
            this.TZ_btn.Click += new System.EventHandler(this.TZ_btn_Click);
            // 
            // Clients_btn
            // 
            this.Clients_btn.Location = new System.Drawing.Point(371, 342);
            this.Clients_btn.Name = "Clients_btn";
            this.Clients_btn.Size = new System.Drawing.Size(135, 50);
            this.Clients_btn.TabIndex = 5;
            this.Clients_btn.Text = "К клиентам";
            this.Clients_btn.UseVisualStyleBackColor = true;
            this.Clients_btn.Click += new System.EventHandler(this.Clients_btn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(260, 315);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(376, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Справка о клиентах";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Справка оТЗ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Clients_btn);
            this.Controls.Add(this.TZ_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebel_predprDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Mebel_predprDataSet mebel_predprDataSet;
        private System.Windows.Forms.BindingSource zakaziBindingSource;
        private Mebel_predprDataSetTableAdapters.ZakaziTableAdapter zakaziTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datevipolnenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDizdelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summzakDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button TZ_btn;
        private System.Windows.Forms.Button Clients_btn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

