namespace tutorial2_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            face = new PictureBox();
            back = new PictureBox();
            showface = new Label();
            showback = new Label();
            ((System.ComponentModel.ISupportInitialize)face).BeginInit();
            ((System.ComponentModel.ISupportInitialize)back).BeginInit();
            SuspendLayout();
            // 
            // face
            // 
            face.Image = (Image)resources.GetObject("face.Image");
            face.Location = new Point(351, 58);
            face.Name = "face";
            face.Size = new Size(167, 243);
            face.SizeMode = PictureBoxSizeMode.StretchImage;
            face.TabIndex = 0;
            face.TabStop = false;
            face.Visible = false;
            face.Click += face_Click;
            // 
            // back
            // 
            back.Image = (Image)resources.GetObject("back.Image");
            back.Location = new Point(351, 58);
            back.Name = "back";
            back.Size = new Size(172, 243);
            back.SizeMode = PictureBoxSizeMode.StretchImage;
            back.TabIndex = 1;
            back.TabStop = false;
            // 
            // showface
            // 
            showface.AutoSize = true;
            showface.BorderStyle = BorderStyle.Fixed3D;
            showface.Font = new Font("新細明體", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showface.Location = new Point(192, 349);
            showface.Name = "showface";
            showface.Size = new Size(214, 50);
            showface.TabIndex = 2;
            showface.Text = "顯示正面";
            showface.Click += showface_Click;
            // 
            // showback
            // 
            showback.AutoSize = true;
            showback.BorderStyle = BorderStyle.Fixed3D;
            showback.Font = new Font("新細明體", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showback.Location = new Point(456, 349);
            showback.Name = "showback";
            showback.Size = new Size(214, 50);
            showback.TabIndex = 3;
            showback.Text = "顯示背面";
            showback.Click += showback_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showback);
            Controls.Add(showface);
            Controls.Add(back);
            Controls.Add(face);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)face).EndInit();
            ((System.ComponentModel.ISupportInitialize)back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox face;
        private PictureBox back;
        private Label showface;
        private Label showback;
    }
}
