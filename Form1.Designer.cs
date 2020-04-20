namespace TypingSpeedCheckerISuppose
{
    partial class Form1
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
            this.lablMainText = new System.Windows.Forms.Label();
            this.tboxWritingSpace = new System.Windows.Forms.TextBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lablMainText
            // 
            this.lablMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablMainText.Location = new System.Drawing.Point(12, 9);
            this.lablMainText.Name = "lablMainText";
            this.lablMainText.Size = new System.Drawing.Size(776, 97);
            this.lablMainText.TabIndex = 0;
            this.lablMainText.Text = "The FitnessGram Pacer Test is a multistage aerobic capacity test that progressive" +
    "ly gets more difficult as it continues.";
            // 
            // tboxWritingSpace
            // 
            this.tboxWritingSpace.Location = new System.Drawing.Point(12, 109);
            this.tboxWritingSpace.Multiline = true;
            this.tboxWritingSpace.Name = "tboxWritingSpace";
            this.tboxWritingSpace.Size = new System.Drawing.Size(776, 149);
            this.tboxWritingSpace.TabIndex = 1;
            this.tboxWritingSpace.TextChanged += new System.EventHandler(this.tboxWritingSpace_TextChanged);
            // 
            // pboxClose
            // 
            this.pboxClose.BackColor = System.Drawing.Color.Transparent;
            this.pboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxClose.Image = global::TypingSpeedCheckerISuppose.Properties.Resources.download__1_;
            this.pboxClose.Location = new System.Drawing.Point(688, 338);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(100, 100);
            this.pboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxClose.TabIndex = 2;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            this.pboxClose.MouseEnter += new System.EventHandler(this.pboxClose_MouseEnter);
            this.pboxClose.MouseLeave += new System.EventHandler(this.pboxClose_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pboxClose);
            this.Controls.Add(this.tboxWritingSpace);
            this.Controls.Add(this.lablMainText);
            this.Name = "Form1";
            this.Text = "How Can YOU Type?!";
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablMainText;
        private System.Windows.Forms.TextBox tboxWritingSpace;
        private System.Windows.Forms.PictureBox pboxClose;
    }
}

