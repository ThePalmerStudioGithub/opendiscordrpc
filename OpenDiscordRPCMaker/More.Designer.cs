namespace OpenDiscordRPC
{
    partial class More
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(More));
            this.moretext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.versiontext = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.pcnametext = new System.Windows.Forms.Label();
            this.pcname = new System.Windows.Forms.Label();
            this.isdiscordrunningtext = new System.Windows.Forms.Label();
            this.isdiscordrunning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moretext
            // 
            this.moretext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moretext.AutoSize = true;
            this.moretext.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moretext.Location = new System.Drawing.Point(326, 9);
            this.moretext.Name = "moretext";
            this.moretext.Size = new System.Drawing.Size(179, 45);
            this.moretext.TabIndex = 0;
            this.moretext.Text = "More stuff";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 45);
            this.label1.TabIndex = 1;
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Blue;
            this.update.Location = new System.Drawing.Point(180, 108);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(484, 38);
            this.update.TabIndex = 20;
            this.update.Text = "Set Details To The Window Title of A Process";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 45);
            this.label2.TabIndex = 21;
            this.label2.Text = "About:";
            // 
            // versiontext
            // 
            this.versiontext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.versiontext.AutoSize = true;
            this.versiontext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versiontext.Location = new System.Drawing.Point(293, 203);
            this.versiontext.Name = "versiontext";
            this.versiontext.Size = new System.Drawing.Size(98, 30);
            this.versiontext.TabIndex = 22;
            this.versiontext.Text = "Version :";
            // 
            // version
            // 
            this.version.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(397, 203);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(189, 30);
            this.version.TabIndex = 23;
            this.version.Text = "{versiongoeshere}";
            // 
            // pcnametext
            // 
            this.pcnametext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcnametext.AutoSize = true;
            this.pcnametext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcnametext.Location = new System.Drawing.Point(293, 244);
            this.pcnametext.Name = "pcnametext";
            this.pcnametext.Size = new System.Drawing.Size(142, 30);
            this.pcnametext.TabIndex = 24;
            this.pcnametext.Text = "Running on :";
            // 
            // pcname
            // 
            this.pcname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcname.AutoSize = true;
            this.pcname.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcname.Location = new System.Drawing.Point(441, 244);
            this.pcname.Name = "pcname";
            this.pcname.Size = new System.Drawing.Size(195, 30);
            this.pcname.TabIndex = 25;
            this.pcname.Text = "{pcnamegoeshere}";
            // 
            // isdiscordrunningtext
            // 
            this.isdiscordrunningtext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.isdiscordrunningtext.AutoSize = true;
            this.isdiscordrunningtext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isdiscordrunningtext.Location = new System.Drawing.Point(293, 285);
            this.isdiscordrunningtext.Name = "isdiscordrunningtext";
            this.isdiscordrunningtext.Size = new System.Drawing.Size(227, 30);
            this.isdiscordrunningtext.TabIndex = 26;
            this.isdiscordrunningtext.Text = "Is Discord Running ? :";
            // 
            // isdiscordrunning
            // 
            this.isdiscordrunning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.isdiscordrunning.AutoSize = true;
            this.isdiscordrunning.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isdiscordrunning.Location = new System.Drawing.Point(526, 285);
            this.isdiscordrunning.Name = "isdiscordrunning";
            this.isdiscordrunning.Size = new System.Drawing.Size(195, 30);
            this.isdiscordrunning.TabIndex = 27;
            this.isdiscordrunning.Text = "{isdiscordrunning}";
            // 
            // More
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(830, 465);
            this.Controls.Add(this.isdiscordrunning);
            this.Controls.Add(this.isdiscordrunningtext);
            this.Controls.Add(this.pcname);
            this.Controls.Add(this.pcnametext);
            this.Controls.Add(this.version);
            this.Controls.Add(this.versiontext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moretext);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "More";
            this.Text = "More";
            this.Load += new System.EventHandler(this.More_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moretext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label versiontext;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label pcnametext;
        private System.Windows.Forms.Label pcname;
        private System.Windows.Forms.Label isdiscordrunningtext;
        private System.Windows.Forms.Label isdiscordrunning;
    }
}