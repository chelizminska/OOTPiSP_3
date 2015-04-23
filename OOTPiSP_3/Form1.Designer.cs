namespace OOTPiSP_3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Serialise = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_AddObject = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox_Objects = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Serialise
            // 
            this.button_Serialise.Location = new System.Drawing.Point(297, 197);
            this.button_Serialise.Name = "button_Serialise";
            this.button_Serialise.Size = new System.Drawing.Size(123, 30);
            this.button_Serialise.TabIndex = 0;
            this.button_Serialise.Text = "Serialise all objects";
            this.button_Serialise.UseVisualStyleBackColor = true;
            this.button_Serialise.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button_AddObject
            // 
            this.button_AddObject.Location = new System.Drawing.Point(75, 168);
            this.button_AddObject.Name = "button_AddObject";
            this.button_AddObject.Size = new System.Drawing.Size(121, 23);
            this.button_AddObject.TabIndex = 2;
            this.button_AddObject.Text = "Add object to list";
            this.button_AddObject.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // listBox_Objects
            // 
            this.listBox_Objects.FormattingEnabled = true;
            this.listBox_Objects.Location = new System.Drawing.Point(487, 69);
            this.listBox_Objects.Name = "listBox_Objects";
            this.listBox_Objects.Size = new System.Drawing.Size(120, 95);
            this.listBox_Objects.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 351);
            this.Controls.Add(this.listBox_Objects);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_AddObject);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Serialise);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Serialise;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_AddObject;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox_Objects;
    }
}

