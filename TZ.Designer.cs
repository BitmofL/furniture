namespace Mebel_predpr
{
    partial class TZ
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
            this.techzadanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_zadanTableAdapter = new Mebel_predpr.Mebel_predprDataSetTableAdapters.Tech_zadanTableAdapter();
            this.Clients_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.iDTZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebel_predprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techzadanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTZDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.techzadanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // mebel_predprDataSet
            // 
            this.mebel_predprDataSet.DataSetName = "Mebel_predprDataSet";
            this.mebel_predprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techzadanBindingSource
            // 
            this.techzadanBindingSource.DataMember = "Tech_zadan";
            this.techzadanBindingSource.DataSource = this.mebel_predprDataSet;
            // 
            // tech_zadanTableAdapter
            // 
            this.tech_zadanTableAdapter.ClearBeforeFill = true;
            // 
            // Clients_btn
            // 
            this.Clients_btn.Location = new System.Drawing.Point(307, 401);
            this.Clients_btn.Name = "Clients_btn";
            this.Clients_btn.Size = new System.Drawing.Size(131, 50);
            this.Clients_btn.TabIndex = 11;
            this.Clients_btn.Text = "На главную";
            this.Clients_btn.UseVisualStyleBackColor = true;
            this.Clients_btn.Click += new System.EventHandler(this.Clients_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(142, 401);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(116, 50);
            this.delete_btn.TabIndex = 10;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(2, 401);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(134, 50);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // iDTZDataGridViewTextBoxColumn
            // 
            this.iDTZDataGridViewTextBoxColumn.DataPropertyName = "ID_TZ";
            this.iDTZDataGridViewTextBoxColumn.HeaderText = "ID_TZ";
            this.iDTZDataGridViewTextBoxColumn.Name = "iDTZDataGridViewTextBoxColumn";
            this.iDTZDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // TZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.Clients_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TZ";
            this.Text = "TZ";
            this.Load += new System.EventHandler(this.TZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebel_predprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techzadanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Mebel_predprDataSet mebel_predprDataSet;
        private System.Windows.Forms.BindingSource techzadanBindingSource;
        private Mebel_predprDataSetTableAdapters.Tech_zadanTableAdapter tech_zadanTableAdapter;
        private System.Windows.Forms.Button Clients_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}