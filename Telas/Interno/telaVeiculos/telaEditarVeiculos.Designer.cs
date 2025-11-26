namespace ColdWheels
{
    partial class telaEditarVeiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.panelVidroArredondado1 = new PanelVidroArredondado();
            this.dgvEditVeiculos = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.Combo = new ReaLTaiizor.Controls.AloneComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKm = new ReaLTaiizor.Controls.AloneTextBox();
            this.txtMarca = new ReaLTaiizor.Controls.AloneTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtModelo = new ReaLTaiizor.Controls.AloneTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPlaca = new ReaLTaiizor.Controls.AloneTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAno = new ReaLTaiizor.Controls.AloneTextBox();
            this.panelVidroArredondado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = null;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Location = new System.Drawing.Point(477, 592);
            this.button1.Name = "button1";
            this.button1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.Size = new System.Drawing.Size(140, 41);
            this.button1.TabIndex = 73;
            this.button1.Text = "Editar";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // crownLabel1
            // 
            this.crownLabel1.AutoSize = true;
            this.crownLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.crownLabel1.Location = new System.Drawing.Point(41, 76);
            this.crownLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.crownLabel1.Name = "crownLabel1";
            this.crownLabel1.Size = new System.Drawing.Size(176, 13);
            this.crownLabel1.TabIndex = 72;
            this.crownLabel1.Text = "Edite as informações de um veículo";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(32, 30);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(223, 46);
            this.bigLabel1.TabIndex = 71;
            this.bigLabel1.Text = "Editar Veículo";
            // 
            // panelVidroArredondado1
            // 
            this.panelVidroArredondado1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVidroArredondado1.BackColor = System.Drawing.Color.Transparent;
            this.panelVidroArredondado1.Controls.Add(this.dgvEditVeiculos);
            this.panelVidroArredondado1.Controls.Add(this.bigLabel2);
            this.panelVidroArredondado1.Controls.Add(this.Combo);
            this.panelVidroArredondado1.Controls.Add(this.label1);
            this.panelVidroArredondado1.Controls.Add(this.txtKm);
            this.panelVidroArredondado1.Controls.Add(this.txtMarca);
            this.panelVidroArredondado1.Controls.Add(this.label15);
            this.panelVidroArredondado1.Controls.Add(this.label17);
            this.panelVidroArredondado1.Controls.Add(this.txtModelo);
            this.panelVidroArredondado1.Controls.Add(this.label19);
            this.panelVidroArredondado1.Controls.Add(this.txtPlaca);
            this.panelVidroArredondado1.Controls.Add(this.label20);
            this.panelVidroArredondado1.Controls.Add(this.label23);
            this.panelVidroArredondado1.Controls.Add(this.txtAno);
            this.panelVidroArredondado1.CorDoVidro = System.Drawing.Color.White;
            this.panelVidroArredondado1.Location = new System.Drawing.Point(19, 104);
            this.panelVidroArredondado1.Name = "panelVidroArredondado1";
            this.panelVidroArredondado1.Opacidade = 125;
            this.panelVidroArredondado1.RaioBorda = 20;
            this.panelVidroArredondado1.Size = new System.Drawing.Size(1054, 484);
            this.panelVidroArredondado1.TabIndex = 74;
            // 
            // dgvEditVeiculos
            // 
            this.dgvEditVeiculos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEditVeiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEditVeiculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEditVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEditVeiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEditVeiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditVeiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEditVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditVeiculos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEditVeiculos.EnableHeadersVisualStyles = false;
            this.dgvEditVeiculos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEditVeiculos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEditVeiculos.Location = new System.Drawing.Point(3, 255);
            this.dgvEditVeiculos.Name = "dgvEditVeiculos";
            this.dgvEditVeiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditVeiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEditVeiculos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEditVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditVeiculos.Size = new System.Drawing.Size(1048, 213);
            this.dgvEditVeiculos.TabIndex = 55;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(17, 31);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(371, 46);
            this.bigLabel2.TabIndex = 54;
            this.bigLabel2.Text = "Informações do Veículo";
            // 
            // Combo
            // 
            this.Combo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo.EnabledCalc = true;
            this.Combo.FormattingEnabled = true;
            this.Combo.ItemHeight = 20;
            this.Combo.Location = new System.Drawing.Point(516, 205);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(70, 26);
            this.Combo.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Km:";
            // 
            // txtKm
            // 
            this.txtKm.BackColor = System.Drawing.Color.Transparent;
            this.txtKm.EnabledCalc = true;
            this.txtKm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtKm.Location = new System.Drawing.Point(265, 202);
            this.txtKm.MaxLength = 32767;
            this.txtKm.MultiLine = false;
            this.txtKm.Name = "txtKm";
            this.txtKm.ReadOnly = false;
            this.txtKm.Size = new System.Drawing.Size(97, 29);
            this.txtKm.TabIndex = 51;
            this.txtKm.Text = "10.000";
            this.txtKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKm.UseSystemPasswordChar = false;
            this.txtKm.Enter += new System.EventHandler(this.txtKm_Enter);
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.Transparent;
            this.txtMarca.EnabledCalc = true;
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtMarca.Location = new System.Drawing.Point(21, 128);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.MultiLine = false;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = false;
            this.txtMarca.Size = new System.Drawing.Size(197, 29);
            this.txtMarca.TabIndex = 37;
            this.txtMarca.Text = "Digite a marco do veículo";
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMarca.UseSystemPasswordChar = false;
            this.txtMarca.Enter += new System.EventHandler(this.txtMarca_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "MARCA:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(513, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "CATEGORIA:";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.Transparent;
            this.txtModelo.EnabledCalc = true;
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtModelo.Location = new System.Drawing.Point(265, 128);
            this.txtModelo.MaxLength = 32767;
            this.txtModelo.MultiLine = false;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = false;
            this.txtModelo.Size = new System.Drawing.Size(203, 29);
            this.txtModelo.TabIndex = 41;
            this.txtModelo.Text = "Informe o modelo do veículo";
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtModelo.UseSystemPasswordChar = false;
            this.txtModelo.Enter += new System.EventHandler(this.txtModelo_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(262, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "MODELO:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.Transparent;
            this.txtPlaca.EnabledCalc = true;
            this.txtPlaca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtPlaca.Location = new System.Drawing.Point(516, 125);
            this.txtPlaca.MaxLength = 32767;
            this.txtPlaca.MultiLine = false;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = false;
            this.txtPlaca.Size = new System.Drawing.Size(212, 29);
            this.txtPlaca.TabIndex = 43;
            this.txtPlaca.Text = "AAA1A1A1";
            this.txtPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPlaca.UseSystemPasswordChar = false;
            this.txtPlaca.Enter += new System.EventHandler(this.txtPlaca_Enter);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(513, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 44;
            this.label20.Text = "PLACA:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(22, 186);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 50;
            this.label23.Text = "ANO:";
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.Transparent;
            this.txtAno.EnabledCalc = true;
            this.txtAno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtAno.Location = new System.Drawing.Point(25, 202);
            this.txtAno.MaxLength = 32767;
            this.txtAno.MultiLine = false;
            this.txtAno.Name = "txtAno";
            this.txtAno.ReadOnly = false;
            this.txtAno.Size = new System.Drawing.Size(97, 29);
            this.txtAno.TabIndex = 49;
            this.txtAno.Text = "2000";
            this.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAno.UseSystemPasswordChar = false;
            this.txtAno.Enter += new System.EventHandler(this.txtAno_Enter);
            // 
            // telaEditarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelVidroArredondado1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crownLabel1);
            this.Controls.Add(this.bigLabel1);
            this.Name = "telaEditarVeiculos";
            this.Size = new System.Drawing.Size(1093, 663);
            this.panelVidroArredondado1.ResumeLayout(false);
            this.panelVidroArredondado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PanelVidroArredondado panelVidroArredondado1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.AloneComboBox Combo;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.AloneTextBox txtKm;
        private ReaLTaiizor.Controls.AloneTextBox txtMarca;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private ReaLTaiizor.Controls.AloneTextBox txtModelo;
        private System.Windows.Forms.Label label19;
        private ReaLTaiizor.Controls.AloneTextBox txtPlaca;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private ReaLTaiizor.Controls.AloneTextBox txtAno;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvEditVeiculos;
    }
}
