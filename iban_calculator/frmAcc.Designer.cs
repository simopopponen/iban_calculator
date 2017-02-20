namespace iban_calculator
{
    partial class frmAcc
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
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.lblAccNumber = new System.Windows.Forms.Label();
            this.btnIban = new System.Windows.Forms.Button();
            this.lbliban = new System.Windows.Forms.Label();
            this.lblAccIban = new System.Windows.Forms.Label();
            this.lblBIC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.Location = new System.Drawing.Point(37, 52);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(126, 20);
            this.txtAccNumber.TabIndex = 0;
            //this.txtAccNumber.TextChanged += new System.EventHandler(this.txtAccNumber_TextChanged);
            // 
            // lblAccNumber
            // 
            this.lblAccNumber.AutoSize = true;
            this.lblAccNumber.Location = new System.Drawing.Point(37, 33);
            this.lblAccNumber.Name = "lblAccNumber";
            this.lblAccNumber.Size = new System.Drawing.Size(58, 13);
            this.lblAccNumber.TabIndex = 1;
            this.lblAccNumber.Text = "Tilinumero:";
            // 
            // btnIban
            // 
            this.btnIban.Location = new System.Drawing.Point(37, 164);
            this.btnIban.Name = "btnIban";
            this.btnIban.Size = new System.Drawing.Size(75, 23);
            this.btnIban.TabIndex = 2;
            this.btnIban.Text = "Tarkasta";
            this.btnIban.UseVisualStyleBackColor = true;
            this.btnIban.Click += new System.EventHandler(this.btnIban_Click);
            // 
            // lbliban
            // 
            this.lbliban.AutoSize = true;
            this.lbliban.Location = new System.Drawing.Point(40, 79);
            this.lbliban.Name = "lbliban";
            this.lbliban.Size = new System.Drawing.Size(35, 13);
            this.lbliban.TabIndex = 3;
            this.lbliban.Text = "IBAN:";
            // 
            // lblAccIban
            // 
            this.lblAccIban.AutoSize = true;
            this.lblAccIban.Location = new System.Drawing.Point(43, 96);
            this.lblAccIban.Name = "lblAccIban";
            this.lblAccIban.Size = new System.Drawing.Size(0, 13);
            this.lblAccIban.TabIndex = 4;
            // 
            // lblBIC
            // 
            this.lblBIC.AutoSize = true;
            this.lblBIC.Location = new System.Drawing.Point(37, 126);
            this.lblBIC.Name = "lblBIC";
            this.lblBIC.Size = new System.Drawing.Size(0, 13);
            this.lblBIC.TabIndex = 5;
            // 
            // frmAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 279);
            this.Controls.Add(this.lblBIC);
            this.Controls.Add(this.lblAccIban);
            this.Controls.Add(this.lbliban);
            this.Controls.Add(this.btnIban);
            this.Controls.Add(this.lblAccNumber);
            this.Controls.Add(this.txtAccNumber);
            this.Name = "frmAcc";
            this.Text = "Iban tilinumero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccNumber;
        private System.Windows.Forms.Label lblAccNumber;
        private System.Windows.Forms.Button btnIban;
        private System.Windows.Forms.Label lbliban;
        private System.Windows.Forms.Label lblAccIban;
        private System.Windows.Forms.Label lblBIC;
    }
}

