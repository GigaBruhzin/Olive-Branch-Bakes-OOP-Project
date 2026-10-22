namespace Phase2.forms
{
    partial class CustomerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerProfile));
            btnHome = new PictureBox();
            btnGoToMenu = new Button();
            txtProfileInfo = new TextBox();
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
            // btnGoToMenu
            // 
            btnGoToMenu.Location = new Point(677, 398);
            btnGoToMenu.Name = "btnGoToMenu";
            btnGoToMenu.Size = new Size(149, 85);
            btnGoToMenu.TabIndex = 10;
            btnGoToMenu.Text = "Make an Order";
            btnGoToMenu.UseVisualStyleBackColor = true;
            btnGoToMenu.Click += btnGoToMenu_Click;
            // 
            // txtProfileInfo
            // 
            txtProfileInfo.Location = new Point(173, 140);
            txtProfileInfo.Multiline = true;
            txtProfileInfo.Name = "txtProfileInfo";
            txtProfileInfo.Size = new Size(198, 125);
            txtProfileInfo.TabIndex = 11;
            // 
            // CustomerProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 221, 203);
            ClientSize = new Size(838, 495);
            Controls.Add(txtProfileInfo);
            Controls.Add(btnGoToMenu);
            Controls.Add(btnHome);
            Name = "CustomerProfile";
            Text = "CustomerProfile";
            Load += CustomerProfile_Load;
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnHome;
        private Button btnGoToMenu;
        private TextBox txtProfileInfo;
    }
}