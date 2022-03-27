
namespace WindowsForm1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_birinciNot = new System.Windows.Forms.TextBox();
            this.txt_ikinciNot = new System.Windows.Forms.TextBox();
            this.btn_ortalamahesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.NotunuzuGiriniz : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "2.NotunuzuGiriniz : ";
            // 
            // txt_birinciNot
            // 
            this.txt_birinciNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_birinciNot.Location = new System.Drawing.Point(277, 27);
            this.txt_birinciNot.Name = "txt_birinciNot";
            this.txt_birinciNot.Size = new System.Drawing.Size(132, 32);
            this.txt_birinciNot.TabIndex = 6;
            // 
            // txt_ikinciNot
            // 
            this.txt_ikinciNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ikinciNot.Location = new System.Drawing.Point(277, 105);
            this.txt_ikinciNot.Name = "txt_ikinciNot";
            this.txt_ikinciNot.Size = new System.Drawing.Size(132, 32);
            this.txt_ikinciNot.TabIndex = 7;
            // 
            // btn_ortalamahesapla
            // 
            this.btn_ortalamahesapla.Location = new System.Drawing.Point(41, 158);
            this.btn_ortalamahesapla.Name = "btn_ortalamahesapla";
            this.btn_ortalamahesapla.Size = new System.Drawing.Size(206, 46);
            this.btn_ortalamahesapla.TabIndex = 9;
            this.btn_ortalamahesapla.Text = "OrtalamayıBul";
            this.btn_ortalamahesapla.UseVisualStyleBackColor = true;
            this.btn_ortalamahesapla.Click += new System.EventHandler(this.btn_ortalamahesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(271, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ortalama";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(424, 171);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(32, 33);
            this.lbl_sonuc.TabIndex = 11;
            this.lbl_sonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 373);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ortalamahesapla);
            this.Controls.Add(this.txt_ikinciNot);
            this.Controls.Add(this.txt_birinciNot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_birinciNot;
        private System.Windows.Forms.TextBox txt_ikinciNot;
        private System.Windows.Forms.Button btn_ortalamahesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

