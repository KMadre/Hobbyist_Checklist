namespace Hobbyist_Checklist
{
    partial class ListView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.PictureBox();
            this.OwnedBox = new System.Windows.Forms.CheckBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(142, 2);
            this.NameLabel.MaximumSize = new System.Drawing.Size(350, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Test";
            // 
            // Image
            // 
            this.Image.Image = global::Hobbyist_Checklist.Properties.Resources.image;
            this.Image.Location = new System.Drawing.Point(2, 2);
            this.Image.MaximumSize = new System.Drawing.Size(95, 93);
            this.Image.MinimumSize = new System.Drawing.Size(95, 93);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(95, 93);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image.TabIndex = 1;
            this.Image.TabStop = false;
            // 
            // OwnedBox
            // 
            this.OwnedBox.AutoSize = true;
            this.OwnedBox.Location = new System.Drawing.Point(516, 5);
            this.OwnedBox.Name = "OwnedBox";
            this.OwnedBox.Size = new System.Drawing.Size(64, 19);
            this.OwnedBox.TabIndex = 2;
            this.OwnedBox.Text = "Owned";
            this.OwnedBox.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(508, 30);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(142, 22);
            this.CurrencyLabel.MaximumSize = new System.Drawing.Size(350, 18);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(55, 15);
            this.CurrencyLabel.TabIndex = 4;
            this.CurrencyLabel.Text = "Currency";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(142, 80);
            this.DateLabel.MaximumSize = new System.Drawing.Size(100, 18);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(31, 15);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "Date";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(103, 6);
            this.IDLabel.MaximumSize = new System.Drawing.Size(45, 18);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 15);
            this.IDLabel.TabIndex = 6;
            this.IDLabel.Text = "ID";
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.OwnedBox);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.NameLabel);
            this.Name = "ListView";
            this.Size = new System.Drawing.Size(581, 96);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabel;
        private PictureBox Image;
        private CheckBox OwnedBox;
        private Button EditButton;
        private Label CurrencyLabel;
        private Label DateLabel;
        private Label IDLabel;
    }
}
