namespace DownloadPhoto
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblSearch = new System.Windows.Forms.Label();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnAutoSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnR = new System.Windows.Forms.Button();
            this.bttnL = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bttnSrtat = new System.Windows.Forms.Button();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSearch.Location = new System.Drawing.Point(16, 29);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(149, 29);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Query string:";
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtBxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxSearch.Location = new System.Drawing.Point(171, 29);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(468, 30);
            this.txtBxSearch.TabIndex = 1;
            // 
            // bttnSave
            // 
            this.bttnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSave.Enabled = false;
            this.bttnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.bttnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSave.Location = new System.Drawing.Point(497, 524);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(217, 45);
            this.bttnSave.TabIndex = 4;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnAutoSave
            // 
            this.bttnAutoSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAutoSave.Enabled = false;
            this.bttnAutoSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnAutoSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.bttnAutoSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAutoSave.Location = new System.Drawing.Point(3, 524);
            this.bttnAutoSave.Name = "bttnAutoSave";
            this.bttnAutoSave.Size = new System.Drawing.Size(217, 45);
            this.bttnAutoSave.TabIndex = 5;
            this.bttnAutoSave.Text = "Аuto Save";
            this.bttnAutoSave.UseVisualStyleBackColor = true;
            this.bttnAutoSave.Click += new System.EventHandler(this.bttnAutoSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearchResults);
            this.panel1.Controls.Add(this.bttnR);
            this.panel1.Controls.Add(this.bttnL);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(21, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 432);
            this.panel1.TabIndex = 6;
            // 
            // bttnR
            // 
            this.bttnR.BackColor = System.Drawing.SystemColors.Control;
            this.bttnR.BackgroundImage = global::DownloadPhoto.Properties.Resources.arrowL;
            this.bttnR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnR.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bttnR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnR.Location = new System.Drawing.Point(642, 389);
            this.bttnR.Name = "bttnR";
            this.bttnR.Size = new System.Drawing.Size(51, 43);
            this.bttnR.TabIndex = 5;
            this.bttnR.UseVisualStyleBackColor = false;
            this.bttnR.Click += new System.EventHandler(this.bttnR_Click);
            // 
            // bttnL
            // 
            this.bttnL.BackColor = System.Drawing.SystemColors.Control;
            this.bttnL.BackgroundImage = global::DownloadPhoto.Properties.Resources.arrowR;
            this.bttnL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnL.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bttnL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnL.Location = new System.Drawing.Point(0, 389);
            this.bttnL.Name = "bttnL";
            this.bttnL.Size = new System.Drawing.Size(51, 43);
            this.bttnL.TabIndex = 4;
            this.bttnL.UseVisualStyleBackColor = false;
            this.bttnL.Click += new System.EventHandler(this.bttnL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(693, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bttnSrtat
            // 
            this.bttnSrtat.BackColor = System.Drawing.SystemColors.Control;
            this.bttnSrtat.BackgroundImage = global::DownloadPhoto.Properties.Resources.icons8_detective_64;
            this.bttnSrtat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnSrtat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSrtat.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bttnSrtat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnSrtat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnSrtat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSrtat.Location = new System.Drawing.Point(645, 15);
            this.bttnSrtat.Name = "bttnSrtat";
            this.bttnSrtat.Size = new System.Drawing.Size(69, 65);
            this.bttnSrtat.TabIndex = 2;
            this.bttnSrtat.UseVisualStyleBackColor = false;
            this.bttnSrtat.Click += new System.EventHandler(this.bttnSrtat_Click);
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchResults.ForeColor = System.Drawing.Color.Red;
            this.lblSearchResults.Location = new System.Drawing.Point(3, 10);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(79, 29);
            this.lblSearchResults.TabIndex = 6;
            this.lblSearchResults.Text = "label1";
            this.lblSearchResults.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(726, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttnAutoSave);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttnSrtat);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.LblSearch);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox txtBxSearch;
        private System.Windows.Forms.Button bttnSrtat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnAutoSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnR;
        private System.Windows.Forms.Button bttnL;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblSearchResults;
    }
}

