namespace youtube_Downloader
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.downloadBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.urlText = new System.Windows.Forms.TextBox();
            this.resBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.settingBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.extText = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadBtn
            // 
            this.downloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadBtn.Location = new System.Drawing.Point(442, 416);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(117, 32);
            this.downloadBtn.TabIndex = 0;
            this.downloadBtn.Text = "Start";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(44, 343);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(515, 23);
            this.progressBar.TabIndex = 1;
            // 
            // urlText
            // 
            this.urlText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlText.Location = new System.Drawing.Point(44, 238);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(421, 22);
            this.urlText.TabIndex = 2;
            // 
            // resBox
            // 
            this.resBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBox.FormattingEnabled = true;
            this.resBox.Items.AddRange(new object[] {
            "144",
            "240",
            "360",
            "480",
            "720",
            "1080"});
            this.resBox.Location = new System.Drawing.Point(480, 236);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(77, 24);
            this.resBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // lblPercentage
            // 
            this.lblPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(243, 423);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(104, 25);
            this.lblPercentage.TabIndex = 5;
            this.lblPercentage.Text = "0%";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(44, 416);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 32);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // sizeLbl
            // 
            this.sizeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLbl.Location = new System.Drawing.Point(41, 377);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(43, 18);
            this.sizeLbl.TabIndex = 7;
            this.sizeLbl.Text = "Size:";
            this.sizeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(42, 299);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(445, 31);
            this.titleLbl.TabIndex = 8;
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed
            // 
            this.speed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speed.AutoSize = true;
            this.speed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed.Location = new System.Drawing.Point(208, 377);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(59, 18);
            this.speed.TabIndex = 9;
            this.speed.Text = "Speed:";
            this.speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timelbl
            // 
            this.timelbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(405, 377);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(81, 18);
            this.timelbl.TabIndex = 10;
            this.timelbl.Text = "Est. Time: ";
            this.timelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingBtn
            // 
            this.settingBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.Location = new System.Drawing.Point(402, 29);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(75, 29);
            this.settingBtn.TabIndex = 11;
            this.settingBtn.Text = "Settings";
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBtn.Location = new System.Drawing.Point(483, 29);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(75, 29);
            this.historyBtn.TabIndex = 12;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // extText
            // 
            this.extText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extText.Location = new System.Drawing.Point(493, 299);
            this.extText.Name = "extText";
            this.extText.Size = new System.Drawing.Size(66, 31);
            this.extText.TabIndex = 13;
            this.extText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(62, 272);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(54, 17);
            this.status.TabIndex = 18;
            this.status.Text = "Status:";
            // 
            // instructions
            // 
            this.instructions.Location = new System.Drawing.Point(45, 77);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(514, 144);
            this.instructions.TabIndex = 19;
            this.instructions.Text = resources.GetString("instructions.Text");
            this.instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 460);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.status);
            this.Controls.Add(this.extText);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.downloadBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainPage";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Downloader By NerdDev Studio";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.ComboBox resBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label sizeLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Label extText;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label instructions;
    }
}

