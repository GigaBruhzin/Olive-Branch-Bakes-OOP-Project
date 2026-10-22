namespace Phase2.forms
{
    partial class MenuItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItems));
            btnHome = new PictureBox();
            btnPlaceOrder = new Button();
            txtMenuItems = new TextBox();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(100, 120);
            btnHome.TabIndex = 8;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(799, 476);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(149, 85);
            btnPlaceOrder.TabIndex = 9;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // txtMenuItems
            // 
            txtMenuItems.Location = new Point(262, 164);
            txtMenuItems.Multiline = true;
            txtMenuItems.Name = "txtMenuItems";
            txtMenuItems.Size = new Size(410, 183);
            txtMenuItems.TabIndex = 10;
            // 
            // MenuItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 221, 203);
            ClientSize = new Size(960, 573);
            Controls.Add(txtMenuItems);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnHome);
            Name = "MenuItems";
            Text = "MenuItems";
            Load += MenuItems_Load;
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnHome;
        private Button btnPlaceOrder;
        private TextBox txtMenuItems;
    }
}