namespace Tarea3.Presentacion
{
    partial class CUAutores
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.auidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aulnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aufnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pubsDataSet = new Tarea3.pubsDataSet();
            this.pubsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new Tarea3.pubsDataSetTableAdapters.authorsTableAdapter();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autores";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 491);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(813, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(199)))), ((int)(((byte)(198)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 94);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(199)))), ((int)(((byte)(198)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(273, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(264, 94);
            this.button3.TabIndex = 2;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(199)))), ((int)(((byte)(198)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(543, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.auidDataGridViewTextBoxColumn,
            this.aulnameDataGridViewTextBoxColumn,
            this.aufnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn,
            this.contractDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.authorsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(813, 391);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // auidDataGridViewTextBoxColumn
            // 
            this.auidDataGridViewTextBoxColumn.DataPropertyName = "au_id";
            this.auidDataGridViewTextBoxColumn.HeaderText = "au_id";
            this.auidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.auidDataGridViewTextBoxColumn.Name = "auidDataGridViewTextBoxColumn";
            // 
            // aulnameDataGridViewTextBoxColumn
            // 
            this.aulnameDataGridViewTextBoxColumn.DataPropertyName = "au_lname";
            this.aulnameDataGridViewTextBoxColumn.HeaderText = "au_lname";
            this.aulnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aulnameDataGridViewTextBoxColumn.Name = "aulnameDataGridViewTextBoxColumn";
            // 
            // aufnameDataGridViewTextBoxColumn
            // 
            this.aufnameDataGridViewTextBoxColumn.DataPropertyName = "au_fname";
            this.aufnameDataGridViewTextBoxColumn.HeaderText = "au_fname";
            this.aufnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aufnameDataGridViewTextBoxColumn.Name = "aufnameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "zip";
            this.zipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // contractDataGridViewCheckBoxColumn
            // 
            this.contractDataGridViewCheckBoxColumn.DataPropertyName = "contract";
            this.contractDataGridViewCheckBoxColumn.HeaderText = "contract";
            this.contractDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.contractDataGridViewCheckBoxColumn.Name = "contractDataGridViewCheckBoxColumn";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "authors";
            this.authorsBindingSource.DataSource = this.pubsDataSet;
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "pubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pubsDataSetBindingSource
            // 
            this.pubsDataSetBindingSource.DataSource = this.pubsDataSet;
            this.pubsDataSetBindingSource.Position = 0;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // CUAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "CUAutores";
            this.Size = new System.Drawing.Size(813, 591);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn auidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aulnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aufnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn contractDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private pubsDataSet pubsDataSet;
        private System.Windows.Forms.BindingSource pubsDataSetBindingSource;
        private pubsDataSetTableAdapters.authorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}
