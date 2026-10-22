namespace Phase2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnAdmin = new Button();
            txtLogin = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            btnOrder = new Button();
            btnHome = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.OliveDrab;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.ForeColor = Color.LightGoldenrodYellow;
            btnAdmin.Location = new Point(145, 276);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(181, 56);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Continue To Admin Tree";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(145, 181);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(181, 23);
            txtLogin.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(145, 229);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(181, 23);
            txtPass.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 184);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 232);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PaleGoldenrod;
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(145, 338);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(181, 56);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Continue To Customer Tree";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(145, 400);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(181, 56);
            btnOrder.TabIndex = 6;
            btnOrder.Text = "Order as Guest";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(189, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(100, 120);
            btnHome.TabIndex = 7;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 135);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 8;
            label3.Text = "placeholder logo";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 221, 203);
            ClientSize = new Size(490, 481);
            Controls.Add(label3);
            Controls.Add(btnHome);
            Controls.Add(btnOrder);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtLogin);
            Controls.Add(btnAdmin);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdmin;
        private TextBox txtLogin;
        private TextBox txtPass;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Button btnOrder;
        private PictureBox btnHome;
        private Label label3;
    }
}
