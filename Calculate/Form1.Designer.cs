namespace Calculate
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttonminus = new System.Windows.Forms.Button();
            this.buttonumn = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            this.buttonsquare = new System.Windows.Forms.Button();
            this.buttonpow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(235, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // buttonplus
            // 
            this.buttonplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonplus.Location = new System.Drawing.Point(22, 85);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(75, 23);
            this.buttonplus.TabIndex = 3;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.buttonplus_Click);
            // 
            // buttonminus
            // 
            this.buttonminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonminus.Location = new System.Drawing.Point(119, 85);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(75, 23);
            this.buttonminus.TabIndex = 4;
            this.buttonminus.Text = "-";
            this.buttonminus.UseVisualStyleBackColor = true;
            this.buttonminus.Click += new System.EventHandler(this.buttonminus_Click);
            // 
            // buttonumn
            // 
            this.buttonumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonumn.Location = new System.Drawing.Point(217, 85);
            this.buttonumn.Name = "buttonumn";
            this.buttonumn.Size = new System.Drawing.Size(75, 23);
            this.buttonumn.TabIndex = 5;
            this.buttonumn.Text = "*";
            this.buttonumn.UseVisualStyleBackColor = true;
            this.buttonumn.Click += new System.EventHandler(this.buttonumn_Click);
            // 
            // buttondel
            // 
            this.buttondel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttondel.Location = new System.Drawing.Point(22, 114);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(75, 23);
            this.buttondel.TabIndex = 6;
            this.buttondel.Text = "/";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // buttonsquare
            // 
            this.buttonsquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonsquare.Location = new System.Drawing.Point(119, 114);
            this.buttonsquare.Name = "buttonsquare";
            this.buttonsquare.Size = new System.Drawing.Size(75, 23);
            this.buttonsquare.TabIndex = 7;
            this.buttonsquare.Text = "x^2";
            this.buttonsquare.UseVisualStyleBackColor = true;
            this.buttonsquare.Click += new System.EventHandler(this.buttonsquare_Click);
            // 
            // buttonpow
            // 
            this.buttonpow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonpow.Location = new System.Drawing.Point(217, 114);
            this.buttonpow.Name = "buttonpow";
            this.buttonpow.Size = new System.Drawing.Size(75, 23);
            this.buttonpow.TabIndex = 8;
            this.buttonpow.Text = "^";
            this.buttonpow.UseVisualStyleBackColor = true;
            this.buttonpow.Click += new System.EventHandler(this.buttonpow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Первый аргумент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Второй аргумент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 231);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonpow);
            this.Controls.Add(this.buttonsquare);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.buttonumn);
            this.Controls.Add(this.buttonminus);
            this.Controls.Add(this.buttonplus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button buttonumn;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Button buttonsquare;
        private System.Windows.Forms.Button buttonpow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

