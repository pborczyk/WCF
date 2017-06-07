namespace TrainsClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceCityTextBox = new System.Windows.Forms.TextBox();
            this.targetCityTextBox = new System.Windows.Forms.TextBox();
            this.leavingTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.pathsTextBox = new System.Windows.Forms.TextBox();
            this.leavingTimeCheckbox = new System.Windows.Forms.CheckBox();
            this.arrivalTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miasto początkowe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miasto docelowe:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sourceCityTextBox
            // 
            this.sourceCityTextBox.Location = new System.Drawing.Point(118, 23);
            this.sourceCityTextBox.Name = "sourceCityTextBox";
            this.sourceCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.sourceCityTextBox.TabIndex = 2;
            // 
            // targetCityTextBox
            // 
            this.targetCityTextBox.Location = new System.Drawing.Point(118, 67);
            this.targetCityTextBox.Name = "targetCityTextBox";
            this.targetCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.targetCityTextBox.TabIndex = 3;
            // 
            // leavingTimePicker
            // 
            this.leavingTimePicker.Enabled = false;
            this.leavingTimePicker.Location = new System.Drawing.Point(438, 20);
            this.leavingTimePicker.Name = "leavingTimePicker";
            this.leavingTimePicker.Size = new System.Drawing.Size(200, 20);
            this.leavingTimePicker.TabIndex = 4;
            // 
            // arrivalTimePicker
            // 
            this.arrivalTimePicker.Enabled = false;
            this.arrivalTimePicker.Location = new System.Drawing.Point(438, 67);
            this.arrivalTimePicker.Name = "arrivalTimePicker";
            this.arrivalTimePicker.Size = new System.Drawing.Size(200, 20);
            this.arrivalTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Czas wyjazdu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Czas dojazdu:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(819, 402);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pathsTextBox
            // 
            this.pathsTextBox.Location = new System.Drawing.Point(16, 129);
            this.pathsTextBox.Multiline = true;
            this.pathsTextBox.Name = "pathsTextBox";
            this.pathsTextBox.ReadOnly = true;
            this.pathsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pathsTextBox.Size = new System.Drawing.Size(754, 296);
            this.pathsTextBox.TabIndex = 9;
            // 
            // leavingTimeCheckbox
            // 
            this.leavingTimeCheckbox.AutoSize = true;
            this.leavingTimeCheckbox.Location = new System.Drawing.Point(645, 21);
            this.leavingTimeCheckbox.Name = "leavingTimeCheckbox";
            this.leavingTimeCheckbox.Size = new System.Drawing.Size(15, 14);
            this.leavingTimeCheckbox.TabIndex = 10;
            this.leavingTimeCheckbox.UseVisualStyleBackColor = true;
            this.leavingTimeCheckbox.CheckedChanged += new System.EventHandler(this.leavingTimeCheckbox_CheckedChanged);
            // 
            // arrivalTimeCheckBox
            // 
            this.arrivalTimeCheckBox.AutoSize = true;
            this.arrivalTimeCheckBox.Location = new System.Drawing.Point(644, 69);
            this.arrivalTimeCheckBox.Name = "arrivalTimeCheckBox";
            this.arrivalTimeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.arrivalTimeCheckBox.TabIndex = 11;
            this.arrivalTimeCheckBox.UseVisualStyleBackColor = true;
            this.arrivalTimeCheckBox.CheckedChanged += new System.EventHandler(this.arrivalTimeCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 491);
            this.Controls.Add(this.arrivalTimeCheckBox);
            this.Controls.Add(this.leavingTimeCheckbox);
            this.Controls.Add(this.pathsTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrivalTimePicker);
            this.Controls.Add(this.leavingTimePicker);
            this.Controls.Add(this.targetCityTextBox);
            this.Controls.Add(this.sourceCityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sourceCityTextBox;
        private System.Windows.Forms.TextBox targetCityTextBox;
        private System.Windows.Forms.DateTimePicker leavingTimePicker;
        private System.Windows.Forms.DateTimePicker arrivalTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox pathsTextBox;
        private System.Windows.Forms.CheckBox leavingTimeCheckbox;
        private System.Windows.Forms.CheckBox arrivalTimeCheckBox;
    }
}

