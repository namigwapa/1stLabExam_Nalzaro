namespace Nalzaro_1stLabExam
{
    partial class Form1
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
            this.lbl_Display = new System.Windows.Forms.Label();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Initial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Display
            // 
            this.lbl_Display.AutoSize = true;
            this.lbl_Display.Location = new System.Drawing.Point(156, 354);
            this.lbl_Display.Name = "lbl_Display";
            this.lbl_Display.Size = new System.Drawing.Size(17, 20);
            this.lbl_Display.TabIndex = 26;
            this.lbl_Display.Text = ",,";
            // 
            // Btn_Print
            // 
            this.Btn_Print.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Print.Location = new System.Drawing.Point(504, 276);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(140, 44);
            this.Btn_Print.TabIndex = 25;
            this.Btn_Print.Text = "Print Summary";
            this.Btn_Print.UseVisualStyleBackColor = false;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Clear.Location = new System.Drawing.Point(326, 276);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(140, 44);
            this.Btn_Clear.TabIndex = 24;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Submit.Location = new System.Drawing.Point(160, 276);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(123, 44);
            this.Btn_Submit.TabIndex = 23;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = false;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(378, 203);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(106, 26);
            this.txt_Amount.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Amount of Sale: ";
            // 
            // txt_Initial
            // 
            this.txt_Initial.Location = new System.Drawing.Point(378, 153);
            this.txt_Initial.Name = "txt_Initial";
            this.txt_Initial.Size = new System.Drawing.Size(106, 26);
            this.txt_Initial.TabIndex = 20;
            this.txt_Initial.TextChanged += new System.EventHandler(this.txt_Initial_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter Sales Person Initial: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = " D = Danielle E = Edward F = Fatima";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Display);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Initial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Display;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Initial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

