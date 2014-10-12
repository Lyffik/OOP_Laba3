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
            this.SuspendLayout();
            // 
            // comboBoxObjects
            // 
            this.comboBoxObjects.FormattingEnabled = true;
            this.comboBoxObjects.Location = new System.Drawing.Point(703, 33);
            this.comboBoxObjects.Name = "comboBoxObjects";
            this.comboBoxObjects.Size = new System.Drawing.Size(121, 21);
            this.comboBoxObjects.TabIndex = 3;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(49, 124);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(324, 373);
            this.propertyGrid.TabIndex = 4;
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.Location = new System.Drawing.Point(703, 74);
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
            this.comboBoxTransports.Location = new System.Drawing.Point(498, 33);
            this.comboBoxTransports.Name = "comboBoxTransports";
            this.comboBoxTransports.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTransports.TabIndex = 6;
            this.comboBoxTransports.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransports_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 530);
            this.Controls.Add(this.comboBoxTransports);
            this.Controls.Add(this.btnCreateObject);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.comboBoxObjects);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxObjects;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button btnCreateObject;
        private System.Windows.Forms.ComboBox comboBoxTransports;
    }
}

