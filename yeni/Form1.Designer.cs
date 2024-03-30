
namespace yeni
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
         
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_kapat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_kontrol = new System.Windows.Forms.Button();
            this.textBox_bul = new System.Windows.Forms.TextBox();
            this.label_bulunacak_kelime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_basla = new System.Windows.Forms.Button();
            this.textBox_bulunmasını_istedigimiz_kelime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_tahmin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(704, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Kelimeyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // button_kapat
            // 
            this.button_kapat.BackColor = System.Drawing.Color.Brown;
            this.button_kapat.Location = new System.Drawing.Point(624, 521);
            this.button_kapat.Name = "button_kapat";
            this.button_kapat.Size = new System.Drawing.Size(95, 30);
            this.button_kapat.TabIndex = 19;
            this.button_kapat.Text = "Geri Dön";
            this.button_kapat.UseVisualStyleBackColor = false;
            this.button_kapat.Click += new System.EventHandler(this.button_kapat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_kontrol);
            this.groupBox1.Controls.Add(this.textBox_bul);
            this.groupBox1.Location = new System.Drawing.Point(252, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 201);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tahmininiz :";
            // 
            // button_kontrol
            // 
            this.button_kontrol.BackColor = System.Drawing.Color.RosyBrown;
            this.button_kontrol.Location = new System.Drawing.Point(209, 157);
            this.button_kontrol.Name = "button_kontrol";
            this.button_kontrol.Size = new System.Drawing.Size(101, 38);
            this.button_kontrol.TabIndex = 8;
            this.button_kontrol.Text = "Kontrol Et!";
            this.button_kontrol.UseVisualStyleBackColor = false;
            this.button_kontrol.Click += new System.EventHandler(this.button_kontrol_Click_1);
            // 
            // textBox_bul
            // 
            this.textBox_bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_bul.Location = new System.Drawing.Point(125, 100);
            this.textBox_bul.Name = "textBox_bul";
            this.textBox_bul.Size = new System.Drawing.Size(143, 38);
            this.textBox_bul.TabIndex = 6;
            // 
            // label_bulunacak_kelime
            // 
            this.label_bulunacak_kelime.AutoSize = true;
            this.label_bulunacak_kelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bulunacak_kelime.Location = new System.Drawing.Point(496, 145);
            this.label_bulunacak_kelime.Name = "label_bulunacak_kelime";
            this.label_bulunacak_kelime.Size = new System.Drawing.Size(0, 55);
            this.label_bulunacak_kelime.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(317, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kelimemiz :";
            // 
            // button_basla
            // 
            this.button_basla.BackColor = System.Drawing.Color.BurlyWood;
            this.button_basla.Location = new System.Drawing.Point(655, 60);
            this.button_basla.Name = "button_basla";
            this.button_basla.Size = new System.Drawing.Size(119, 33);
            this.button_basla.TabIndex = 15;
            this.button_basla.Text = "Oyuna Başla";
            this.button_basla.UseVisualStyleBackColor = false;
            this.button_basla.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox_bulunmasını_istedigimiz_kelime
            // 
            this.textBox_bulunmasını_istedigimiz_kelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_bulunmasını_istedigimiz_kelime.Location = new System.Drawing.Point(417, 18);
            this.textBox_bulunmasını_istedigimiz_kelime.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_bulunmasını_istedigimiz_kelime.Name = "textBox_bulunmasını_istedigimiz_kelime";
            this.textBox_bulunmasını_istedigimiz_kelime.Size = new System.Drawing.Size(280, 35);
            this.textBox_bulunmasını_istedigimiz_kelime.TabIndex = 14;
            this.textBox_bulunmasını_istedigimiz_kelime.TextChanged += new System.EventHandler(this.textBox_bulunmasını_istedigimiz_kelime_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bulunmasını istediğiniz kelimeyi giriniz :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_tahmin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(602, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 201);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Girilen tahminler :";
            // 
            // label_tahmin
            // 
            this.label_tahmin.AutoSize = true;
            this.label_tahmin.Location = new System.Drawing.Point(35, 72);
            this.label_tahmin.Name = "label_tahmin";
            this.label_tahmin.Size = new System.Drawing.Size(0, 13);
            this.label_tahmin.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(808, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_kapat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_bulunacak_kelime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_basla);
            this.Controls.Add(this.textBox_bulunmasını_istedigimiz_kelime);
            this.Controls.Add(this.label1);
         
            this.Name = "Form1";
            this.Text = "Adam Asmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_kapat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_kontrol;
        private System.Windows.Forms.TextBox textBox_bul;
        private System.Windows.Forms.Label label_bulunacak_kelime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_basla;
        private System.Windows.Forms.TextBox textBox_bulunmasını_istedigimiz_kelime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_tahmin;
        private System.Windows.Forms.Label label3;
    }
}

