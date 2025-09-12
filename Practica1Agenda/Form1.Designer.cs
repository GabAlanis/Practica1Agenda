namespace Practica1Agenda
{
    partial class Agenda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Pat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            this.Etiqueta = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temporizador = new System.Windows.Forms.Timer();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.opfAbrir = new System.Windows.Forms.OpenFileDialog();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.ssInfo.SuspendLayout();
            this.menu.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido_Pat,
            this.Apellido_Mat,
            this.Direccion,
            this.Tel,
            this.Correo});
            this.dgvAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgenda.Location = new System.Drawing.Point(0, 0);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.RowTemplate.Height = 28;
            this.dgvAgenda.Size = new System.Drawing.Size(1465, 567);
            this.dgvAgenda.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Apellido_Pat
            // 
            this.Apellido_Pat.HeaderText = "Apellido Paterno";
            this.Apellido_Pat.Name = "Apellido_Pat";
            this.Apellido_Pat.Width = 150;
            // 
            // Apellido_Mat
            // 
            this.Apellido_Mat.HeaderText = "Apellido Materno";
            this.Apellido_Mat.Name = "Apellido_Mat";
            this.Apellido_Mat.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 250;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Teléfono";
            this.Tel.Name = "Tel";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.Width = 200;
            // 
            // ssInfo
            // 
            this.ssInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ssInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Etiqueta});
            this.ssInfo.Location = new System.Drawing.Point(0, 545);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(1465, 22);
            this.ssInfo.TabIndex = 1;
            this.ssInfo.Text = "statusStrip1";
            this.ssInfo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ssInfo_ItemClicked);
            // 
            // Etiqueta
            // 
            this.Etiqueta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Etiqueta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Etiqueta.LinkColor = System.Drawing.Color.Black;
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.Size = new System.Drawing.Size(0, 17);
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(1465, 25);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarTablaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // limpiarTablaToolStripMenuItem
            // 
            this.limpiarTablaToolStripMenuItem.Name = "limpiarTablaToolStripMenuItem";
            this.limpiarTablaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.limpiarTablaToolStripMenuItem.Text = "Limpiar Tabla";
            this.limpiarTablaToolStripMenuItem.Click += new System.EventHandler(this.limpiarTablaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // temporizador
            // 
            this.temporizador.Interval = 500;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // opfAbrir
            // 
            this.opfAbrir.FileName = "openFileDialog1";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ssInfo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvAgenda);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1465, 567);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1465, 592);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menu);
            // 
            // Agenda
            // 
            this.ClientSize = new System.Drawing.Size(1465, 592);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menu;
            this.Name = "Agenda";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ssInfo.ResumeLayout(false);
            this.ssInfo.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Pat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.StatusStrip ssInfo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
        private System.Windows.Forms.OpenFileDialog opfAbrir;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel Etiqueta;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}

