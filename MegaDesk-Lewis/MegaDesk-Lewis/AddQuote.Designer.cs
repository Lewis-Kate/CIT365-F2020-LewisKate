namespace MegaDesk_Lewis
{
    partial class AddQuote
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.Label();
            this.DeskWidth = new System.Windows.Forms.Label();
            this.widthtext = new System.Windows.Forms.TextBox();
            this.DeskDepth = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DeskDrawers = new System.Windows.Forms.Label();
            this.DrawersUpDown = new System.Windows.Forms.NumericUpDown();
            this.Material = new System.Windows.Forms.Label();
            this.RushDays = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.QuoteButton = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Button();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 40);
            this.textBox1.TabIndex = 0;
            // 
            // ClientName
            // 
            this.ClientName.BackColor = System.Drawing.Color.Black;
            this.ClientName.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.ForeColor = System.Drawing.Color.SpringGreen;
            this.ClientName.Location = new System.Drawing.Point(31, 28);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(126, 40);
            this.ClientName.TabIndex = 1;
            this.ClientName.Text = "Name";
            this.ClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeskWidth
            // 
            this.DeskWidth.BackColor = System.Drawing.Color.Black;
            this.DeskWidth.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidth.ForeColor = System.Drawing.Color.SpringGreen;
            this.DeskWidth.Location = new System.Drawing.Point(31, 80);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(126, 40);
            this.DeskWidth.TabIndex = 3;
            this.DeskWidth.Text = "Width";
            this.DeskWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeskWidth.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // widthtext
            // 
            this.widthtext.Location = new System.Drawing.Point(173, 92);
            this.widthtext.Name = "widthtext";
            this.widthtext.Size = new System.Drawing.Size(120, 22);
            this.widthtext.TabIndex = 2;
            // 
            // DeskDepth
            // 
            this.DeskDepth.BackColor = System.Drawing.Color.Black;
            this.DeskDepth.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepth.ForeColor = System.Drawing.Color.SpringGreen;
            this.DeskDepth.Location = new System.Drawing.Point(31, 136);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(126, 40);
            this.DeskDepth.TabIndex = 5;
            this.DeskDepth.Text = "Depth";
            this.DeskDepth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 4;
            // 
            // DeskDrawers
            // 
            this.DeskDrawers.BackColor = System.Drawing.Color.Black;
            this.DeskDrawers.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDrawers.ForeColor = System.Drawing.Color.SpringGreen;
            this.DeskDrawers.Location = new System.Drawing.Point(31, 194);
            this.DeskDrawers.Name = "DeskDrawers";
            this.DeskDrawers.Size = new System.Drawing.Size(126, 40);
            this.DeskDrawers.TabIndex = 6;
            this.DeskDrawers.Text = "Drawers";
            this.DeskDrawers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrawersUpDown
            // 
            this.DrawersUpDown.Location = new System.Drawing.Point(173, 207);
            this.DrawersUpDown.Name = "DrawersUpDown";
            this.DrawersUpDown.Size = new System.Drawing.Size(120, 22);
            this.DrawersUpDown.TabIndex = 7;
            this.DrawersUpDown.ValueChanged += new System.EventHandler(this.DrawersUpDown_ValueChanged);
            // 
            // Material
            // 
            this.Material.BackColor = System.Drawing.Color.Black;
            this.Material.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Material.ForeColor = System.Drawing.Color.SpringGreen;
            this.Material.Location = new System.Drawing.Point(31, 251);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(126, 40);
            this.Material.TabIndex = 8;
            this.Material.Text = "Material";
            this.Material.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RushDays
            // 
            this.RushDays.BackColor = System.Drawing.Color.Black;
            this.RushDays.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushDays.ForeColor = System.Drawing.Color.SpringGreen;
            this.RushDays.Location = new System.Drawing.Point(31, 310);
            this.RushDays.Name = "RushDays";
            this.RushDays.Size = new System.Drawing.Size(126, 40);
            this.RushDays.TabIndex = 9;
            this.RushDays.Text = "Shipping";
            this.RushDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 322);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox_SelectedIndexChanged);
            // 
            // HomeButton
            // 
            this.HomeButton.AutoSize = true;
            this.HomeButton.BackColor = System.Drawing.Color.Black;
            this.HomeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.HomeButton.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.HomeButton.Location = new System.Drawing.Point(417, 237);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(149, 38);
            this.HomeButton.TabIndex = 12;
            this.HomeButton.Text = "Main Menu";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // QuoteButton
            // 
            this.QuoteButton.AutoSize = true;
            this.QuoteButton.BackColor = System.Drawing.Color.Black;
            this.QuoteButton.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.QuoteButton.Location = new System.Drawing.Point(85, 386);
            this.QuoteButton.Name = "QuoteButton";
            this.QuoteButton.Size = new System.Drawing.Size(170, 38);
            this.QuoteButton.TabIndex = 13;
            this.QuoteButton.Text = "Submit Order";
            this.QuoteButton.UseVisualStyleBackColor = false;
            this.QuoteButton.Click += new System.EventHandler(this.QuoteButton_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.Black;
            this.Date.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Date.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.SpringGreen;
            this.Date.Location = new System.Drawing.Point(400, 137);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(166, 38);
            this.Date.TabIndex = 14;
            this.Date.UseVisualStyleBackColor = false;
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(173, 263);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(121, 24);
            this.MaterialComboBox.TabIndex = 15;
            this.MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox_SelectedIndexChanged);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.QuoteButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RushDays);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.DrawersUpDown);
            this.Controls.Add(this.DeskDrawers);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.widthtext);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.textBox1);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.DrawersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label DeskWidth;
        private System.Windows.Forms.TextBox widthtext;
        private System.Windows.Forms.Label DeskDepth;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label DeskDrawers;
        private System.Windows.Forms.NumericUpDown DrawersUpDown;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.Label RushDays;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button QuoteButton;
        private System.Windows.Forms.Button Date;
        private System.Windows.Forms.ComboBox MaterialComboBox;
    }
}