namespace MyPro
{
    partial class Dashboard1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBloodDonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donerToolStripMenuItem,
            this.searchBloodDonerToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.deleteDonerToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 68);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donerToolStripMenuItem
            // 
            this.donerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDonerToolStripMenuItem,
            this.updateDetailsToolStripMenuItem,
            this.showToolStripMenuItem});
            this.donerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donerToolStripMenuItem.Image")));
            this.donerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donerToolStripMenuItem.Name = "donerToolStripMenuItem";
            this.donerToolStripMenuItem.Size = new System.Drawing.Size(115, 64);
            this.donerToolStripMenuItem.Text = "Donor";
            // 
            // addNewDonerToolStripMenuItem
            // 
            this.addNewDonerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewDonerToolStripMenuItem.Image")));
            this.addNewDonerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewDonerToolStripMenuItem.Name = "addNewDonerToolStripMenuItem";
            this.addNewDonerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewDonerToolStripMenuItem.Text = "Add New Donor";
            this.addNewDonerToolStripMenuItem.Click += new System.EventHandler(this.addNewDonerToolStripMenuItem_Click);
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateDetailsToolStripMenuItem.Image")));
            this.updateDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.updateDetailsToolStripMenuItem.Text = "Update Details";
            this.updateDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDetailsToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showToolStripMenuItem.Image")));
            this.showToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.showToolStripMenuItem.Text = "All Donor Details";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // searchBloodDonerToolStripMenuItem
            // 
            this.searchBloodDonerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationToolStripMenuItem,
            this.bloodGroupToolStripMenuItem});
            this.searchBloodDonerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchBloodDonerToolStripMenuItem.Image")));
            this.searchBloodDonerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchBloodDonerToolStripMenuItem.Name = "searchBloodDonerToolStripMenuItem";
            this.searchBloodDonerToolStripMenuItem.Size = new System.Drawing.Size(207, 64);
            this.searchBloodDonerToolStripMenuItem.Text = "Search Blood Donor";
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("locationToolStripMenuItem.Image")));
            this.locationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // bloodGroupToolStripMenuItem
            // 
            this.bloodGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bloodGroupToolStripMenuItem.Image")));
            this.bloodGroupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            this.bloodGroupToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.bloodGroupToolStripMenuItem.Text = "Blood Group";
            this.bloodGroupToolStripMenuItem.Click += new System.EventHandler(this.bloodGroupToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inceToolStripMenuItem,
            this.decreaseToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.stockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockToolStripMenuItem.Image")));
            this.stockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(109, 64);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // inceToolStripMenuItem
            // 
            this.inceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inceToolStripMenuItem.Image")));
            this.inceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inceToolStripMenuItem.Name = "inceToolStripMenuItem";
            this.inceToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.inceToolStripMenuItem.Text = "Increase";
            this.inceToolStripMenuItem.Click += new System.EventHandler(this.inceToolStripMenuItem_Click);
            // 
            // decreaseToolStripMenuItem
            // 
            this.decreaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decreaseToolStripMenuItem.Image")));
            this.decreaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            this.decreaseToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.decreaseToolStripMenuItem.Text = "Decrease";
            this.decreaseToolStripMenuItem.Click += new System.EventHandler(this.decreaseToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detailsToolStripMenuItem.Image")));
            this.detailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // deleteDonerToolStripMenuItem
            // 
            this.deleteDonerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDonerToolStripMenuItem1});
            this.deleteDonerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonerToolStripMenuItem.Image")));
            this.deleteDonerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonerToolStripMenuItem.Name = "deleteDonerToolStripMenuItem";
            this.deleteDonerToolStripMenuItem.Size = new System.Drawing.Size(163, 64);
            this.deleteDonerToolStripMenuItem.Text = "Delete Donor";
            // 
            // deleteDonerToolStripMenuItem1
            // 
            this.deleteDonerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonerToolStripMenuItem1.Image")));
            this.deleteDonerToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonerToolStripMenuItem1.Name = "deleteDonerToolStripMenuItem1";
            this.deleteDonerToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.deleteDonerToolStripMenuItem1.Text = "Delete Donor";
            this.deleteDonerToolStripMenuItem1.Click += new System.EventHandler(this.deleteDonerToolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(130, 64);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnExit1
            // 
            this.btnExit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit1.Location = new System.Drawing.Point(1149, 13);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(37, 32);
            this.btnExit1.TabIndex = 4;
            this.btnExit1.Text = "X";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // Dashboard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 607);
            this.Controls.Add(this.btnExit1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard1";
            this.Text = "Dashboard1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBloodDonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonerToolStripMenuItem1;
        private System.Windows.Forms.Button btnExit1;
    }
}