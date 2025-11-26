namespace ColdWheels
{
    partial class telaVeiculos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            this.dgvVeiculos = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.containerExcluirVeiculos = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.containerExcluirVeiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(35, 29);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(142, 46);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Veiculos";
            // 
            // crownLabel1
            // 
            this.crownLabel1.AutoSize = true;
            this.crownLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.crownLabel1.Location = new System.Drawing.Point(40, 73);
            this.crownLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.crownLabel1.Name = "crownLabel1";
            this.crownLabel1.Size = new System.Drawing.Size(140, 13);
            this.crownLabel1.TabIndex = 1;
            this.crownLabel1.Text = "Gerencie a frota de veiculos";
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVeiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVeiculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVeiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVeiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVeiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVeiculos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVeiculos.EnableHeadersVisualStyles = false;
            this.dgvVeiculos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvVeiculos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVeiculos.Location = new System.Drawing.Point(37, 116);
            this.dgvVeiculos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVeiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVeiculos.RowHeadersWidth = 62;
            this.dgvVeiculos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVeiculos.RowTemplate.Height = 28;
            this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeiculos.Size = new System.Drawing.Size(1020, 521);
            this.dgvVeiculos.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnEditarCliente);
            this.panel2.Location = new System.Drawing.Point(920, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 46);
            this.panel2.TabIndex = 9;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Image = global::ColdWheels.Properties.Resources.car_gear_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCliente.Location = new System.Drawing.Point(0, 0);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEditarCliente.Size = new System.Drawing.Size(134, 44);
            this.btnEditarCliente.TabIndex = 7;
            this.btnEditarCliente.Text = "    Editar Veículo";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnCadastrarCliente);
            this.panel1.Location = new System.Drawing.Point(759, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 46);
            this.panel1.TabIndex = 8;
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Image = global::ColdWheels.Properties.Resources.traffic_jam_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnCadastrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCadastrarCliente.Size = new System.Drawing.Size(134, 44);
            this.btnCadastrarCliente.TabIndex = 7;
            this.btnCadastrarCliente.Text = "        Cadatrar Veículo";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // containerExcluirVeiculos
            // 
            this.containerExcluirVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.containerExcluirVeiculos.Controls.Add(this.button1);
            this.containerExcluirVeiculos.Location = new System.Drawing.Point(597, 65);
            this.containerExcluirVeiculos.Name = "containerExcluirVeiculos";
            this.containerExcluirVeiculos.Size = new System.Drawing.Size(137, 46);
            this.containerExcluirVeiculos.TabIndex = 12;
            this.containerExcluirVeiculos.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = global::ColdWheels.Properties.Resources.dangerous_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(134, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "    Excluir Veiculo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // telaVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containerExcluirVeiculos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvVeiculos);
            this.Controls.Add(this.crownLabel1);
            this.Controls.Add(this.bigLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "telaVeiculos";
            this.Size = new System.Drawing.Size(1093, 663);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.containerExcluirVeiculos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvVeiculos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Panel containerExcluirVeiculos;
        private System.Windows.Forms.Button button1;
    }
}
