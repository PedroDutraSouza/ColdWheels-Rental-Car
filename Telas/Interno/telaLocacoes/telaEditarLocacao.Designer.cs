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
            this.panelVidroArredondado1 = new PanelVidroArredondado();
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.SuspendLayout();
            // 
            // panelVidroArredondado1
            // 
            this.panelVidroArredondado1.BackColor = System.Drawing.Color.Transparent;
            this.panelVidroArredondado1.CorDoVidro = System.Drawing.Color.White;
            this.panelVidroArredondado1.Location = new System.Drawing.Point(19, 104);
            this.panelVidroArredondado1.Name = "panelVidroArredondado1";
            this.panelVidroArredondado1.Opacidade = 125;
            this.panelVidroArredondado1.RaioBorda = 20;
            this.panelVidroArredondado1.Size = new System.Drawing.Size(1054, 484);
            this.panelVidroArredondado1.TabIndex = 70;
            // 
            // button1
            // 
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PanelVidroArredondado panelVidroArredondado1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}
