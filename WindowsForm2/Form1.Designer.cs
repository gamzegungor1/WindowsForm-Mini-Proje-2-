
namespace WindowsForm2
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_gunsecimi = new System.Windows.Forms.Label();
            this.btn_secim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "pazartesi ",
            "salı ",
            "çarşamba ",
            "perşembe",
            "cuma ",
            "cumartesi ",
            "pazar"});
            this.comboBox2.Location = new System.Drawing.Point(216, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 33);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lbl_gunsecimi
            // 
            this.lbl_gunsecimi.AutoSize = true;
            this.lbl_gunsecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gunsecimi.Location = new System.Drawing.Point(39, 64);
            this.lbl_gunsecimi.Name = "lbl_gunsecimi";
            this.lbl_gunsecimi.Size = new System.Drawing.Size(171, 29);
            this.lbl_gunsecimi.TabIndex = 2;
            this.lbl_gunsecimi.Text = "Gün Seçiniz : ";
            // 
            // btn_secim
            // 
            this.btn_secim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_secim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_secim.Location = new System.Drawing.Point(44, 130);
            this.btn_secim.Name = "btn_secim";
            this.btn_secim.Size = new System.Drawing.Size(386, 49);
            this.btn_secim.TabIndex = 3;
            this.btn_secim.Text = "Seçtiğiniz Günü Onaylayın";
            this.btn_secim.UseVisualStyleBackColor = false;
            this.btn_secim.Click += new System.EventHandler(this.btn_secim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 292);
            this.Controls.Add(this.btn_secim);
            this.Controls.Add(this.lbl_gunsecimi);
            this.Controls.Add(this.comboBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_gunsecimi;
        private System.Windows.Forms.Button btn_secim;
    }
}

