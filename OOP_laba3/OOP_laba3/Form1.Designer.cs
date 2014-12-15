namespace OOP_laba3
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
            this.comboBoxObjects = new System.Windows.Forms.ComboBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.btnCreateObject = new System.Windows.Forms.Button();
            this.comboBoxTransports = new System.Windows.Forms.ComboBox();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnXml = new System.Windows.Forms.RadioButton();
            this.radioBtnSoap = new System.Windows.Forms.RadioButton();
            this.radioBtnBinary = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteObject = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnXmlDes = new System.Windows.Forms.RadioButton();
            this.radioBtnSoapDes = new System.Windows.Forms.RadioButton();
            this.radioBtnBinaryDes = new System.Windows.Forms.RadioButton();
            this.checkBoxSerializeList = new System.Windows.Forms.CheckBox();
            this.groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxObjects
            // 
            this.comboBoxObjects.FormattingEnabled = true;
            this.comboBoxObjects.Location = new System.Drawing.Point(3, 22);
            this.comboBoxObjects.Name = "comboBoxObjects";
            this.comboBoxObjects.Size = new System.Drawing.Size(121, 21);
            this.comboBoxObjects.TabIndex = 3;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(134, 4);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(329, 422);
            this.propertyGrid.TabIndex = 4;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.Location = new System.Drawing.Point(3, 49);
            this.btnCreateObject.Name = "btnCreateObject";
            this.btnCreateObject.Size = new System.Drawing.Size(121, 23);
            this.btnCreateObject.TabIndex = 5;
            this.btnCreateObject.Text = "Создать объект";
            this.btnCreateObject.UseVisualStyleBackColor = true;
            this.btnCreateObject.Click += new System.EventHandler(this.btnCreateObject_Click);
            // 
            // comboBoxTransports
            // 
            this.comboBoxTransports.FormattingEnabled = true;
            this.comboBoxTransports.Location = new System.Drawing.Point(2, 20);
            this.comboBoxTransports.Name = "comboBoxTransports";
            this.comboBoxTransports.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTransports.TabIndex = 6;
            this.comboBoxTransports.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransports_SelectedIndexChanged);
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(1, 75);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(121, 28);
            this.btnSerialize.TabIndex = 7;
            this.btnSerialize.Text = "Сериализовать";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(1, 1);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(124, 28);
            this.btnDeserialize.TabIndex = 8;
            this.btnDeserialize.Text = "Десериализовать";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Тип объекта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Список объектов:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.White;
            this.groupBox.Controls.Add(this.radioBtnXml);
            this.groupBox.Controls.Add(this.radioBtnSoap);
            this.groupBox.Controls.Add(this.radioBtnBinary);
            this.groupBox.Location = new System.Drawing.Point(1, 107);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(121, 100);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Тип сериализации:";
            // 
            // radioBtnXml
            // 
            this.radioBtnXml.AutoSize = true;
            this.radioBtnXml.Location = new System.Drawing.Point(9, 69);
            this.radioBtnXml.Name = "radioBtnXml";
            this.radioBtnXml.Size = new System.Drawing.Size(42, 17);
            this.radioBtnXml.TabIndex = 2;
            this.radioBtnXml.Text = "Xml";
            this.radioBtnXml.UseVisualStyleBackColor = true;
            // 
            // radioBtnSoap
            // 
            this.radioBtnSoap.AutoSize = true;
            this.radioBtnSoap.Location = new System.Drawing.Point(9, 46);
            this.radioBtnSoap.Name = "radioBtnSoap";
            this.radioBtnSoap.Size = new System.Drawing.Size(81, 17);
            this.radioBtnSoap.TabIndex = 1;
            this.radioBtnSoap.Text = "Текстовый";
            this.radioBtnSoap.UseVisualStyleBackColor = true;
            // 
            // radioBtnBinary
            // 
            this.radioBtnBinary.AutoSize = true;
            this.radioBtnBinary.Checked = true;
            this.radioBtnBinary.Location = new System.Drawing.Point(9, 23);
            this.radioBtnBinary.Name = "radioBtnBinary";
            this.radioBtnBinary.Size = new System.Drawing.Size(54, 17);
            this.radioBtnBinary.TabIndex = 0;
            this.radioBtnBinary.TabStop = true;
            this.radioBtnBinary.Text = "Binary";
            this.radioBtnBinary.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxSerializeList);
            this.panel1.Controls.Add(this.btnDeleteObject);
            this.panel1.Controls.Add(this.groupBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSerialize);
            this.panel1.Controls.Add(this.comboBoxTransports);
            this.panel1.Location = new System.Drawing.Point(5, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 211);
            this.panel1.TabIndex = 12;
            // 
            // btnDeleteObject
            // 
            this.btnDeleteObject.Location = new System.Drawing.Point(2, 43);
            this.btnDeleteObject.Name = "btnDeleteObject";
            this.btnDeleteObject.Size = new System.Drawing.Size(121, 28);
            this.btnDeleteObject.TabIndex = 12;
            this.btnDeleteObject.Text = "Удалить";
            this.btnDeleteObject.UseVisualStyleBackColor = true;
            this.btnDeleteObject.Click += new System.EventHandler(this.btnDeleteObject_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCreateObject);
            this.panel2.Controls.Add(this.comboBoxObjects);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 77);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDeserialize);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(5, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 125);
            this.panel3.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioBtnXmlDes);
            this.groupBox1.Controls.Add(this.radioBtnSoapDes);
            this.groupBox1.Controls.Add(this.radioBtnBinaryDes);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 90);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Десериализация:";
            // 
            // radioBtnXmlDes
            // 
            this.radioBtnXmlDes.AutoSize = true;
            this.radioBtnXmlDes.Location = new System.Drawing.Point(9, 65);
            this.radioBtnXmlDes.Name = "radioBtnXmlDes";
            this.radioBtnXmlDes.Size = new System.Drawing.Size(42, 17);
            this.radioBtnXmlDes.TabIndex = 2;
            this.radioBtnXmlDes.Text = "Xml";
            this.radioBtnXmlDes.UseVisualStyleBackColor = true;
            // 
            // radioBtnSoapDes
            // 
            this.radioBtnSoapDes.AutoSize = true;
            this.radioBtnSoapDes.Location = new System.Drawing.Point(9, 42);
            this.radioBtnSoapDes.Name = "radioBtnSoapDes";
            this.radioBtnSoapDes.Size = new System.Drawing.Size(81, 17);
            this.radioBtnSoapDes.TabIndex = 1;
            this.radioBtnSoapDes.Text = "Текстовый";
            this.radioBtnSoapDes.UseVisualStyleBackColor = true;
            // 
            // radioBtnBinaryDes
            // 
            this.radioBtnBinaryDes.AutoSize = true;
            this.radioBtnBinaryDes.Checked = true;
            this.radioBtnBinaryDes.Location = new System.Drawing.Point(9, 19);
            this.radioBtnBinaryDes.Name = "radioBtnBinaryDes";
            this.radioBtnBinaryDes.Size = new System.Drawing.Size(54, 17);
            this.radioBtnBinaryDes.TabIndex = 0;
            this.radioBtnBinaryDes.TabStop = true;
            this.radioBtnBinaryDes.Text = "Binary";
            this.radioBtnBinaryDes.UseVisualStyleBackColor = true;
            // 
            // checkBoxSerializeList
            // 
            this.checkBoxSerializeList.AutoSize = true;
            this.checkBoxSerializeList.Location = new System.Drawing.Point(105, 4);
            this.checkBoxSerializeList.Name = "checkBoxSerializeList";
            this.checkBoxSerializeList.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSerializeList.TabIndex = 13;
            this.checkBoxSerializeList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 430);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propertyGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сериализация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxObjects;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button btnCreateObject;
        private System.Windows.Forms.ComboBox comboBoxTransports;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioBtnXml;
        private System.Windows.Forms.RadioButton radioBtnSoap;
        private System.Windows.Forms.RadioButton radioBtnBinary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnXmlDes;
        private System.Windows.Forms.RadioButton radioBtnSoapDes;
        private System.Windows.Forms.RadioButton radioBtnBinaryDes;
        private System.Windows.Forms.Button btnDeleteObject;
        private System.Windows.Forms.CheckBox checkBoxSerializeList;
    }
}

