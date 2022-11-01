namespace CS311_Project2_MRE
{
    partial class Craps
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstDice = new System.Windows.Forms.Label();
            this.lblSecondDice = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstDice
            // 
            this.lblFirstDice.AutoSize = true;
            this.lblFirstDice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstDice.Location = new System.Drawing.Point(111, 120);
            this.lblFirstDice.Name = "lblFirstDice";
            this.lblFirstDice.Size = new System.Drawing.Size(0, 28);
            this.lblFirstDice.TabIndex = 0;
            this.lblFirstDice.Click += new System.EventHandler(this.lblFirstDice_Click);
            // 
            // lblSecondDice
            // 
            this.lblSecondDice.AutoSize = true;
            this.lblSecondDice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecondDice.Location = new System.Drawing.Point(111, 165);
            this.lblSecondDice.Name = "lblSecondDice";
            this.lblSecondDice.Size = new System.Drawing.Size(0, 28);
            this.lblSecondDice.TabIndex = 1;
            this.lblSecondDice.Click += new System.EventHandler(this.lblSecondDice_Click);
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBet.Location = new System.Drawing.Point(34, 70);
            this.txtBet.Name = "txtBet";
            this.txtBet.PlaceholderText = "Enter your bet";
            this.txtBet.Size = new System.Drawing.Size(147, 34);
            this.txtBet.TabIndex = 2;
            this.txtBet.TextChanged += new System.EventHandler(this.txtBet_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(87, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(225, 76);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 28);
            this.lblResult.TabIndex = 4;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.AutoSize = true;
            this.lblBankBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBankBalance.Location = new System.Drawing.Point(92, 23);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(89, 28);
            this.lblBankBalance.TabIndex = 5;
            this.lblBankBalance.Text = "$100.00";
            // 
            // Craps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBankBalance);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblSecondDice);
            this.Controls.Add(this.lblFirstDice);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Craps";
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.Craps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFirstDice;
        private Label lblSecondDice;
        private TextBox txtBet;
        private Button button1;
        private Label lblResult;
        private Label lblBankBalance;
    }
}