namespace ColdWheels.Telas.Interno.telaLocacoes
{
    partial class telaEditarLocacao
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
            this.label2 = new System.Windows.Forms.Label();
            this.Combo = new ReaLTaiizor.Controls.AloneComboBox();
            this.dgvEditarLocação = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataFim = new ReaLTaiizor.Controls.PoisonDateTime();
            this.dataInicio = new ReaLTaiizor.Controls.PoisonDateTime();
            this.panelVidroArredondado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarLocação)).BeginInit();
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
            this.button1.TabIndex = 69;
            this.button1.Text = "Cadastrar";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crownLabel1
            // 
            this.crownLabel1.AutoSize = true;
            this.crownLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.crownLabel1.Location = new System.Drawing.Point(41, 76);
            this.crownLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.crownLabel1.Name = "crownLabel1";
            this.crownLabel1.Size = new System.Drawing.Size(124, 13);
            this.crownLabel1.TabIndex = 68;
            this.crownLabel1.Text = "Edite Locação existente.";
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
            this.bigLabel1.Size = new System.Drawing.Size(237, 46);
            this.bigLabel1.TabIndex = 67;
            this.bigLabel1.Text = "Editar Locação";
            // 
            // panelVidroArredondado1
            // 
            this.panelVidroArredondado1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVidroArredondado1.BackColor = System.Drawing.Color.Transparent;
            this.panelVidroArredondado1.Controls.Add(this.label2);
            this.panelVidroArredondado1.Controls.Add(this.Combo);
            this.panelVidroArredondado1.Controls.Add(this.dgvEditarLocação);
            this.panelVidroArredondado1.Controls.Add(this.label1);
            this.panelVidroArredondado1.Controls.Add(this.label15);
            this.panelVidroArredondado1.Controls.Add(this.dataFim);
            this.panelVidroArredondado1.Controls.Add(this.dataInicio);
            this.panelVidroArredondado1.CorDoVidro = System.Drawing.Color.White;
            this.panelVidroArredondado1.Location = new System.Drawing.Point(19, 104);
            this.panelVidroArredondado1.Name = "panelVidroArredondado1";
            this.panelVidroArredondado1.Opacidade = 125;
            this.panelVidroArredondado1.RaioBorda = 20;
            this.panelVidroArredondado1.Size = new System.Drawing.Size(1054, 484);
            this.panelVidroArredondado1.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Status:";
            // 
            // Combo
            // 
            this.Combo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Combo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo.EnabledCalc = true;
            this.Combo.FormattingEnabled = true;
            this.Combo.ItemHeight = 20;
            this.Combo.Location = new System.Drawing.Point(173, 52);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(200, 26);
            this.Combo.TabIndex = 83;
            // 
            // dgvEditarLocação
            // 
            this.dgvEditarLocação.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEditarLocação.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditarLocação.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEditarLocação.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEditarLocação.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEditarLocação.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEditarLocação.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditarLocação.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEditarLocação.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditarLocação.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEditarLocação.EnableHeadersVisualStyles = false;
            this.dgvEditarLocação.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEditarLocação.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEditarLocação.Location = new System.Drawing.Point(3, 87);
            this.dgvEditarLocação.Name = "dgvEditarLocação";
            this.dgvEditarLocação.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditarLocação.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEditarLocação.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEditarLocação.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditarLocação.Size = new System.Drawing.Size(1048, 375);
            this.dgvEditarLocação.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Data Devolução:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(415, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 81;
            this.label15.Text = "Data Locação:";
            // 
            // dataFim
            // 
            this.dataFim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataFim.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dataFim.Location = new System.Drawing.Point(663, 52);
            this.dataFim.MinimumSize = new System.Drawing.Size(0, 29);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(200, 29);
            this.dataFim.TabIndex = 80;
            // 
            // dataInicio
            // 
            this.dataInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataInicio.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dataInicio.Location = new System.Drawing.Point(418, 52);
            this.dataInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(200, 29);
            this.dataInicio.TabIndex = 79;
            // 
            // telaEditarLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelVidroArredondado1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crownLabel1);
            this.Controls.Add(this.bigLabel1);
            this.Name = "telaEditarLocacao";
            this.Size = new System.Drawing.Size(1093, 663);
            this.panelVidroArredondado1.ResumeLayout(false);
            this.panelVidroArredondado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarLocação)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PanelVidroArredondado panelVidroArredondado1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private ReaLTaiizor.Controls.PoisonDateTime dataFim;
        private ReaLTaiizor.Controls.PoisonDateTime dataInicio;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.AloneComboBox Combo;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvEditarLocação;
    }
}
