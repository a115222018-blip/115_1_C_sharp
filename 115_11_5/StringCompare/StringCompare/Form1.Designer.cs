namespace StringCompare
{
    partial class Form1
    {
        private Label lblString1;
        private Label lblString2;
        private TextBox txtString1;
        private TextBox txtString2;
        private Button btnCompare;
        private Button btnExit;

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
            lblString1 = new Label();
            lblString2 = new Label();
            txtString1 = new TextBox();
            txtString2 = new TextBox();
            btnCompare = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblString1
            // 
            lblString1.AutoSize = true;
            lblString1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblString1.Location = new Point(129, 69);
            lblString1.Name = "lblString1";
            lblString1.Size = new Size(133, 41);
            lblString1.TabIndex = 0;
            lblString1.Text = "字串1：";
            // 
            // lblString2
            // 
            lblString2.AutoSize = true;
            lblString2.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblString2.Location = new Point(129, 158);
            lblString2.Name = "lblString2";
            lblString2.Size = new Size(133, 41);
            lblString2.TabIndex = 1;
            lblString2.Text = "字串2：";
            // 
            // txtString1
            // 
            txtString1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtString1.Location = new Point(303, 68);
            txtString1.Name = "txtString1";
            txtString1.Size = new Size(250, 48);
            txtString1.TabIndex = 2;
            // 
            // txtString2
            // 
            txtString2.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtString2.Location = new Point(303, 156);
            txtString2.Name = "txtString2";
            txtString2.Size = new Size(250, 48);
            txtString2.TabIndex = 3;
            // 
            // btnCompare
            // 
            btnCompare.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnCompare.Location = new Point(129, 271);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(160, 58);
            btnCompare.TabIndex = 4;
            btnCompare.Text = "比較";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnExit.Location = new Point(393, 273);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 58);
            btnExit.TabIndex = 5;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 379);
            Controls.Add(btnExit);
            Controls.Add(btnCompare);
            Controls.Add(txtString2);
            Controls.Add(txtString1);
            Controls.Add(lblString2);
            Controls.Add(lblString1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "字串比較";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
