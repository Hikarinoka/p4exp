using System.Windows.Forms;

namespace P4EXP
{
    partial class LaunchingHMFA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaunchingHMFA));
            this.closeBtn = new System.Windows.Forms.Button();
            this.launchingGridLbl = new System.Windows.Forms.Label();
            this.expiredGridLbl = new System.Windows.Forms.Label();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(503, 278);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(100, 28);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = global::P4EXP.Properties.Resources.LaunchingHMFA_CloseBtn;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // launchingGridLbl
            // 
            this.launchingGridLbl.AutoSize = true;
            this.launchingGridLbl.Location = new System.Drawing.Point(191, 231);
            this.launchingGridLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.launchingGridLbl.Name = "launchingGridLbl";
            this.launchingGridLbl.Size = new System.Drawing.Size(207, 16);
            this.launchingGridLbl.TabIndex = 5;
            this.launchingGridLbl.Text = "Launching P4 MFA Authenticator...";
            this.launchingGridLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // expiredGridLbl
            // 
            this.expiredGridLbl.AutoSize = true;
            this.expiredGridLbl.Location = new System.Drawing.Point(17, 16);
            this.expiredGridLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expiredGridLbl.MaximumSize = new System.Drawing.Size(587, 0);
            this.expiredGridLbl.Name = "expiredGridLbl";
            this.expiredGridLbl.Size = new System.Drawing.Size(557, 32);
            this.expiredGridLbl.TabIndex = 4;
            this.expiredGridLbl.Text = "Your session has expired. You must authenticate your identity to continue working" +
    " in this open connection.";
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(397, 278);
            this.downloadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(100, 28);
            this.downloadBtn.TabIndex = 7;
            this.downloadBtn.Text = global::P4EXP.Properties.Resources.LaunchingHMFA_DownloadBtn;
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = global::P4EXP.Properties.Resources.download_icon;
            this.pictureBox.Location = new System.Drawing.Point(261, 97);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(104, 96);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // LaunchingHMFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(619, 321);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.launchingGridLbl);
            this.Controls.Add(this.expiredGridLbl);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LaunchingHMFA";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Verify your identity for {0} on {1}";
            this.Shown += new System.EventHandler(this.LaunchingHMFA_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private Label expiredGridLbl;
        private Label launchingGridLbl;
        private Button closeBtn;
        private Button downloadBtn;
    }
}