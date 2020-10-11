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
            this.ClientName = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DeskWidthLabel = new System.Windows.Forms.Label();
            this.DeskWidth = new System.Windows.Forms.TextBox();
            this.DeskDepthLabel = new System.Windows.Forms.Label();
            this.DeskDepth = new System.Windows.Forms.TextBox();
            this.DeskDrawersLabel = new System.Windows.Forms.Label();
            this.DeskDrawers = new System.Windows.Forms.NumericUpDown();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.ShippingLabel = new System.Windows.Forms.Label();
            this.RushDays = new System.Windows.Forms.ComboBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.QuoteButton = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Button();
            this.Material = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(173, 28);
            this.ClientName.Multiline = true;
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(120, 40);
            this.ClientName.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.Black;
            this.NameLabel.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.NameLabel.Location = new System.Drawing.Point(31, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(126, 40);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeskWidthLabel
            // 
            this.DeskWidthLabel.BackColor = System.Drawing.Color.Black;
            this.DeskWidthLabel.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.DeskWidthLabel.Location = new System.Drawing.Point(31, 80);
            this.DeskWidthLabel.Name = "DeskWidthLabel";
            this.DeskWidthLabel.Size = new System.Drawing.Size(126, 40);
            this.DeskWidthLabel.TabIndex = 3;
            this.DeskWidthLabel.Text = "Width";
            this.DeskWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeskWidthLabel.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // DeskWidth
            // 
            this.DeskWidth.Location = new System.Drawing.Point(173, 92);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(120, 22);
            this.DeskWidth.TabIndex = 2;
            // 
            // DeskDepthLabel
            // 
            this.DeskDepthLabel.BackColor = System.Drawing.Color.Black;
            this.DeskDepthLabel.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.DeskDepthLabel.Location = new System.Drawing.Point(31, 136);
            this.DeskDepthLabel.Name = "DeskDepthLabel";
            this.DeskDepthLabel.Size = new System.Drawing.Size(126, 40);
            this.DeskDepthLabel.TabIndex = 5;
            this.DeskDepthLabel.Text = "Depth";
            this.DeskDepthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeskDepth
            // 
            this.DeskDepth.Location = new System.Drawing.Point(173, 148);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(120, 22);
            this.DeskDepth.TabIndex = 4;
            // 
            // DeskDrawersLabel
            // 
            this.DeskDrawersLabel.BackColor = System.Drawing.Color.Black;
            this.DeskDrawersLabel.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDrawersLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.DeskDrawersLabel.Location = new System.Drawing.Point(31, 194);
            this.DeskDrawersLabel.Name = "DeskDrawersLabel";
            this.DeskDrawersLabel.Size = new System.Drawing.Size(126, 40);
            this.DeskDrawersLabel.TabIndex = 6;
            this.DeskDrawersLabel.Text = "Drawers";
            this.DeskDrawersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeskDrawers
            // 
            this.DeskDrawers.Location = new System.Drawing.Point(173, 207);
            this.DeskDrawers.Name = "DeskDrawers";
            this.DeskDrawers.Size = new System.Drawing.Size(120, 22);
            this.DeskDrawers.TabIndex = 7;
            this.DeskDrawers.ValueChanged += new System.EventHandler(this.DeskDrawers_ValueChanged);
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.BackColor = System.Drawing.Color.Black;
            this.MaterialLabel.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.MaterialLabel.Location = new System.Drawing.Point(31, 251);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(126, 40);
            this.MaterialLabel.TabIndex = 8;
            this.MaterialLabel.Text = "Material";
            this.MaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShippingLabel
            // 
            this.ShippingLabel.BackColor = System.Drawing.Color.Black;
            this.ShippingLabel.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.ShippingLabel.Location = new System.Drawing.Point(31, 310);
            this.ShippingLabel.Name = "ShippingLabel";
            this.ShippingLabel.Size = new System.Drawing.Size(126, 40);
            this.ShippingLabel.TabIndex = 9;
            this.ShippingLabel.Text = "Shipping";
            this.ShippingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RushDays
            // 
            this.RushDays.FormattingEnabled = true;
            this.RushDays.Location = new System.Drawing.Point(172, 322);
            this.RushDays.Name = "RushDays";
            this.RushDays.Size = new System.Drawing.Size(121, 24);
            this.RushDays.TabIndex = 11;
            this.RushDays.SelectedIndexChanged += new System.EventHandler(this.Material_SelectedIndexChanged);
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
            this.QuoteButton.Enabled = true;
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
            // Material
            // 
            this.Material.FormattingEnabled = true;
            this.Material.Location = new System.Drawing.Point(173, 263);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(121, 24);
            this.Material.TabIndex = 15;
            this.Material.SelectedIndexChanged += new System.EventHandler(this.Material_SelectedIndexChanged);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Material);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.QuoteButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.RushDays);
            this.Controls.Add(this.ShippingLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.DeskDrawers);
            this.Controls.Add(this.DeskDrawersLabel);
            this.Controls.Add(this.DeskDepthLabel);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.DeskWidthLabel);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ClientName);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.DeskDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DeskWidthLabel;
        private System.Windows.Forms.TextBox DeskWidth;
        private System.Windows.Forms.Label DeskDepthLabel;
        private System.Windows.Forms.TextBox DeskDepth;
        private System.Windows.Forms.Label DeskDrawersLabel;
        private System.Windows.Forms.NumericUpDown DeskDrawers;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label ShippingLabel;
        private System.Windows.Forms.ComboBox RushDays;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button QuoteButton;
        private System.Windows.Forms.Button Date;
        private System.Windows.Forms.ComboBox Material;
    }
}