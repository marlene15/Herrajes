namespace Herrajes
{
    partial class SelectorDeSociedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectorDeSociedad));
            this.herrajesDataSet = new Herrajes.HerrajesDataSet();
            this.h_SociedadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.h_SociedadesTableAdapter = new Herrajes.HerrajesDataSetTableAdapters.H_SociedadesTableAdapter();
            this.tableAdapterManager = new Herrajes.HerrajesDataSetTableAdapters.TableAdapterManager();
            this.h_SociedadesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BRazon = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.herrajesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h_SociedadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h_SociedadesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // herrajesDataSet
            // 
            this.herrajesDataSet.DataSetName = "HerrajesDataSet";
            this.herrajesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // h_SociedadesBindingSource
            // 
            this.h_SociedadesBindingSource.DataMember = "H_Sociedades";
            this.h_SociedadesBindingSource.DataSource = this.herrajesDataSet;
            // 
            // h_SociedadesTableAdapter
            // 
            this.h_SociedadesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ag_PatentesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.H_ApiariosTableAdapter = null;
            this.tableAdapterManager.H_FierrosTableAdapter = null;
            this.tableAdapterManager.H_FigurasTableAdapter = null;
            this.tableAdapterManager.H_HistorialTableAdapter = null;
            this.tableAdapterManager.H_KioscosTableAdapter = null;
            this.tableAdapterManager.H_LocalidadesTableAdapter = null;
            this.tableAdapterManager.H_MarcasTableAdapter = null;
            this.tableAdapterManager.H_MunicipiosTableAdapter = null;
            this.tableAdapterManager.H_PatentesGanaderasTableAdapter = null;
            this.tableAdapterManager.H_PersonasTableAdapter = null;
            this.tableAdapterManager.H_PoblacionesPecuariasTableAdapter = null;
            this.tableAdapterManager.H_PreciosTableAdapter = null;
            this.tableAdapterManager.H_RelacionesTableAdapter = null;
            this.tableAdapterManager.H_ReposicionesTableAdapter = null;
            this.tableAdapterManager.H_SecretariosTableAdapter = null;
            this.tableAdapterManager.H_SociedadesTableAdapter = this.h_SociedadesTableAdapter;
            this.tableAdapterManager.H_StatusTableAdapter = null;
            this.tableAdapterManager.H_TemporalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Herrajes.HerrajesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // h_SociedadesDataGridView
            // 
            this.h_SociedadesDataGridView.AllowUserToAddRows = false;
            this.h_SociedadesDataGridView.AutoGenerateColumns = false;
            this.h_SociedadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.h_SociedadesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.h_SociedadesDataGridView.DataSource = this.h_SociedadesBindingSource;
            this.h_SociedadesDataGridView.Location = new System.Drawing.Point(12, 117);
            this.h_SociedadesDataGridView.Name = "h_SociedadesDataGridView";
            this.h_SociedadesDataGridView.Size = new System.Drawing.Size(799, 340);
            this.h_SociedadesDataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BRazon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de Busqueda";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(400, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Razón Social:";
            // 
            // BRazon
            // 
            this.BRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRazon.Location = new System.Drawing.Point(121, 36);
            this.BRazon.Name = "BRazon";
            this.BRazon.Size = new System.Drawing.Size(273, 22);
            this.BRazon.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(737, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 53);
            this.button3.TabIndex = 9;
            this.button3.Text = "Seleccionar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(656, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Nuevo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RazonSocial";
            this.dataGridViewTextBoxColumn2.FillWeight = 130F;
            this.dataGridViewTextBoxColumn2.HeaderText = "RAZÓN SOCIAL";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RFC";
            this.dataGridViewTextBoxColumn3.HeaderText = "RFC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Calle";
            this.dataGridViewTextBoxColumn4.HeaderText = "CALLE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Colonia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Colonia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Localidad_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Localidad_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn7.HeaderText = "TELÉFONO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Socio1_ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "Socio1_ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Socio2_ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "Socio2_ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Socio3_ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "Socio3_ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // SelectorDeSociedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 469);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.h_SociedadesDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectorDeSociedad";
            this.Text = "Selector de Sociedad";
            this.Load += new System.EventHandler(this.SelectorDeSociedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.herrajesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h_SociedadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h_SociedadesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HerrajesDataSet herrajesDataSet;
        private System.Windows.Forms.BindingSource h_SociedadesBindingSource;
        private HerrajesDataSetTableAdapters.H_SociedadesTableAdapter h_SociedadesTableAdapter;
        private HerrajesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView h_SociedadesDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BRazon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}