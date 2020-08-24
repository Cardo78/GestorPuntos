namespace GestorPuntos
{
    partial class GestorPuntos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtbArticulo = new MetroFramework.Controls.MetroTextBox();
            this.mtbCodigoNacional = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.CodigoArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntosArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idarticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtbPuntosEuro = new MetroFramework.Controls.MetroTextBox();
            this.mtbTotalPArticulo = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.tbTotalPuntos = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.tbNombreCliente = new MetroFramework.Controls.MetroTextBox();
            this.tbCodigoCliente = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.tbIPServidor = new MetroFramework.Controls.MetroTextBox();
            this.cLIENTEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbArticulo
            // 
            this.mtbArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtbArticulo.CustomButton.Image = null;
            this.mtbArticulo.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.mtbArticulo.CustomButton.Name = "";
            this.mtbArticulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbArticulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbArticulo.CustomButton.TabIndex = 1;
            this.mtbArticulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbArticulo.CustomButton.UseSelectable = true;
            this.mtbArticulo.CustomButton.Visible = false;
            this.mtbArticulo.Lines = new string[0];
            this.mtbArticulo.Location = new System.Drawing.Point(129, 19);
            this.mtbArticulo.MaxLength = 32767;
            this.mtbArticulo.Name = "mtbArticulo";
            this.mtbArticulo.PasswordChar = '\0';
            this.mtbArticulo.PromptText = "Descripción";
            this.mtbArticulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbArticulo.SelectedText = "";
            this.mtbArticulo.SelectionLength = 0;
            this.mtbArticulo.SelectionStart = 0;
            this.mtbArticulo.ShortcutsEnabled = true;
            this.mtbArticulo.Size = new System.Drawing.Size(381, 23);
            this.mtbArticulo.TabIndex = 0;
            this.mtbArticulo.UseSelectable = true;
            this.mtbArticulo.WaterMark = "Descripción";
            this.mtbArticulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbArticulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbArticulo_KeyPress);
            // 
            // mtbCodigoNacional
            // 
            // 
            // 
            // 
            this.mtbCodigoNacional.CustomButton.Image = null;
            this.mtbCodigoNacional.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.mtbCodigoNacional.CustomButton.Name = "";
            this.mtbCodigoNacional.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbCodigoNacional.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCodigoNacional.CustomButton.TabIndex = 1;
            this.mtbCodigoNacional.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCodigoNacional.CustomButton.UseSelectable = true;
            this.mtbCodigoNacional.CustomButton.Visible = false;
            this.mtbCodigoNacional.Lines = new string[0];
            this.mtbCodigoNacional.Location = new System.Drawing.Point(3, 19);
            this.mtbCodigoNacional.MaxLength = 32767;
            this.mtbCodigoNacional.Name = "mtbCodigoNacional";
            this.mtbCodigoNacional.PasswordChar = '\0';
            this.mtbCodigoNacional.PromptText = "Codigo Nacional";
            this.mtbCodigoNacional.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCodigoNacional.SelectedText = "";
            this.mtbCodigoNacional.SelectionLength = 0;
            this.mtbCodigoNacional.SelectionStart = 0;
            this.mtbCodigoNacional.ShortcutsEnabled = true;
            this.mtbCodigoNacional.Size = new System.Drawing.Size(107, 23);
            this.mtbCodigoNacional.TabIndex = 1;
            this.mtbCodigoNacional.UseSelectable = true;
            this.mtbCodigoNacional.WaterMark = "Codigo Nacional";
            this.mtbCodigoNacional.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCodigoNacional.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbCodigoNacional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCodigoNacional_KeyPress);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(625, 8);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(62, 43);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Buscar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(695, 356);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton6);
            this.metroTabPage1.Controls.Add(this.metroButton5);
            this.metroTabPage1.Controls.Add(this.metroGrid2);
            this.metroTabPage1.Controls.Add(this.mtbPuntosEuro);
            this.metroTabPage1.Controls.Add(this.mtbTotalPArticulo);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.mtbArticulo);
            this.metroTabPage1.Controls.Add(this.mtbCodigoNacional);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(687, 314);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Articulos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroButton6
            // 
            this.metroButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton6.Location = new System.Drawing.Point(516, 18);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(43, 24);
            this.metroButton6.TabIndex = 12;
            this.metroButton6.Text = "Todos";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton5.Location = new System.Drawing.Point(565, 19);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(54, 24);
            this.metroButton5.TabIndex = 11;
            this.metroButton5.Text = "Ninguno";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoArt,
            this.NomArt,
            this.PuntosArt,
            this.Precio,
            this.Activo,
            this.idarticulo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(4, 57);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(680, 225);
            this.metroGrid2.TabIndex = 10;
            this.metroGrid2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid2_CellClick);
            // 
            // CodigoArt
            // 
            this.CodigoArt.DataPropertyName = "codigo";
            this.CodigoArt.HeaderText = "Codigo";
            this.CodigoArt.Name = "CodigoArt";
            // 
            // NomArt
            // 
            this.NomArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.NomArt.DataPropertyName = "nombre";
            this.NomArt.HeaderText = "Descripción";
            this.NomArt.Name = "NomArt";
            this.NomArt.Width = 5;
            // 
            // PuntosArt
            // 
            this.PuntosArt.DataPropertyName = "puntos";
            this.PuntosArt.HeaderText = "Puntos";
            this.PuntosArt.Name = "PuntosArt";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "pvp";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            // 
            // idarticulo
            // 
            this.idarticulo.DataPropertyName = "idarticulo";
            this.idarticulo.HeaderText = "idarticulo";
            this.idarticulo.Name = "idarticulo";
            this.idarticulo.Visible = false;
            // 
            // mtbPuntosEuro
            // 
            this.mtbPuntosEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtbPuntosEuro.CustomButton.Image = null;
            this.mtbPuntosEuro.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.mtbPuntosEuro.CustomButton.Name = "";
            this.mtbPuntosEuro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbPuntosEuro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPuntosEuro.CustomButton.TabIndex = 1;
            this.mtbPuntosEuro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPuntosEuro.CustomButton.UseSelectable = true;
            this.mtbPuntosEuro.Lines = new string[0];
            this.mtbPuntosEuro.Location = new System.Drawing.Point(534, 288);
            this.mtbPuntosEuro.MaxLength = 32767;
            this.mtbPuntosEuro.Name = "mtbPuntosEuro";
            this.mtbPuntosEuro.PasswordChar = '\0';
            this.mtbPuntosEuro.PromptText = "Puntos x Euro";
            this.mtbPuntosEuro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPuntosEuro.SelectedText = "";
            this.mtbPuntosEuro.SelectionLength = 0;
            this.mtbPuntosEuro.SelectionStart = 0;
            this.mtbPuntosEuro.ShortcutsEnabled = true;
            this.mtbPuntosEuro.ShowButton = true;
            this.mtbPuntosEuro.Size = new System.Drawing.Size(130, 23);
            this.mtbPuntosEuro.TabIndex = 9;
            this.mtbPuntosEuro.UseSelectable = true;
            this.mtbPuntosEuro.WaterMark = "Puntos x Euro";
            this.mtbPuntosEuro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPuntosEuro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbPuntosEuro.Click += new System.EventHandler(this.mtbPuntosEuro_Click);
            // 
            // mtbTotalPArticulo
            // 
            this.mtbTotalPArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtbTotalPArticulo.CustomButton.Image = null;
            this.mtbTotalPArticulo.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.mtbTotalPArticulo.CustomButton.Name = "";
            this.mtbTotalPArticulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbTotalPArticulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbTotalPArticulo.CustomButton.TabIndex = 1;
            this.mtbTotalPArticulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbTotalPArticulo.CustomButton.UseSelectable = true;
            this.mtbTotalPArticulo.Lines = new string[0];
            this.mtbTotalPArticulo.Location = new System.Drawing.Point(368, 288);
            this.mtbTotalPArticulo.MaxLength = 32767;
            this.mtbTotalPArticulo.Name = "mtbTotalPArticulo";
            this.mtbTotalPArticulo.PasswordChar = '\0';
            this.mtbTotalPArticulo.PromptText = "Total Puntos";
            this.mtbTotalPArticulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbTotalPArticulo.SelectedText = "";
            this.mtbTotalPArticulo.SelectionLength = 0;
            this.mtbTotalPArticulo.SelectionStart = 0;
            this.mtbTotalPArticulo.ShortcutsEnabled = true;
            this.mtbTotalPArticulo.ShowButton = true;
            this.mtbTotalPArticulo.Size = new System.Drawing.Size(142, 23);
            this.mtbTotalPArticulo.TabIndex = 8;
            this.mtbTotalPArticulo.UseSelectable = true;
            this.mtbTotalPArticulo.WaterMark = "Total Puntos";
            this.mtbTotalPArticulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbTotalPArticulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbTotalPArticulo.Click += new System.EventHandler(this.mtbTotalPArticulo_Click);
            this.mtbTotalPArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbTotalPArticulo_KeyPress);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroGrid1);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroButton3);
            this.metroTabPage2.Controls.Add(this.tbTotalPuntos);
            this.metroTabPage2.Controls.Add(this.metroButton2);
            this.metroTabPage2.Controls.Add(this.tbNombreCliente);
            this.metroTabPage2.Controls.Add(this.tbCodigoCliente);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(687, 314);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Clientes";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Puntos,
            this.idcliente});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 52);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(618, 210);
            this.metroGrid1.TabIndex = 10;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 71;
            // 
            // Puntos
            // 
            this.Puntos.DataPropertyName = "puntos";
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.Name = "Puntos";
            this.Puntos.ReadOnly = true;
            // 
            // idcliente
            // 
            this.idcliente.DataPropertyName = "idcliente";
            this.idcliente.HeaderText = "idcliente";
            this.idcliente.Name = "idcliente";
            this.idcliente.ReadOnly = true;
            this.idcliente.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 281);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Total Puntos";
            // 
            // metroButton3
            // 
            this.metroButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton3.Location = new System.Drawing.Point(481, 268);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(137, 43);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "Aplicar";
            this.metroButton3.UseSelectable = true;
            // 
            // tbTotalPuntos
            // 
            this.tbTotalPuntos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.tbTotalPuntos.CustomButton.Image = null;
            this.tbTotalPuntos.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.tbTotalPuntos.CustomButton.Name = "";
            this.tbTotalPuntos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTotalPuntos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTotalPuntos.CustomButton.TabIndex = 1;
            this.tbTotalPuntos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTotalPuntos.CustomButton.UseSelectable = true;
            this.tbTotalPuntos.CustomButton.Visible = false;
            this.tbTotalPuntos.Lines = new string[0];
            this.tbTotalPuntos.Location = new System.Drawing.Point(141, 279);
            this.tbTotalPuntos.MaxLength = 32767;
            this.tbTotalPuntos.Name = "tbTotalPuntos";
            this.tbTotalPuntos.PasswordChar = '\0';
            this.tbTotalPuntos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTotalPuntos.SelectedText = "";
            this.tbTotalPuntos.SelectionLength = 0;
            this.tbTotalPuntos.SelectionStart = 0;
            this.tbTotalPuntos.ShortcutsEnabled = true;
            this.tbTotalPuntos.Size = new System.Drawing.Size(159, 23);
            this.tbTotalPuntos.TabIndex = 7;
            this.tbTotalPuntos.UseSelectable = true;
            this.tbTotalPuntos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTotalPuntos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbTotalPuntos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTotalPuntos_KeyPress);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(543, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 43);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Buscar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tbNombreCliente.CustomButton.Image = null;
            this.tbNombreCliente.CustomButton.Location = new System.Drawing.Point(377, 1);
            this.tbNombreCliente.CustomButton.Name = "";
            this.tbNombreCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNombreCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNombreCliente.CustomButton.TabIndex = 1;
            this.tbNombreCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNombreCliente.CustomButton.UseSelectable = true;
            this.tbNombreCliente.CustomButton.Visible = false;
            this.tbNombreCliente.Lines = new string[0];
            this.tbNombreCliente.Location = new System.Drawing.Point(128, 17);
            this.tbNombreCliente.MaxLength = 32767;
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.PasswordChar = '\0';
            this.tbNombreCliente.PromptText = "Nombre";
            this.tbNombreCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNombreCliente.SelectedText = "";
            this.tbNombreCliente.SelectionLength = 0;
            this.tbNombreCliente.SelectionStart = 0;
            this.tbNombreCliente.ShortcutsEnabled = true;
            this.tbNombreCliente.Size = new System.Drawing.Size(399, 23);
            this.tbNombreCliente.TabIndex = 3;
            this.tbNombreCliente.UseSelectable = true;
            this.tbNombreCliente.WaterMark = "Nombre";
            this.tbNombreCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNombreCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreCliente_KeyPress);
            // 
            // tbCodigoCliente
            // 
            // 
            // 
            // 
            this.tbCodigoCliente.CustomButton.Image = null;
            this.tbCodigoCliente.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.tbCodigoCliente.CustomButton.Name = "";
            this.tbCodigoCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCodigoCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCodigoCliente.CustomButton.TabIndex = 1;
            this.tbCodigoCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCodigoCliente.CustomButton.UseSelectable = true;
            this.tbCodigoCliente.CustomButton.Visible = false;
            this.tbCodigoCliente.Lines = new string[0];
            this.tbCodigoCliente.Location = new System.Drawing.Point(3, 17);
            this.tbCodigoCliente.MaxLength = 32767;
            this.tbCodigoCliente.Name = "tbCodigoCliente";
            this.tbCodigoCliente.PasswordChar = '\0';
            this.tbCodigoCliente.PromptText = "Codigo";
            this.tbCodigoCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCodigoCliente.SelectedText = "";
            this.tbCodigoCliente.SelectionLength = 0;
            this.tbCodigoCliente.SelectionStart = 0;
            this.tbCodigoCliente.ShortcutsEnabled = true;
            this.tbCodigoCliente.Size = new System.Drawing.Size(107, 23);
            this.tbCodigoCliente.TabIndex = 4;
            this.tbCodigoCliente.UseSelectable = true;
            this.tbCodigoCliente.WaterMark = "Codigo";
            this.tbCodigoCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCodigoCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbCodigoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoCliente_KeyPress);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroButton4);
            this.metroTabPage3.Controls.Add(this.tbIPServidor);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(687, 314);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Configuración";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(346, 28);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(124, 35);
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "Comprobar Conexión";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // tbIPServidor
            // 
            // 
            // 
            // 
            this.tbIPServidor.CustomButton.Image = null;
            this.tbIPServidor.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.tbIPServidor.CustomButton.Name = "";
            this.tbIPServidor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbIPServidor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbIPServidor.CustomButton.TabIndex = 1;
            this.tbIPServidor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbIPServidor.CustomButton.UseSelectable = true;
            this.tbIPServidor.CustomButton.Visible = false;
            this.tbIPServidor.Lines = new string[0];
            this.tbIPServidor.Location = new System.Drawing.Point(64, 35);
            this.tbIPServidor.MaxLength = 32767;
            this.tbIPServidor.Name = "tbIPServidor";
            this.tbIPServidor.PasswordChar = '\0';
            this.tbIPServidor.PromptText = "IP Servidor";
            this.tbIPServidor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbIPServidor.SelectedText = "";
            this.tbIPServidor.SelectionLength = 0;
            this.tbIPServidor.SelectionStart = 0;
            this.tbIPServidor.ShortcutsEnabled = true;
            this.tbIPServidor.Size = new System.Drawing.Size(276, 23);
            this.tbIPServidor.TabIndex = 2;
            this.tbIPServidor.UseSelectable = true;
            this.tbIPServidor.WaterMark = "IP Servidor";
            this.tbIPServidor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbIPServidor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbIPServidor.TextChanged += new System.EventHandler(this.tbIPServidor_TextChanged);
            // 
            // GestorPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 436);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "GestorPuntos";
            this.Text = "Contabilizador Puntos";
            this.Load += new System.EventHandler(this.GestorPuntos_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtbArticulo;
        private MetroFramework.Controls.MetroTextBox mtbCodigoNacional;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox mtbPuntosEuro;
        private MetroFramework.Controls.MetroTextBox mtbTotalPArticulo;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox tbTotalPuntos;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox tbNombreCliente;
        private MetroFramework.Controls.MetroTextBox tbCodigoCliente;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTextBox tbIPServidor;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarticulo;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}

