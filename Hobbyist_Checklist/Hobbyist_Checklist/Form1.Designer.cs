namespace Hobbyist_Checklist
{
    partial class HobbyList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListViewPanel = new System.Windows.Forms.Panel();
            this.listView1 = new Hobbyist_Checklist.ListView();
            this.panel1.SuspendLayout();
            this.ListViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 591);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(183, 100);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 491);
            this.vScrollBar1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // ListViewPanel
            // 
            this.ListViewPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ListViewPanel.Controls.Add(this.listView1);
            this.ListViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewPanel.Location = new System.Drawing.Point(200, 0);
            this.ListViewPanel.Name = "ListViewPanel";
            this.ListViewPanel.Size = new System.Drawing.Size(905, 591);
            this.ListViewPanel.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Location = new System.Drawing.Point(6, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(583, 98);
            this.listView1.TabIndex = 0;
            // 
            // HobbyList
            // 
            this.AccessibleName = "HobbyList";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1105, 591);
            this.Controls.Add(this.ListViewPanel);
            this.Controls.Add(this.panel1);
            this.Name = "HobbyList";
            this.Text = "HobbyList";
            this.panel1.ResumeLayout(false);
            this.ListViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel ListViewPanel;
        private Button button1;
        private VScrollBar vScrollBar1;
        private Panel panel3;
        private ListView listView1;
    }
}