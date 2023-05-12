namespace PasswordGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.lowerCharsCB = new System.Windows.Forms.CheckBox();
            this.upperCharsCB = new System.Windows.Forms.CheckBox();
            this.numbersCharsCB = new System.Windows.Forms.CheckBox();
            this.symbolsCharCB = new System.Windows.Forms.CheckBox();
            this.passLengthNUD = new System.Windows.Forms.NumericUpDown();
            this.passGenerateB = new System.Windows.Forms.Button();
            this.savePassB = new System.Windows.Forms.Button();
            this.toPassListB = new System.Windows.Forms.Button();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.sameCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passLengthNUD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTB.Location = new System.Drawing.Point(30, 97);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(187, 26);
            this.passwordTB.TabIndex = 0;
            // 
            // lowerCharsCB
            // 
            this.lowerCharsCB.AutoSize = true;
            this.lowerCharsCB.Location = new System.Drawing.Point(23, 61);
            this.lowerCharsCB.Name = "lowerCharsCB";
            this.lowerCharsCB.Size = new System.Drawing.Size(159, 17);
            this.lowerCharsCB.TabIndex = 1;
            this.lowerCharsCB.Text = "Буквы в нижнем регистре";
            this.lowerCharsCB.UseVisualStyleBackColor = true;
            // 
            // upperCharsCB
            // 
            this.upperCharsCB.AutoSize = true;
            this.upperCharsCB.Location = new System.Drawing.Point(23, 84);
            this.upperCharsCB.Name = "upperCharsCB";
            this.upperCharsCB.Size = new System.Drawing.Size(162, 17);
            this.upperCharsCB.TabIndex = 2;
            this.upperCharsCB.Text = "Буквы в верхнем регистре";
            this.upperCharsCB.UseVisualStyleBackColor = true;
            // 
            // numbersCharsCB
            // 
            this.numbersCharsCB.AutoSize = true;
            this.numbersCharsCB.Location = new System.Drawing.Point(23, 107);
            this.numbersCharsCB.Name = "numbersCharsCB";
            this.numbersCharsCB.Size = new System.Drawing.Size(62, 17);
            this.numbersCharsCB.TabIndex = 3;
            this.numbersCharsCB.Text = "Цифры";
            this.numbersCharsCB.UseVisualStyleBackColor = true;
            // 
            // symbolsCharCB
            // 
            this.symbolsCharCB.AutoSize = true;
            this.symbolsCharCB.Location = new System.Drawing.Point(23, 130);
            this.symbolsCharCB.Name = "symbolsCharCB";
            this.symbolsCharCB.Size = new System.Drawing.Size(144, 17);
            this.symbolsCharCB.TabIndex = 4;
            this.symbolsCharCB.Text = "Специальные символы";
            this.symbolsCharCB.UseVisualStyleBackColor = true;
            // 
            // passLengthNUD
            // 
            this.passLengthNUD.Location = new System.Drawing.Point(23, 29);
            this.passLengthNUD.Name = "passLengthNUD";
            this.passLengthNUD.Size = new System.Drawing.Size(120, 20);
            this.passLengthNUD.TabIndex = 5;
            // 
            // passGenerateB
            // 
            this.passGenerateB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.passGenerateB.Location = new System.Drawing.Point(239, 97);
            this.passGenerateB.Name = "passGenerateB";
            this.passGenerateB.Size = new System.Drawing.Size(100, 26);
            this.passGenerateB.TabIndex = 6;
            this.passGenerateB.Text = "Сгенерировать";
            this.passGenerateB.UseVisualStyleBackColor = false;
            this.passGenerateB.Click += new System.EventHandler(this.passGenerateB_Click);
            // 
            // savePassB
            // 
            this.savePassB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.savePassB.Location = new System.Drawing.Point(30, 140);
            this.savePassB.Name = "savePassB";
            this.savePassB.Size = new System.Drawing.Size(187, 39);
            this.savePassB.TabIndex = 7;
            this.savePassB.Text = "Сохранить";
            this.savePassB.UseVisualStyleBackColor = false;
            this.savePassB.Click += new System.EventHandler(this.savePassB_Click);
            // 
            // toPassListB
            // 
            this.toPassListB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toPassListB.Location = new System.Drawing.Point(458, 225);
            this.toPassListB.Name = "toPassListB";
            this.toPassListB.Size = new System.Drawing.Size(101, 27);
            this.toPassListB.TabIndex = 8;
            this.toPassListB.Text = "Избранное";
            this.toPassListB.UseVisualStyleBackColor = false;
            this.toPassListB.Click += new System.EventHandler(this.toPassListB_Click);
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.Location = new System.Drawing.Point(30, 46);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(187, 26);
            this.loginTB.TabIndex = 9;
            // 
            // sameCB
            // 
            this.sameCB.AutoSize = true;
            this.sameCB.Location = new System.Drawing.Point(23, 153);
            this.sameCB.Name = "sameCB";
            this.sameCB.Size = new System.Drawing.Size(120, 17);
            this.sameCB.TabIndex = 10;
            this.sameCB.Text = "Похожие символы";
            this.sameCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Введите размер пароля:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.passLengthNUD);
            this.panel1.Controls.Add(this.symbolsCharCB);
            this.panel1.Controls.Add(this.sameCB);
            this.panel1.Controls.Add(this.lowerCharsCB);
            this.panel1.Controls.Add(this.upperCharsCB);
            this.panel1.Controls.Add(this.numbersCharsCB);
            this.panel1.Location = new System.Drawing.Point(361, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 188);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(30, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(571, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.toPassListB);
            this.Controls.Add(this.savePassB);
            this.Controls.Add(this.passGenerateB);
            this.Controls.Add(this.passwordTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.passLengthNUD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown passLengthNUD;
        private System.Windows.Forms.Button passGenerateB;
        private System.Windows.Forms.Button savePassB;
        private System.Windows.Forms.Button toPassListB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox passwordTB;
        public System.Windows.Forms.CheckBox lowerCharsCB;
        public System.Windows.Forms.CheckBox upperCharsCB;
        public System.Windows.Forms.CheckBox numbersCharsCB;
        public System.Windows.Forms.CheckBox symbolsCharCB;
        public System.Windows.Forms.CheckBox sameCB;
    }
}

