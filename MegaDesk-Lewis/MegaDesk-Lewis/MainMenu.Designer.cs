namespace MegaDesk_Lewis
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.NewQuoteButton = new System.Windows.Forms.Button();
            this.ViewQuoteButton = new System.Windows.Forms.Button();
            this.SearchQuoteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewQuoteButton
            // 
            this.NewQuoteButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.NewQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NewQuoteButton.FlatAppearance.BorderSize = 0;
            this.NewQuoteButton.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewQuoteButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.NewQuoteButton.Location = new System.Drawing.Point(43, 49);
            this.NewQuoteButton.Name = "NewQuoteButton";
            this.NewQuoteButton.Size = new System.Drawing.Size(224, 81);
            this.NewQuoteButton.TabIndex = 0;
            this.NewQuoteButton.Text = "Add New Quote";
            this.NewQuoteButton.UseVisualStyleBackColor = false;
            this.NewQuoteButton.Click += new System.EventHandler(this.NewQuoteButton_Click);
            // 
            // ViewQuoteButton
            // 
            this.ViewQuoteButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ViewQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ViewQuoteButton.FlatAppearance.BorderSize = 0;
            this.ViewQuoteButton.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuoteButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.ViewQuoteButton.Location = new System.Drawing.Point(43, 325);
            this.ViewQuoteButton.Name = "ViewQuoteButton";
            this.ViewQuoteButton.Size = new System.Drawing.Size(224, 81);
            this.ViewQuoteButton.TabIndex = 1;
            this.ViewQuoteButton.Text = "View Quotes";
            this.ViewQuoteButton.UseVisualStyleBackColor = false;
            this.ViewQuoteButton.Click += new System.EventHandler(this.ViewQuoteButton_Click);
            // 
            // SearchQuoteButton
            // 
            this.SearchQuoteButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.SearchQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SearchQuoteButton.FlatAppearance.BorderSize = 0;
            this.SearchQuoteButton.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuoteButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.SearchQuoteButton.Location = new System.Drawing.Point(289, 325);
            this.SearchQuoteButton.Name = "SearchQuoteButton";
            this.SearchQuoteButton.Size = new System.Drawing.Size(224, 81);
            this.SearchQuoteButton.TabIndex = 2;
            this.SearchQuoteButton.Text = "Search Quotes";
            this.SearchQuoteButton.UseVisualStyleBackColor = false;
            this.SearchQuoteButton.Click += new System.EventHandler(this.SearchQuoteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.ExitButton.Location = new System.Drawing.Point(541, 325);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(224, 81);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(303, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchQuoteButton);
            this.Controls.Add(this.ViewQuoteButton);
            this.Controls.Add(this.NewQuoteButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewQuoteButton;
        private System.Windows.Forms.Button ViewQuoteButton;
        private System.Windows.Forms.Button SearchQuoteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

