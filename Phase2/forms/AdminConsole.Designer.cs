namespace Phase2.forms
{
    partial class AdminConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminConsole));
            btnHome = new PictureBox();
            txtAdminInfo = new TextBox();
            btnCompleteAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(100, 120);
            btnHome.TabIndex = 9;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // txtAdminInfo
            // 
            txtAdminInfo.Location = new Point(270, 12);
            txtAdminInfo.Multiline = true;
            txtAdminInfo.Name = "txtAdminInfo";
            txtAdminInfo.ReadOnly = true;
            txtAdminInfo.Size = new Size(544, 120);
            txtAdminInfo.TabIndex = 10;
            // 
            // btnCompleteAdmin
            // 
            btnCompleteAdmin.Location = new Point(877, 467);
            btnCompleteAdmin.Name = "btnCompleteAdmin";
            btnCompleteAdmin.Size = new Size(149, 85);
            btnCompleteAdmin.TabIndex = 11;
            btnCompleteAdmin.Text = "End Admin Tree";
            btnCompleteAdmin.UseVisualStyleBackColor = true;
            btnCompleteAdmin.Click += btnCompleteAdmin_Click;
            // 
            // AdminConsole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 221, 203);
            ClientSize = new Size(1038, 564);
            Controls.Add(btnCompleteAdmin);
            Controls.Add(txtAdminInfo);
            Controls.Add(btnHome);
            Name = "AdminConsole";
            Text = "AdminConsole";
            Load += AdminConsole_Load;
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnHome;
        private TextBox txtAdminInfo;
        private Button btnCompleteAdmin;
    }
}