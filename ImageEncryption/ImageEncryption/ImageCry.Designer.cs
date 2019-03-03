namespace ImageEncryption
{
    partial class ImageCry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageCry));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.OpenImageMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveImageMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SecretMessageBox = new System.Windows.Forms.RichTextBox();
            this.ExtractMessageButton = new System.Windows.Forms.Button();
            this.HideMessageButton = new System.Windows.Forms.Button();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.MainMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenImageMenuOption,
            this.SaveImageMenuOption});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(657, 24);
            this.MainMenuStrip.TabIndex = 6;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // OpenImageMenuOption
            // 
            this.OpenImageMenuOption.ForeColor = System.Drawing.Color.White;
            this.OpenImageMenuOption.Name = "OpenImageMenuOption";
            this.OpenImageMenuOption.Size = new System.Drawing.Size(84, 20);
            this.OpenImageMenuOption.Text = "Open Image";
            this.OpenImageMenuOption.Click += new System.EventHandler(this.OpenImageMenuOption_Click_1);
            // 
            // SaveImageMenuOption
            // 
            this.SaveImageMenuOption.ForeColor = System.Drawing.Color.White;
            this.SaveImageMenuOption.Name = "SaveImageMenuOption";
            this.SaveImageMenuOption.Size = new System.Drawing.Size(79, 20);
            this.SaveImageMenuOption.Text = "Save Image";
            this.SaveImageMenuOption.Click += new System.EventHandler(this.SaveImageMenuOption_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SecretMessageBox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(324, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 223);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secret Message";
            // 
            // SecretMessageBox
            // 
            this.SecretMessageBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SecretMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecretMessageBox.Location = new System.Drawing.Point(3, 16);
            this.SecretMessageBox.Name = "SecretMessageBox";
            this.SecretMessageBox.Size = new System.Drawing.Size(316, 204);
            this.SecretMessageBox.TabIndex = 0;
            this.SecretMessageBox.Text = "";
            // 
            // ExtractMessageButton
            // 
            this.ExtractMessageButton.BackColor = System.Drawing.Color.Transparent;
            this.ExtractMessageButton.Location = new System.Drawing.Point(477, 277);
            this.ExtractMessageButton.Name = "ExtractMessageButton";
            this.ExtractMessageButton.Size = new System.Drawing.Size(83, 35);
            this.ExtractMessageButton.TabIndex = 9;
            this.ExtractMessageButton.Text = "Decrypt";
            this.ExtractMessageButton.UseVisualStyleBackColor = false;
            this.ExtractMessageButton.Click += new System.EventHandler(this.ExtractMessageButton_Click_1);
            // 
            // HideMessageButton
            // 
            this.HideMessageButton.Location = new System.Drawing.Point(359, 277);
            this.HideMessageButton.Name = "HideMessageButton";
            this.HideMessageButton.Size = new System.Drawing.Size(74, 35);
            this.HideMessageButton.TabIndex = 8;
            this.HideMessageButton.Text = "Encrypt";
            this.HideMessageButton.UseVisualStyleBackColor = true;
            this.HideMessageButton.Click += new System.EventHandler(this.HideMessageButton_Click_1);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.BackgroundImage = global::ImageEncryption.Properties.Resources.galaxy_s5_wallpaper_1440x900;
            this.MainPictureBox.Location = new System.Drawing.Point(12, 27);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(306, 297);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPictureBox.TabIndex = 5;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.Click += new System.EventHandler(this.MainPictureBox_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::ImageEncryption.Properties.Resources.uuuu;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(598, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 35);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ImageCry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 339);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.MainPictureBox);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExtractMessageButton);
            this.Controls.Add(this.HideMessageButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageCry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageCry";
            this.Load += new System.EventHandler(this.ImageCry_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenImageMenuOption;
        private System.Windows.Forms.ToolStripMenuItem SaveImageMenuOption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox SecretMessageBox;
        private System.Windows.Forms.Button ExtractMessageButton;
        private System.Windows.Forms.Button HideMessageButton;
        private System.Windows.Forms.Button button5;
    }
}