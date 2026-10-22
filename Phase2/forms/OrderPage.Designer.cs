namespace Phase2.forms
{
    partial class OrderPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPage));
            btnHome = new PictureBox();
            btnComplete = new Button();
            lblSubtotal = new Label();
            lblTotal = new Label();
            lblTax = new Label();
            txtOrderContains = new TextBox();
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
            // btnComplete
            // 
            btnComplete.Location = new Point(710, 413);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(149, 85);
            btnComplete.TabIndex = 12;
            btnComplete.Text = "End Customer Tree";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(142, 296);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(138, 40);
            lblSubtotal.TabIndex = 13;
            lblSubtotal.Text = "Subtotal: ";
            lblSubtotal.Click += lblSubtotal_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(142, 376);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 40);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "Total: ";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTax.Location = new Point(142, 336);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(71, 40);
            lblTax.TabIndex = 15;
            lblTax.Text = "Tax: ";
            // 
            // txtOrderContains
            // 
            txtOrderContains.Location = new Point(142, 61);
            txtOrderContains.Multiline = true;
            txtOrderContains.Name = "txtOrderContains";
            txtOrderContains.Size = new Size(421, 217);
            txtOrderContains.TabIndex = 16;
            // 
            // OrderPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 221, 203);
            ClientSize = new Size(871, 510);
            Controls.Add(txtOrderContains);
            Controls.Add(lblTax);
            Controls.Add(lblTotal);
            Controls.Add(lblSubtotal);
            Controls.Add(btnComplete);
            Controls.Add(btnHome);
            Name = "OrderPage";
            Text = "OrderPage";
            Load += OrderPage_Load;
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnHome;
        private Button btnComplete;
        private Label lblSubtotal;
        private Label lblTotal;
        private Label lblTax;
        private TextBox txtOrderContains;
    }
}