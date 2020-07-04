namespace OBSCurrentSong
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurrentSong = new System.Windows.Forms.Label();
            this.grpOutputOptions = new System.Windows.Forms.GroupBox();
            this.radSong = new System.Windows.Forms.RadioButton();
            this.radArtist = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.numIntervall = new System.Windows.Forms.NumericUpDown();
            this.lblRefreshIntervall = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.LinkLabel();
            this.grpOutputOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervall)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentSong
            // 
            this.lblCurrentSong.AutoSize = true;
            this.lblCurrentSong.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentSong.Name = "lblCurrentSong";
            this.lblCurrentSong.Size = new System.Drawing.Size(178, 13);
            this.lblCurrentSong.TabIndex = 0;
            this.lblCurrentSong.Text = "BRUTAL ARTIST - BRUTAL SONG";
            // 
            // grpOutputOptions
            // 
            this.grpOutputOptions.Controls.Add(this.radSong);
            this.grpOutputOptions.Controls.Add(this.radArtist);
            this.grpOutputOptions.Controls.Add(this.radAll);
            this.grpOutputOptions.Location = new System.Drawing.Point(15, 25);
            this.grpOutputOptions.Name = "grpOutputOptions";
            this.grpOutputOptions.Size = new System.Drawing.Size(331, 88);
            this.grpOutputOptions.TabIndex = 1;
            this.grpOutputOptions.TabStop = false;
            this.grpOutputOptions.Text = "Output options";
            // 
            // radSong
            // 
            this.radSong.AutoSize = true;
            this.radSong.Location = new System.Drawing.Point(6, 42);
            this.radSong.Name = "radSong";
            this.radSong.Size = new System.Drawing.Size(50, 17);
            this.radSong.TabIndex = 2;
            this.radSong.Text = "Song";
            this.radSong.UseVisualStyleBackColor = true;
            this.radSong.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // radArtist
            // 
            this.radArtist.AutoSize = true;
            this.radArtist.Location = new System.Drawing.Point(6, 65);
            this.radArtist.Name = "radArtist";
            this.radArtist.Size = new System.Drawing.Size(48, 17);
            this.radArtist.TabIndex = 1;
            this.radArtist.Text = "Artist";
            this.radArtist.UseVisualStyleBackColor = true;
            this.radArtist.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.Location = new System.Drawing.Point(6, 19);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(82, 17);
            this.radAll.TabIndex = 0;
            this.radAll.TabStop = true;
            this.radAll.Text = "Artist - Song";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // numIntervall
            // 
            this.numIntervall.DecimalPlaces = 1;
            this.numIntervall.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numIntervall.Location = new System.Drawing.Point(104, 114);
            this.numIntervall.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numIntervall.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIntervall.Name = "numIntervall";
            this.numIntervall.Size = new System.Drawing.Size(71, 20);
            this.numIntervall.TabIndex = 3;
            this.numIntervall.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIntervall.ValueChanged += new System.EventHandler(this.numIntervall_ValueChanged);
            // 
            // lblRefreshIntervall
            // 
            this.lblRefreshIntervall.AutoSize = true;
            this.lblRefreshIntervall.Location = new System.Drawing.Point(11, 116);
            this.lblRefreshIntervall.Name = "lblRefreshIntervall";
            this.lblRefreshIntervall.Size = new System.Drawing.Size(87, 13);
            this.lblRefreshIntervall.TabIndex = 4;
            this.lblRefreshIntervall.Text = "Refresh Intervall:";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(181, 117);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(49, 13);
            this.lblSeconds.TabIndex = 5;
            this.lblSeconds.Text = "Seconds";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(236, 117);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(74, 13);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.TabStop = true;
            this.lblVersion.Text = "VX.X by Yoshi";
            this.lblVersion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVersion_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 139);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblRefreshIntervall);
            this.Controls.Add(this.numIntervall);
            this.Controls.Add(this.grpOutputOptions);
            this.Controls.Add(this.lblCurrentSong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "OBS CurrentSong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.grpOutputOptions.ResumeLayout(false);
            this.grpOutputOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentSong;
        private System.Windows.Forms.GroupBox grpOutputOptions;
        private System.Windows.Forms.RadioButton radSong;
        private System.Windows.Forms.RadioButton radArtist;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.NumericUpDown numIntervall;
        private System.Windows.Forms.Label lblRefreshIntervall;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.LinkLabel lblVersion;
    }
}

