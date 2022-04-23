namespace Carro
{
    partial class GifLuces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GifLuces));
            this.label1 = new System.Windows.Forms.Label();
            this.luces = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.luces)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(261, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acabas de encender las luces del carro";
            // 
            // luces
            // 
            this.luces.AccessibleName = "";
            this.luces.BackColor = System.Drawing.SystemColors.ControlText;
            this.luces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.luces.Image = global::Carro.Properties.Resources.giphy;
            this.luces.Location = new System.Drawing.Point(15, 45);
            this.luces.Name = "luces";
            this.luces.Size = new System.Drawing.Size(257, 194);
            this.luces.TabIndex = 1;
            this.luces.TabStop = false;
            // 
            // GifLuces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.luces);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GifLuces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Luces del Carro";
            this.Load += new System.EventHandler(this.GifLuces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox luces;
    }
}