
namespace Baryshev16LabaSProg
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(324, 173);
            this.listBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = " Создание уникального идентификатора ресурсов ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Извлечение информации из веб-адреса";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = " Получение DNS-имени компьютера \r\n\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "Получение NETBIOS-имени компьютера \r\n\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(142, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 65);
            this.button5.TabIndex = 5;
            this.button5.Text = "Получение IP-адреса локальной машины\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(272, 263);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 65);
            this.button6.TabIndex = 6;
            this.button6.Text = "Пинг адресов \r\n";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(342, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 65);
            this.button7.TabIndex = 7;
            this.button7.Text = "Проверка доступности адреса в Интернете\r\n";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 64);
            this.textBox1.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(342, 83);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 65);
            this.button8.TabIndex = 9;
            this.button8.Text = "Посыла запроса серверу и обработка ответа\r\n";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 333);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 65);
            this.button9.TabIndex = 10;
            this.button9.Text = "Закачка файла из Интернета \r\n";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(142, 333);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(124, 65);
            this.button10.TabIndex = 11;
            this.button10.Text = "Закачка файла на FTP-сервер";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(272, 333);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(124, 65);
            this.button11.TabIndex = 12;
            this.button11.Text = " Получение списка файлов\r\n";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 404);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(124, 65);
            this.button12.TabIndex = 13;
            this.button12.Text = "Загрузка файла на локальный компьютер \r\n";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(143, 404);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(124, 65);
            this.button13.TabIndex = 14;
            this.button13.Text = "Посылаем письмо через SMTP \r\n";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(473, 84);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(294, 64);
            this.txtSubject.TabIndex = 15;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(473, 154);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(294, 64);
            this.txtBody.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 545);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
    }
}

