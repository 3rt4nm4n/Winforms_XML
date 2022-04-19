
namespace Winforms_XML_HW
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
            this.TextBox_Isim = new System.Windows.Forms.TextBox();
            this.TextBox_Soyisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_Kaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_Isim
            // 
            this.TextBox_Isim.Location = new System.Drawing.Point(157, 66);
            this.TextBox_Isim.Name = "TextBox_Isim";
            this.TextBox_Isim.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Isim.TabIndex = 0;
            // 
            // TextBox_Soyisim
            // 
            this.TextBox_Soyisim.Location = new System.Drawing.Point(157, 135);
            this.TextBox_Soyisim.Name = "TextBox_Soyisim";
            this.TextBox_Soyisim.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Soyisim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyisim";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_Kaydet);
            this.groupBox1.Controls.Add(this.TextBox_Isim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBox_Soyisim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 342);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // Button_Kaydet
            // 
            this.Button_Kaydet.Location = new System.Drawing.Point(110, 196);
            this.Button_Kaydet.Name = "Button_Kaydet";
            this.Button_Kaydet.Size = new System.Drawing.Size(92, 32);
            this.Button_Kaydet.TabIndex = 4;
            this.Button_Kaydet.Text = "Kaydet";
            this.Button_Kaydet.UseVisualStyleBackColor = true;
            this.Button_Kaydet.Click += new System.EventHandler(this.Button_Kaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 366);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Isim;
        private System.Windows.Forms.TextBox TextBox_Soyisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Kaydet;
    }
}

