
namespace inicio
{
    partial class frmInicio
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHoras = new System.Windows.Forms.Button();
            this.btnDiaHj = new System.Windows.Forms.Button();
            this.btnBRLUSD = new System.Windows.Forms.Button();
            this.btnUSDBRL = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblAREARESTRITA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHoras
            // 
            this.btnHoras.AccessibleName = "";
            this.btnHoras.Location = new System.Drawing.Point(44, 203);
            this.btnHoras.Name = "btnHoras";
            this.btnHoras.Size = new System.Drawing.Size(75, 54);
            this.btnHoras.TabIndex = 0;
            this.btnHoras.Text = "Que Horas São";
            this.btnHoras.UseVisualStyleBackColor = true;
            this.btnHoras.Click += new System.EventHandler(this.btnHoras_Click);
            // 
            // btnDiaHj
            // 
            this.btnDiaHj.AccessibleName = "";
            this.btnDiaHj.Location = new System.Drawing.Point(205, 203);
            this.btnDiaHj.Name = "btnDiaHj";
            this.btnDiaHj.Size = new System.Drawing.Size(75, 54);
            this.btnDiaHj.TabIndex = 1;
            this.btnDiaHj.Text = "Que Horas São";
            this.btnDiaHj.UseVisualStyleBackColor = true;
            this.btnDiaHj.Click += new System.EventHandler(this.btnDiaHj_Click);
            // 
            // btnBRLUSD
            // 
            this.btnBRLUSD.Location = new System.Drawing.Point(205, 294);
            this.btnBRLUSD.Name = "btnBRLUSD";
            this.btnBRLUSD.Size = new System.Drawing.Size(75, 23);
            this.btnBRLUSD.TabIndex = 3;
            this.btnBRLUSD.Text = "BRL-USD";
            this.btnBRLUSD.UseVisualStyleBackColor = true;
            this.btnBRLUSD.Click += new System.EventHandler(this.btnBRLUSD_Click);
            // 
            // btnUSDBRL
            // 
            this.btnUSDBRL.Location = new System.Drawing.Point(44, 294);
            this.btnUSDBRL.Name = "btnUSDBRL";
            this.btnUSDBRL.Size = new System.Drawing.Size(75, 23);
            this.btnUSDBRL.TabIndex = 2;
            this.btnUSDBRL.Text = "USD-BRL";
            this.btnUSDBRL.UseVisualStyleBackColor = true;
            this.btnUSDBRL.Click += new System.EventHandler(this.btnUSDBRL_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(133, 411);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(123, 358);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 5;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(72, 364);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 6;
            this.lblCEP.Text = "CEP:";
            // 
            // lblAREARESTRITA
            // 
            this.lblAREARESTRITA.AutoSize = true;
            this.lblAREARESTRITA.Location = new System.Drawing.Point(130, 86);
            this.lblAREARESTRITA.Name = "lblAREARESTRITA";
            this.lblAREARESTRITA.Size = new System.Drawing.Size(93, 13);
            this.lblAREARESTRITA.TabIndex = 7;
            this.lblAREARESTRITA.Text = "AREA RESTRITA";
            this.lblAREARESTRITA.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 518);
            this.Controls.Add(this.lblAREARESTRITA);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBRLUSD);
            this.Controls.Add(this.btnUSDBRL);
            this.Controls.Add(this.btnDiaHj);
            this.Controls.Add(this.btnHoras);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHoras;
        private System.Windows.Forms.Button btnDiaHj;
        private System.Windows.Forms.Button btnBRLUSD;
        private System.Windows.Forms.Button btnUSDBRL;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblAREARESTRITA;
    }
}

