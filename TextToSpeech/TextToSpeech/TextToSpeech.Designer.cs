namespace TextToSpeech
{
    partial class frmTextToSpeech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTextToSpeech));
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.pbPause = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pbStop = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(18, 65);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(332, 139);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.pbPause);
            this.gbMain.Controls.Add(this.lblMsg);
            this.gbMain.Controls.Add(this.pbStop);
            this.gbMain.Controls.Add(this.pbPlay);
            this.gbMain.Controls.Add(this.lblText);
            this.gbMain.Controls.Add(this.rtbText);
            this.gbMain.Location = new System.Drawing.Point(23, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(370, 292);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            // 
            // pbPause
            // 
            this.pbPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPause.Image = ((System.Drawing.Image)(resources.GetObject("pbPause.Image")));
            this.pbPause.Location = new System.Drawing.Point(105, 240);
            this.pbPause.Name = "pbPause";
            this.pbPause.Size = new System.Drawing.Size(32, 32);
            this.pbPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPause.TabIndex = 6;
            this.pbPause.TabStop = false;
            this.pbPause.Click += new System.EventHandler(this.pbPause_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(18, 223);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 5;
            // 
            // pbStop
            // 
            this.pbStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStop.Image = ((System.Drawing.Image)(resources.GetObject("pbStop.Image")));
            this.pbStop.Location = new System.Drawing.Point(225, 240);
            this.pbStop.Name = "pbStop";
            this.pbStop.Size = new System.Drawing.Size(32, 32);
            this.pbStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStop.TabIndex = 4;
            this.pbStop.TabStop = false;
            this.pbStop.Click += new System.EventHandler(this.pbStop_Click);
            // 
            // pbPlay
            // 
            this.pbPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlay.Image = ((System.Drawing.Image)(resources.GetObject("pbPlay.Image")));
            this.pbPlay.Location = new System.Drawing.Point(164, 240);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(32, 32);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPlay.TabIndex = 3;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.pbPlay_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(15, 33);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(75, 17);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Enter Text";
            // 
            // frmTextToSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 322);
            this.Controls.Add(this.gbMain);
            this.Name = "frmTextToSpeech";
            this.Text = "Text To Speech";
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox pbStop;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox pbPause;
    }
}

