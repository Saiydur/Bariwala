namespace Bariwala
{
    partial class FormTenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTenant));
            this.TabControlTenant = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageTenantShowAllFlat = new System.Windows.Forms.TabPage();
            this.tabPageTeantSearchFlat = new System.Windows.Forms.TabPage();
            this.tabPageTenantEnrollFlat = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TabControlTenant.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlTenant
            // 
            this.TabControlTenant.Controls.Add(this.tabPageTenantShowAllFlat);
            this.TabControlTenant.Controls.Add(this.tabPageTeantSearchFlat);
            this.TabControlTenant.Controls.Add(this.tabPageTenantEnrollFlat);
            this.TabControlTenant.Depth = 0;
            this.TabControlTenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlTenant.ImageList = this.imageList1;
            this.TabControlTenant.Location = new System.Drawing.Point(3, 59);
            this.TabControlTenant.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControlTenant.Multiline = true;
            this.TabControlTenant.Name = "TabControlTenant";
            this.TabControlTenant.SelectedIndex = 0;
            this.TabControlTenant.Size = new System.Drawing.Size(944, 543);
            this.TabControlTenant.TabIndex = 0;
            // 
            // tabPageTenantShowAllFlat
            // 
            this.tabPageTenantShowAllFlat.ImageKey = "outline_home_white_48dp.png";
            this.tabPageTenantShowAllFlat.Location = new System.Drawing.Point(4, 55);
            this.tabPageTenantShowAllFlat.Name = "tabPageTenantShowAllFlat";
            this.tabPageTenantShowAllFlat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTenantShowAllFlat.Size = new System.Drawing.Size(936, 484);
            this.tabPageTenantShowAllFlat.TabIndex = 0;
            this.tabPageTenantShowAllFlat.Text = "All Flats";
            this.tabPageTenantShowAllFlat.UseVisualStyleBackColor = true;
            // 
            // tabPageTeantSearchFlat
            // 
            this.tabPageTeantSearchFlat.ImageKey = "outline_manage_search_white_48dp.png";
            this.tabPageTeantSearchFlat.Location = new System.Drawing.Point(4, 55);
            this.tabPageTeantSearchFlat.Name = "tabPageTeantSearchFlat";
            this.tabPageTeantSearchFlat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeantSearchFlat.Size = new System.Drawing.Size(1135, 484);
            this.tabPageTeantSearchFlat.TabIndex = 1;
            this.tabPageTeantSearchFlat.Text = "Search Flat";
            this.tabPageTeantSearchFlat.UseVisualStyleBackColor = true;
            // 
            // tabPageTenantEnrollFlat
            // 
            this.tabPageTenantEnrollFlat.ImageKey = "outline_add_circle_outline_black_24dp.png";
            this.tabPageTenantEnrollFlat.Location = new System.Drawing.Point(4, 55);
            this.tabPageTenantEnrollFlat.Name = "tabPageTenantEnrollFlat";
            this.tabPageTenantEnrollFlat.Size = new System.Drawing.Size(1135, 484);
            this.tabPageTenantEnrollFlat.TabIndex = 2;
            this.tabPageTenantEnrollFlat.Text = "Assigned Flat";
            this.tabPageTenantEnrollFlat.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "outline_home_white_48dp.png");
            this.imageList1.Images.SetKeyName(1, "outline_manage_search_white_48dp.png");
            this.imageList1.Images.SetKeyName(2, "outline_add_circle_outline_black_24dp.png");
            // 
            // FormTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 605);
            this.Controls.Add(this.TabControlTenant);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControlTenant;
            this.DrawerUseColors = true;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormTenant";
            this.Padding = new System.Windows.Forms.Padding(3, 59, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTenant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTenant_FormClosing);
            this.TabControlTenant.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControlTenant;
        private System.Windows.Forms.TabPage tabPageTenantShowAllFlat;
        private System.Windows.Forms.TabPage tabPageTeantSearchFlat;
        private System.Windows.Forms.TabPage tabPageTenantEnrollFlat;
        private System.Windows.Forms.ImageList imageList1;
    }
}