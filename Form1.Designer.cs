namespace CSharp_bai_8
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
            this.label1 = new System.Windows.Forms.Label();
            this.DuongLich = new System.Windows.Forms.Label();
            this.AmLich = new System.Windows.Forms.Label();
            this.txtDuongLich = new System.Windows.Forms.TextBox();
            this.txtAmLich = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH CAN CHI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DuongLich
            // 
            this.DuongLich.AutoSize = true;
            this.DuongLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuongLich.Location = new System.Drawing.Point(116, 169);
            this.DuongLich.Name = "DuongLich";
            this.DuongLich.Size = new System.Drawing.Size(186, 31);
            this.DuongLich.TabIndex = 1;
            this.DuongLich.Text = "DƯƠNG LỊCH";
            // 
            // AmLich
            // 
            this.AmLich.AutoSize = true;
            this.AmLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmLich.Location = new System.Drawing.Point(116, 255);
            this.AmLich.Name = "AmLich";
            this.AmLich.Size = new System.Drawing.Size(124, 31);
            this.AmLich.TabIndex = 2;
            this.AmLich.Text = "ÂM LỊCH";
            // 
            // txtDuongLich
            // 
            this.txtDuongLich.Location = new System.Drawing.Point(434, 169);
            this.txtDuongLich.Name = "txtDuongLich";
            this.txtDuongLich.Size = new System.Drawing.Size(499, 20);
            this.txtDuongLich.TabIndex = 3;
            // 
            // txtAmLich
            // 
            this.txtAmLich.Location = new System.Drawing.Point(434, 266);
            this.txtAmLich.Name = "txtAmLich";
            this.txtAmLich.Size = new System.Drawing.Size(499, 20);
            this.txtAmLich.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(590, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "CHUYỂN ĐỔI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAmLich);
            this.Controls.Add(this.txtDuongLich);
            this.Controls.Add(this.AmLich);
            this.Controls.Add(this.DuongLich);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DuongLich;
        private System.Windows.Forms.Label AmLich;
        private System.Windows.Forms.TextBox txtDuongLich;
        private System.Windows.Forms.TextBox txtAmLich;
        private System.Windows.Forms.Button button1;
    }
}

