namespace MilAccess.View
{
    partial class frmSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaida));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocumentos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbPessoa = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnVeiculo = new System.Windows.Forms.Button();
            this.btnCivil = new System.Windows.Forms.Button();
            this.btnMilitar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(232, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 27);
            this.label1.TabIndex = 58;
            this.label1.Text = "Informe Os Dados Da Pessoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(250, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 56;
            this.label5.Text = "Menu Usado:";
            // 
            // txtDocumentos
            // 
            this.txtDocumentos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentos.Location = new System.Drawing.Point(379, 109);
            this.txtDocumentos.MaxLength = 11;
            this.txtDocumentos.Name = "txtDocumentos";
            this.txtDocumentos.Size = new System.Drawing.Size(176, 28);
            this.txtDocumentos.TabIndex = 53;
            this.txtDocumentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentos_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(250, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "Identidade:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLimpar);
            this.panel3.Controls.Add(this.btnSalvar);
            this.panel3.Location = new System.Drawing.Point(379, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 84);
            this.panel3.TabIndex = 63;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(0, 39);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(176, 39);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(0, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(176, 39);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbPessoa
            // 
            this.cmbPessoa.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.cmbPessoa.FormattingEnabled = true;
            this.cmbPessoa.Items.AddRange(new object[] {
            "Militar",
            "Civil",
            "Veiculo"});
            this.cmbPessoa.Location = new System.Drawing.Point(379, 74);
            this.cmbPessoa.Name = "cmbPessoa";
            this.cmbPessoa.Size = new System.Drawing.Size(176, 29);
            this.cmbPessoa.TabIndex = 57;
            this.cmbPessoa.Text = "Selecione";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRelatorio);
            this.panel2.Controls.Add(this.btnX);
            this.panel2.Controls.Add(this.btnSaida);
            this.panel2.Controls.Add(this.btnVeiculo);
            this.panel2.Controls.Add(this.btnCivil);
            this.panel2.Controls.Add(this.btnMilitar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 274);
            this.panel2.TabIndex = 6;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Image = global::MilAccess.Properties.Resources.Relatorio;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 168);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(200, 42);
            this.btnRelatorio.TabIndex = 5;
            this.btnRelatorio.Text = "Relatorio";
            this.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnX.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Image = global::MilAccess.Properties.Resources.Sair;
            this.btnX.Location = new System.Drawing.Point(0, 224);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(200, 50);
            this.btnX.TabIndex = 4;
            this.btnX.Text = "Sair";
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaida.FlatAppearance.BorderSize = 0;
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.ForeColor = System.Drawing.Color.White;
            this.btnSaida.Image = global::MilAccess.Properties.Resources.FinalizarSaida;
            this.btnSaida.Location = new System.Drawing.Point(0, 126);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(200, 42);
            this.btnSaida.TabIndex = 3;
            this.btnSaida.Text = "Saida";
            this.btnSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSaida.UseVisualStyleBackColor = false;
            // 
            // btnVeiculo
            // 
            this.btnVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVeiculo.FlatAppearance.BorderSize = 0;
            this.btnVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeiculo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnVeiculo.Image = global::MilAccess.Properties.Resources.Carro;
            this.btnVeiculo.Location = new System.Drawing.Point(0, 84);
            this.btnVeiculo.Name = "btnVeiculo";
            this.btnVeiculo.Size = new System.Drawing.Size(200, 42);
            this.btnVeiculo.TabIndex = 2;
            this.btnVeiculo.Text = "Veiculo";
            this.btnVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVeiculo.UseVisualStyleBackColor = false;
            this.btnVeiculo.Click += new System.EventHandler(this.btnVeiculo_Click);
            // 
            // btnCivil
            // 
            this.btnCivil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCivil.FlatAppearance.BorderSize = 0;
            this.btnCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCivil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCivil.ForeColor = System.Drawing.Color.White;
            this.btnCivil.Image = global::MilAccess.Properties.Resources.Civil;
            this.btnCivil.Location = new System.Drawing.Point(0, 42);
            this.btnCivil.Name = "btnCivil";
            this.btnCivil.Size = new System.Drawing.Size(200, 42);
            this.btnCivil.TabIndex = 1;
            this.btnCivil.Text = "Civil";
            this.btnCivil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCivil.UseVisualStyleBackColor = false;
            this.btnCivil.Click += new System.EventHandler(this.btnCivil_Click);
            // 
            // btnMilitar
            // 
            this.btnMilitar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMilitar.FlatAppearance.BorderSize = 0;
            this.btnMilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMilitar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMilitar.ForeColor = System.Drawing.Color.White;
            this.btnMilitar.Image = global::MilAccess.Properties.Resources.Militar1;
            this.btnMilitar.Location = new System.Drawing.Point(0, 0);
            this.btnMilitar.Name = "btnMilitar";
            this.btnMilitar.Size = new System.Drawing.Size(200, 42);
            this.btnMilitar.TabIndex = 0;
            this.btnMilitar.Text = "Militar";
            this.btnMilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMilitar.UseVisualStyleBackColor = false;
            this.btnMilitar.Click += new System.EventHandler(this.btnMilitar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(12, 141);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 21);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Kauã";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(12, 120);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(81, 21);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Soldado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MilAccess.Properties.Resources.armyofficer_man_person_avatar_ejercito_2849;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 105);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDocumentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmbPessoa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MilAccess";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnVeiculo;
        private System.Windows.Forms.Button btnCivil;
        private System.Windows.Forms.Button btnMilitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocumentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbPessoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRelatorio;
    }
}