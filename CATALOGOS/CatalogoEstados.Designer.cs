namespace Herrajes
{
    partial class CatalogoEstados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoEstados));
            this.herrajesDataSet = new Herrajes.HerrajesDataSet();
            this.h_EstadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.h_EstadosTableAdapter = new Herrajes.HerrajesDataSetTableAdapters.H_EstadosTableAdapter();
            this.tableAdapterManager = new Herrajes.HerrajesDataSetTableAdapters.TableAdapterManager();
            this.h_EstadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.captura = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.capital = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.herrajesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h_EstadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h_EstadosDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.captura.SuspendLayout();
            this.SuspendLayout();
            // 
            // herrajesDataSet
            // 
            this.herrajesDataSet.DataSetName = "HerrajesDataSet";
            this.herrajesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // h_EstadosBindingSource
            // 
            this.h_EstadosBindingSource.DataMember = "H_Estados";
            this.h_EstadosBindingSource.DataSource = this.herrajesDataSet;
            // 
            // h_EstadosTableAdapter
            // 
            this.h_EstadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ag_PatentesGmenorTableAdapter = null;
            this.tableAdapterManager.ag_PatentesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.H_ApiariosTableAdapter = null;
            this.tableAdapterManager.H_EstadosTableAdapter = this.h_EstadosTableAdapter;
            this.tableAdapterManager.H_FierrosTableAdapter = null;
            this.tableAdapterManager.H_FigurasTableAdapter = null;
            this.tableAdapterManager.H_HistorialTableAdapter = null;
            this.tableAdapterManager.H_KioscosTableAdapter = null;
            this.tableAdapterManager.H_LocalidadesTableAdapter = null;
            this.tableAdapterManager.H_MarcasTableAdapter = null;
            this.tableAdapterManager.H_MovimientosTableAdapter = null;
            this.tableAdapterManager.H_MunicipiosTableAdapter = null;
            this.tableAdapterManager.H_PatentesGanaderasTableAdapter = null;
            this.tableAdapterManager.H_PersonasTableAdapter = null;
            this.tableAdapterManager.H_PoblacionesPecuariasTableAdapter = null;
            this.tableAdapterManager.H_PreciosTableAdapter = null;
            this.tableAdapterManager.H_RelacionesTableAdapter = null;
            this.tableAdapterManager.H_ReposicionesTableAdapter = null;
            this.tableAdapterManager.H_SecretariosTableAdapter = null;
            this.tableAdapterManager.H_SociedadesTableAdapter = null;
            this.tableAdapterManager.H_StatusTableAdapter = null;
            this.tableAdapterManager.H_TemporalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Herrajes.HerrajesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // h_EstadosDataGridView
            // 
            this.h_EstadosDataGridView.AllowUserToAddRows = false;
            this.h_EstadosDataGridView.AutoGenerateColumns = false;
            this.h_EstadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.h_EstadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.h_EstadosDataGridView.DataSource = this.h_EstadosBindingSource;
            this.h_EstadosDataGridView.Location = new System.Drawing.Point(11, 68);
            this.h_EstadosDataGridView.Name = "h_EstadosDataGridView";
            this.h_EstadosDataGridView.Size = new System.Drawing.Size(340, 309);
            this.h_EstadosDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Capital";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cápital";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(362, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Nuevo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "Modificar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "Guardar";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton4.Text = "Cancelar";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton5.Text = "Salir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Estados";
            // 
            // captura
            // 
            this.captura.Controls.Add(this.label3);
            this.captura.Controls.Add(this.capital);
            this.captura.Controls.Add(this.estado);
            this.captura.Controls.Add(this.label2);
            this.captura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captura.Location = new System.Drawing.Point(11, 385);
            this.captura.Name = "captura";
            this.captura.Size = new System.Drawing.Size(340, 112);
            this.captura.TabIndex = 19;
            this.captura.TabStop = false;
            this.captura.Text = "Captura el dato: ";
            this.captura.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capital:";
            // 
            // capital
            // 
            this.capital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capital.Location = new System.Drawing.Point(109, 61);
            this.capital.Name = "capital";
            this.capital.Size = new System.Drawing.Size(220, 21);
            this.capital.TabIndex = 2;
            // 
            // estado
            // 
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(109, 34);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(220, 21);
            this.estado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estado: ";
            // 
            // CatalogoEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 508);
            this.Controls.Add(this.captura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.h_EstadosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatalogoEstados";
            this.Text = "Catálogo Estados";
            this.Load += new System.EventHandler(this.CatalogoEstados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.herrajesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h_EstadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h_EstadosDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.captura.ResumeLayout(false);
            this.captura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HerrajesDataSet herrajesDataSet;
        private System.Windows.Forms.BindingSource h_EstadosBindingSource;
        private HerrajesDataSetTableAdapters.H_EstadosTableAdapter h_EstadosTableAdapter;
        private HerrajesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView h_EstadosDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox captura;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capital;
    }
}