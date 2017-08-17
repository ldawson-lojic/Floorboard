namespace LojicFloorboard_FormsApp
{
    partial class PointsPrompt
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.LatiLabel = new System.Windows.Forms.Label();
            this.LatValue = new System.Windows.Forms.Label();
            this.LongValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LongLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(169, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LatiLabel
            // 
            this.LatiLabel.AutoSize = true;
            this.LatiLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatiLabel.Location = new System.Drawing.Point(27, 36);
            this.LatiLabel.Name = "LatiLabel";
            this.LatiLabel.Padding = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.LatiLabel.Size = new System.Drawing.Size(84, 33);
            this.LatiLabel.TabIndex = 2;
            this.LatiLabel.Text = "Latitude:";
            // 
            // LatValue
            // 
            this.LatValue.AutoSize = true;
            this.LatValue.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatValue.Location = new System.Drawing.Point(117, 36);
            this.LatValue.Name = "LatValue";
            this.LatValue.Padding = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.LatValue.Size = new System.Drawing.Size(37, 33);
            this.LatValue.TabIndex = 6;
            this.LatValue.Text = "Lat";
            // 
            // LongValue
            // 
            this.LongValue.AutoSize = true;
            this.LongValue.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongValue.Location = new System.Drawing.Point(117, 9);
            this.LongValue.Name = "LongValue";
            this.LongValue.Padding = new System.Windows.Forms.Padding(3);
            this.LongValue.Size = new System.Drawing.Size(51, 27);
            this.LongValue.TabIndex = 5;
            this.LongValue.Text = "Long";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 68);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.label3.Size = new System.Drawing.Size(66, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // LongLabel
            // 
            this.LongLabel.AutoSize = true;
            this.LongLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongLabel.Location = new System.Drawing.Point(12, 9);
            this.LongLabel.Name = "LongLabel";
            this.LongLabel.Padding = new System.Windows.Forms.Padding(3);
            this.LongLabel.Size = new System.Drawing.Size(99, 27);
            this.LongLabel.TabIndex = 1;
            this.LongLabel.Text = "Longitude:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 29);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 101);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.label1.Size = new System.Drawing.Size(57, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Person",
            "Package",
            "Part"});
            this.comboBox1.Location = new System.Drawing.Point(121, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 29);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style";
            // 
            // PointsPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(265, 190);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LatValue);
            this.Controls.Add(this.LongValue);
            this.Controls.Add(this.LongLabel);
            this.Controls.Add(this.LatiLabel);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PointsPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PointsPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LatiLabel;
        private System.Windows.Forms.Label LatValue;
        private System.Windows.Forms.Label LongValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LongLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}