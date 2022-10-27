namespace Laba1
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
            this.iDcompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroDataSet1 = new Laba1.aeroDataSet1();
            this.tripBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aeroDataSet = new Laba1.aeroDataSet();
            this.tripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripTableAdapter = new Laba1.aeroDataSetTableAdapters.TripTableAdapter();
            this.company = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.aeroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new Laba1.aeroDataSet1TableAdapters.CompanyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcompDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.companyBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 783);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDcompDataGridViewTextBoxColumn
            // 
            this.iDcompDataGridViewTextBoxColumn.DataPropertyName = "ID_comp";
            this.iDcompDataGridViewTextBoxColumn.HeaderText = "ID_comp";
            this.iDcompDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDcompDataGridViewTextBoxColumn.Name = "iDcompDataGridViewTextBoxColumn";
            this.iDcompDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDcompDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.aeroDataSet1;
            // 
            // aeroDataSet1
            // 
            this.aeroDataSet1.DataSetName = "aeroDataSet1";
            this.aeroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripBindingSource1
            // 
            this.tripBindingSource1.DataMember = "Trip";
            this.tripBindingSource1.DataSource = this.aeroDataSet;
            // 
            // aeroDataSet
            // 
            this.aeroDataSet.DataSetName = "aeroDataSet";
            this.aeroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripBindingSource
            // 
            this.tripBindingSource.DataMember = "Trip";
            this.tripBindingSource.DataSource = this.aeroDataSet;
            // 
            // tripTableAdapter
            // 
            this.tripTableAdapter.ClearBeforeFill = true;
            // 
            // company
            // 
            this.company.Location = new System.Drawing.Point(0, 611);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(167, 34);
            this.company.TabIndex = 1;
            this.company.Text = "Авиакомпании";
            this.company.UseVisualStyleBackColor = true;
            this.company.Click += new System.EventHandler(this.company_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(627, 611);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(305, 34);
            this.remove.TabIndex = 2;
            this.remove.Text = "Удалить изменения";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(438, 611);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(167, 34);
            this.add.TabIndex = 3;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(173, 611);
            this.name.MaxLength = 10;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(242, 26);
            this.name.TabIndex = 4;
            // 
            // aeroDataSetBindingSource
            // 
            this.aeroDataSetBindingSource.DataSource = this.aeroDataSet;
            this.aeroDataSetBindingSource.Position = 0;
            // 
            // tripBindingSource2
            // 
            this.tripBindingSource2.DataMember = "Trip";
            this.tripBindingSource2.DataSource = this.aeroDataSetBindingSource;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 783);
            this.Controls.Add(this.name);
            this.Controls.Add(this.add);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.company);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private aeroDataSet aeroDataSet;
        private System.Windows.Forms.BindingSource tripBindingSource;
        private aeroDataSetTableAdapters.TripTableAdapter tripTableAdapter;
        private System.Windows.Forms.Button company;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.BindingSource tripBindingSource1;
        private System.Windows.Forms.BindingSource aeroDataSetBindingSource;
        private System.Windows.Forms.BindingSource tripBindingSource2;
        private aeroDataSet1 aeroDataSet1;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private aeroDataSet1TableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcompDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}

