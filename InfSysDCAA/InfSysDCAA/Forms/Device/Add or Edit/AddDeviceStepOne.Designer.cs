namespace InfSysDCAA.Forms.DataBase.AddEditDeviceForms
{
    partial class DeviceStepOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceStepOne));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_serialnumber_field = new System.Windows.Forms.Label();
            this.label_inventnumber_field = new System.Windows.Forms.Label();
            this.field_descriptionDevice = new System.Windows.Forms.RichTextBox();
            this.descriptionDeviceGroupbox = new System.Windows.Forms.GroupBox();
            this.label_nameDevice_field = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.field_manufacturerDevice = new System.Windows.Forms.TextBox();
            this.label_manufacturerDevice_field = new System.Windows.Forms.Label();
            this.field_nameDevice = new System.Windows.Forms.TextBox();
            this.button_clear_deviceInfo = new System.Windows.Forms.Button();
            this.button_save_deviceInfo = new System.Windows.Forms.Button();
            this.field_inventnumberDevice = new System.Windows.Forms.TextBox();
            this.field_serialnumberDevice = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.descriptionDeviceGroupbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.field_serialnumberDevice);
            this.groupBox1.Controls.Add(this.field_inventnumberDevice);
            this.groupBox1.Controls.Add(this.label_serialnumber_field);
            this.groupBox1.Controls.Add(this.label_inventnumber_field);
            this.groupBox1.Location = new System.Drawing.Point(349, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Идентификаторы устройства";
            // 
            // label_serialnumber_field
            // 
            this.label_serialnumber_field.AutoSize = true;
            this.label_serialnumber_field.Location = new System.Drawing.Point(6, 48);
            this.label_serialnumber_field.Name = "label_serialnumber_field";
            this.label_serialnumber_field.Size = new System.Drawing.Size(93, 13);
            this.label_serialnumber_field.TabIndex = 2;
            this.label_serialnumber_field.Text = "Серийный номер";
            // 
            // label_inventnumber_field
            // 
            this.label_inventnumber_field.AutoSize = true;
            this.label_inventnumber_field.Location = new System.Drawing.Point(6, 22);
            this.label_inventnumber_field.Name = "label_inventnumber_field";
            this.label_inventnumber_field.Size = new System.Drawing.Size(111, 13);
            this.label_inventnumber_field.TabIndex = 0;
            this.label_inventnumber_field.Text = "Инвентарный номер";
            // 
            // field_descriptionDevice
            // 
            this.field_descriptionDevice.Location = new System.Drawing.Point(6, 19);
            this.field_descriptionDevice.Name = "field_descriptionDevice";
            this.field_descriptionDevice.Size = new System.Drawing.Size(547, 124);
            this.field_descriptionDevice.TabIndex = 5;
            this.field_descriptionDevice.Text = "";
            // 
            // descriptionDeviceGroupbox
            // 
            this.descriptionDeviceGroupbox.Controls.Add(this.field_descriptionDevice);
            this.descriptionDeviceGroupbox.Location = new System.Drawing.Point(12, 100);
            this.descriptionDeviceGroupbox.Name = "descriptionDeviceGroupbox";
            this.descriptionDeviceGroupbox.Size = new System.Drawing.Size(559, 149);
            this.descriptionDeviceGroupbox.TabIndex = 1;
            this.descriptionDeviceGroupbox.TabStop = false;
            this.descriptionDeviceGroupbox.Text = "Описание устройства";
            // 
            // label_nameDevice_field
            // 
            this.label_nameDevice_field.AutoSize = true;
            this.label_nameDevice_field.Location = new System.Drawing.Point(6, 23);
            this.label_nameDevice_field.Name = "label_nameDevice_field";
            this.label_nameDevice_field.Size = new System.Drawing.Size(57, 13);
            this.label_nameDevice_field.TabIndex = 6;
            this.label_nameDevice_field.Text = "Название";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.field_manufacturerDevice);
            this.groupBox2.Controls.Add(this.label_manufacturerDevice_field);
            this.groupBox2.Controls.Add(this.field_nameDevice);
            this.groupBox2.Controls.Add(this.label_nameDevice_field);
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 82);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о устройстве";
            // 
            // field_manufacturerDevice
            // 
            this.field_manufacturerDevice.Location = new System.Drawing.Point(123, 49);
            this.field_manufacturerDevice.Name = "field_manufacturerDevice";
            this.field_manufacturerDevice.Size = new System.Drawing.Size(206, 20);
            this.field_manufacturerDevice.TabIndex = 2;
            // 
            // label_manufacturerDevice_field
            // 
            this.label_manufacturerDevice_field.AutoSize = true;
            this.label_manufacturerDevice_field.Location = new System.Drawing.Point(6, 49);
            this.label_manufacturerDevice_field.Name = "label_manufacturerDevice_field";
            this.label_manufacturerDevice_field.Size = new System.Drawing.Size(86, 13);
            this.label_manufacturerDevice_field.TabIndex = 9;
            this.label_manufacturerDevice_field.Text = "Производитель";
            // 
            // field_nameDevice
            // 
            this.field_nameDevice.Location = new System.Drawing.Point(123, 23);
            this.field_nameDevice.Name = "field_nameDevice";
            this.field_nameDevice.Size = new System.Drawing.Size(206, 20);
            this.field_nameDevice.TabIndex = 1;
            // 
            // button_clear_deviceInfo
            // 
            this.button_clear_deviceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear_deviceInfo.Location = new System.Drawing.Point(577, 100);
            this.button_clear_deviceInfo.Name = "button_clear_deviceInfo";
            this.button_clear_deviceInfo.Size = new System.Drawing.Size(105, 44);
            this.button_clear_deviceInfo.TabIndex = 6;
            this.button_clear_deviceInfo.Text = "Сбросить";
            this.button_clear_deviceInfo.UseVisualStyleBackColor = true;
            this.button_clear_deviceInfo.Click += new System.EventHandler(this.button_clear_deviceInfo_Click);
            // 
            // button_save_deviceInfo
            // 
            this.button_save_deviceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save_deviceInfo.Location = new System.Drawing.Point(577, 150);
            this.button_save_deviceInfo.Name = "button_save_deviceInfo";
            this.button_save_deviceInfo.Size = new System.Drawing.Size(105, 99);
            this.button_save_deviceInfo.TabIndex = 7;
            this.button_save_deviceInfo.Text = "Добавить устройство";
            this.button_save_deviceInfo.UseVisualStyleBackColor = true;
            this.button_save_deviceInfo.Click += new System.EventHandler(this.button_save_deviceInfo_Click);
            // 
            // field_inventnumberDevice
            // 
            this.field_inventnumberDevice.Location = new System.Drawing.Point(117, 19);
            this.field_inventnumberDevice.Name = "field_inventnumberDevice";
            this.field_inventnumberDevice.Size = new System.Drawing.Size(206, 20);
            this.field_inventnumberDevice.TabIndex = 10;
            // 
            // field_serialnumberDevice
            // 
            this.field_serialnumberDevice.Location = new System.Drawing.Point(117, 45);
            this.field_serialnumberDevice.Name = "field_serialnumberDevice";
            this.field_serialnumberDevice.Size = new System.Drawing.Size(206, 20);
            this.field_serialnumberDevice.TabIndex = 11;
            // 
            // DeviceStepOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 261);
            this.Controls.Add(this.button_save_deviceInfo);
            this.Controls.Add(this.button_clear_deviceInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.descriptionDeviceGroupbox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeviceStepOne";
            this.Text = "DeviceStepOne";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.descriptionDeviceGroupbox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_serialnumber_field;
        private System.Windows.Forms.Label label_inventnumber_field;
        private System.Windows.Forms.RichTextBox field_descriptionDevice;
        private System.Windows.Forms.GroupBox descriptionDeviceGroupbox;
        private System.Windows.Forms.Label label_nameDevice_field;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox field_manufacturerDevice;
        private System.Windows.Forms.Label label_manufacturerDevice_field;
        private System.Windows.Forms.TextBox field_nameDevice;
        private System.Windows.Forms.Button button_clear_deviceInfo;
        private System.Windows.Forms.Button button_save_deviceInfo;
        private System.Windows.Forms.TextBox field_serialnumberDevice;
        private System.Windows.Forms.TextBox field_inventnumberDevice;
    }
}