namespace OOTPiSP_3
{
    partial class Serialiser
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
            this.button_AddObject = new System.Windows.Forms.Button();
            this.listBox_Objects = new System.Windows.Forms.ListBox();
            this.radioButton_BMX = new System.Windows.Forms.RadioButton();
            this.radioButton_CityBike = new System.Windows.Forms.RadioButton();
            this.radioButton_Hybrid = new System.Windows.Forms.RadioButton();
            this.radioButton_MTB = new System.Windows.Forms.RadioButton();
            this.radioButton_KidsBike = new System.Windows.Forms.RadioButton();
            this.radioButton_RoadBike = new System.Windows.Forms.RadioButton();
            this.button_Deserialise = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Serialise
            // 
            this.button_Serialise.Location = new System.Drawing.Point(340, 282);
            this.button_Serialise.Name = "button_Serialise";
            this.button_Serialise.Size = new System.Drawing.Size(123, 30);
            this.button_Serialise.TabIndex = 0;
            this.button_Serialise.Text = "Serialise all objects";
            this.button_Serialise.UseVisualStyleBackColor = true;
            this.button_Serialise.Click += new System.EventHandler(this.buttonSerialise_Click);
            // 
            // button_AddObject
            // 
            this.button_AddObject.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AddObject.Location = new System.Drawing.Point(111, 289);
            this.button_AddObject.Name = "button_AddObject";
            this.button_AddObject.Size = new System.Drawing.Size(117, 23);
            this.button_AddObject.TabIndex = 2;
            this.button_AddObject.Text = "Add object to list";
            this.button_AddObject.UseVisualStyleBackColor = true;
            this.button_AddObject.Click += new System.EventHandler(this.button_AddObject_Click);
            // 
            // listBox_Objects
            // 
            this.listBox_Objects.FormattingEnabled = true;
            this.listBox_Objects.Location = new System.Drawing.Point(340, 3);
            this.listBox_Objects.Name = "listBox_Objects";
            this.listBox_Objects.Size = new System.Drawing.Size(123, 134);
            this.listBox_Objects.TabIndex = 4;
            this.listBox_Objects.SelectedIndexChanged += new System.EventHandler(this.listBox_Objects_SelectedIndexChanged);
            // 
            // radioButton_BMX
            // 
            this.radioButton_BMX.AutoSize = true;
            this.radioButton_BMX.Checked = true;
            this.radioButton_BMX.Location = new System.Drawing.Point(75, 40);
            this.radioButton_BMX.Name = "radioButton_BMX";
            this.radioButton_BMX.Size = new System.Drawing.Size(48, 17);
            this.radioButton_BMX.TabIndex = 5;
            this.radioButton_BMX.TabStop = true;
            this.radioButton_BMX.Text = "BMX";
            this.radioButton_BMX.UseVisualStyleBackColor = true;
            this.radioButton_BMX.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton_CityBike
            // 
            this.radioButton_CityBike.AutoSize = true;
            this.radioButton_CityBike.Location = new System.Drawing.Point(130, 40);
            this.radioButton_CityBike.Name = "radioButton_CityBike";
            this.radioButton_CityBike.Size = new System.Drawing.Size(63, 17);
            this.radioButton_CityBike.TabIndex = 6;
            this.radioButton_CityBike.Text = "CityBike";
            this.radioButton_CityBike.UseVisualStyleBackColor = true;
            this.radioButton_CityBike.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton_Hybrid
            // 
            this.radioButton_Hybrid.AutoSize = true;
            this.radioButton_Hybrid.Location = new System.Drawing.Point(200, 40);
            this.radioButton_Hybrid.Name = "radioButton_Hybrid";
            this.radioButton_Hybrid.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Hybrid.TabIndex = 7;
            this.radioButton_Hybrid.Text = "Hybrid";
            this.radioButton_Hybrid.UseVisualStyleBackColor = true;
            this.radioButton_Hybrid.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton_MTB
            // 
            this.radioButton_MTB.AutoSize = true;
            this.radioButton_MTB.Location = new System.Drawing.Point(75, 69);
            this.radioButton_MTB.Name = "radioButton_MTB";
            this.radioButton_MTB.Size = new System.Drawing.Size(48, 17);
            this.radioButton_MTB.TabIndex = 8;
            this.radioButton_MTB.Text = "MTB";
            this.radioButton_MTB.UseVisualStyleBackColor = true;
            this.radioButton_MTB.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton_KidsBike
            // 
            this.radioButton_KidsBike.AutoSize = true;
            this.radioButton_KidsBike.Location = new System.Drawing.Point(130, 69);
            this.radioButton_KidsBike.Name = "radioButton_KidsBike";
            this.radioButton_KidsBike.Size = new System.Drawing.Size(66, 17);
            this.radioButton_KidsBike.TabIndex = 9;
            this.radioButton_KidsBike.Text = "KidsBike";
            this.radioButton_KidsBike.UseVisualStyleBackColor = true;
            this.radioButton_KidsBike.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton_RoadBike
            // 
            this.radioButton_RoadBike.AutoSize = true;
            this.radioButton_RoadBike.Location = new System.Drawing.Point(200, 69);
            this.radioButton_RoadBike.Name = "radioButton_RoadBike";
            this.radioButton_RoadBike.Size = new System.Drawing.Size(72, 17);
            this.radioButton_RoadBike.TabIndex = 10;
            this.radioButton_RoadBike.Text = "RoadBike";
            this.radioButton_RoadBike.UseVisualStyleBackColor = true;
            this.radioButton_RoadBike.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // button_Deserialise
            // 
            this.button_Deserialise.Location = new System.Drawing.Point(469, 282);
            this.button_Deserialise.Name = "button_Deserialise";
            this.button_Deserialise.Size = new System.Drawing.Size(123, 30);
            this.button_Deserialise.TabIndex = 11;
            this.button_Deserialise.Text = "Deserialise all objects";
            this.button_Deserialise.UseVisualStyleBackColor = true;
            this.button_Deserialise.Click += new System.EventHandler(this.buttonDeserialise_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(340, 166);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(123, 23);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Visible = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Serialiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 351);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Deserialise);
            this.Controls.Add(this.radioButton_RoadBike);
            this.Controls.Add(this.radioButton_KidsBike);
            this.Controls.Add(this.radioButton_MTB);
            this.Controls.Add(this.radioButton_Hybrid);
            this.Controls.Add(this.radioButton_CityBike);
            this.Controls.Add(this.radioButton_BMX);
            this.Controls.Add(this.listBox_Objects);
            this.Controls.Add(this.button_AddObject);
            this.Controls.Add(this.button_Serialise);
            this.Name = "Serialiser";
            this.Text = "Serialiser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Serialise;
        private System.Windows.Forms.Button button_AddObject;
        private System.Windows.Forms.ListBox listBox_Objects;
        private System.Windows.Forms.RadioButton radioButton_BMX;
        private System.Windows.Forms.RadioButton radioButton_CityBike;
        private System.Windows.Forms.RadioButton radioButton_Hybrid;
        private System.Windows.Forms.RadioButton radioButton_MTB;
        private System.Windows.Forms.RadioButton radioButton_KidsBike;
        private System.Windows.Forms.RadioButton radioButton_RoadBike;
        private System.Windows.Forms.Button button_Deserialise;
        private System.Windows.Forms.Button button_Save;
    }
}

