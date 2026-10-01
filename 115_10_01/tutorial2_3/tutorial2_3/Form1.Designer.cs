namespace tutorial2_3
{
    partial class Form1
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
            label1 = new Label();
            translateLabel = new Label();
            italion = new Label();
            spainish = new Label();
            german = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(112, 77);
            label1.Name = "label1";
            label1.Size = new Size(579, 69);
            label1.TabIndex = 0;
            label1.Text = "選擇一個語言，我告訴你怎麼說\"早安\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // translateLabel
            // 
            translateLabel.BorderStyle = BorderStyle.Fixed3D;
            translateLabel.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            translateLabel.Location = new Point(283, 181);
            translateLabel.Name = "translateLabel";
            translateLabel.Size = new Size(221, 72);
            translateLabel.TabIndex = 1;
            translateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // italion
            // 
            italion.AutoSize = true;
            italion.BackColor = SystemColors.ButtonHighlight;
            italion.BorderStyle = BorderStyle.FixedSingle;
            italion.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            italion.ForeColor = SystemColors.ActiveCaptionText;
            italion.Location = new Point(112, 335);
            italion.Name = "italion";
            italion.Size = new Size(116, 43);
            italion.TabIndex = 2;
            italion.Text = "義大利";
            italion.Click += italion_Click;
            // 
            // spainish
            // 
            spainish.AutoSize = true;
            spainish.BackColor = SystemColors.ButtonHighlight;
            spainish.BorderStyle = BorderStyle.FixedSingle;
            spainish.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            spainish.ForeColor = SystemColors.ActiveCaptionText;
            spainish.Location = new Point(339, 335);
            spainish.Name = "spainish";
            spainish.Size = new Size(116, 43);
            spainish.TabIndex = 3;
            spainish.Text = "西班牙";
            spainish.Click += spainish_Click;
            // 
            // german
            // 
            german.AutoSize = true;
            german.BackColor = SystemColors.ButtonHighlight;
            german.BorderStyle = BorderStyle.FixedSingle;
            german.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            german.ForeColor = SystemColors.ActiveCaptionText;
            german.Location = new Point(566, 335);
            german.Name = "german";
            german.Size = new Size(84, 43);
            german.TabIndex = 4;
            german.Text = "德國";
            german.Click += german_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(german);
            Controls.Add(spainish);
            Controls.Add(italion);
            Controls.Add(translateLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label translateLabel;
        private Label italion;
        private Label spainish;
        private Label german;
    }
}
