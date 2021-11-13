
namespace OpenDiscordRPC
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.statustext = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.applicationidtext = new System.Windows.Forms.Label();
            this.applicationid = new System.Windows.Forms.TextBox();
            this.smallimagekeytext = new System.Windows.Forms.Label();
            this.smallimagekey = new System.Windows.Forms.TextBox();
            this.smallimagetexttext = new System.Windows.Forms.Label();
            this.smallimagetext = new System.Windows.Forms.TextBox();
            this.largeimagekeytext = new System.Windows.Forms.Label();
            this.largeimagekey = new System.Windows.Forms.TextBox();
            this.largeimagetexttext = new System.Windows.Forms.Label();
            this.largeimagetext = new System.Windows.Forms.TextBox();
            this.detailstext = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.TextBox();
            this.statetext = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.initialize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.updatetime = new System.Windows.Forms.Timer(this.components);
            this.copyright = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.github = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.github)).BeginInit();
            this.SuspendLayout();
            // 
            // statustext
            // 
            this.statustext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statustext.AutoSize = true;
            this.statustext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statustext.Location = new System.Drawing.Point(283, 147);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(79, 30);
            this.statustext.TabIndex = 1;
            this.statustext.Text = "Status:";
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(368, 147);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(153, 30);
            this.status.TabIndex = 2;
            this.status.Text = "Not initialized";
            // 
            // applicationidtext
            // 
            this.applicationidtext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.applicationidtext.AutoSize = true;
            this.applicationidtext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationidtext.Location = new System.Drawing.Point(320, 191);
            this.applicationidtext.Name = "applicationidtext";
            this.applicationidtext.Size = new System.Drawing.Size(161, 30);
            this.applicationidtext.TabIndex = 3;
            this.applicationidtext.Text = "Application ID:";
            // 
            // applicationid
            // 
            this.applicationid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.applicationid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationid.Location = new System.Drawing.Point(281, 224);
            this.applicationid.Name = "applicationid";
            this.applicationid.Size = new System.Drawing.Size(240, 27);
            this.applicationid.TabIndex = 4;
            this.applicationid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smallimagekeytext
            // 
            this.smallimagekeytext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.smallimagekeytext.AutoSize = true;
            this.smallimagekeytext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallimagekeytext.Location = new System.Drawing.Point(309, 254);
            this.smallimagekeytext.Name = "smallimagekeytext";
            this.smallimagekeytext.Size = new System.Drawing.Size(182, 30);
            this.smallimagekeytext.TabIndex = 5;
            this.smallimagekeytext.Text = "Small Image Key:";
            // 
            // smallimagekey
            // 
            this.smallimagekey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.smallimagekey.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallimagekey.Location = new System.Drawing.Point(281, 287);
            this.smallimagekey.Name = "smallimagekey";
            this.smallimagekey.Size = new System.Drawing.Size(240, 27);
            this.smallimagekey.TabIndex = 6;
            this.smallimagekey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smallimagetexttext
            // 
            this.smallimagetexttext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.smallimagetexttext.AutoSize = true;
            this.smallimagetexttext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallimagetexttext.Location = new System.Drawing.Point(307, 317);
            this.smallimagetexttext.Name = "smallimagetexttext";
            this.smallimagetexttext.Size = new System.Drawing.Size(187, 30);
            this.smallimagetexttext.TabIndex = 7;
            this.smallimagetexttext.Text = "Small Image Text:";
            // 
            // smallimagetext
            // 
            this.smallimagetext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.smallimagetext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallimagetext.Location = new System.Drawing.Point(281, 350);
            this.smallimagetext.Name = "smallimagetext";
            this.smallimagetext.Size = new System.Drawing.Size(240, 27);
            this.smallimagetext.TabIndex = 8;
            this.smallimagetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // largeimagekeytext
            // 
            this.largeimagekeytext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.largeimagekeytext.AutoSize = true;
            this.largeimagekeytext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeimagekeytext.Location = new System.Drawing.Point(309, 380);
            this.largeimagekeytext.Name = "largeimagekeytext";
            this.largeimagekeytext.Size = new System.Drawing.Size(182, 30);
            this.largeimagekeytext.TabIndex = 9;
            this.largeimagekeytext.Text = "Large Image Key:";
            // 
            // largeimagekey
            // 
            this.largeimagekey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.largeimagekey.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeimagekey.Location = new System.Drawing.Point(281, 413);
            this.largeimagekey.Name = "largeimagekey";
            this.largeimagekey.Size = new System.Drawing.Size(240, 27);
            this.largeimagekey.TabIndex = 10;
            this.largeimagekey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // largeimagetexttext
            // 
            this.largeimagetexttext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.largeimagetexttext.AutoSize = true;
            this.largeimagetexttext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeimagetexttext.Location = new System.Drawing.Point(307, 443);
            this.largeimagetexttext.Name = "largeimagetexttext";
            this.largeimagetexttext.Size = new System.Drawing.Size(187, 30);
            this.largeimagetexttext.TabIndex = 11;
            this.largeimagetexttext.Text = "Large Image Text:";
            // 
            // largeimagetext
            // 
            this.largeimagetext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.largeimagetext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeimagetext.Location = new System.Drawing.Point(281, 476);
            this.largeimagetext.Name = "largeimagetext";
            this.largeimagetext.Size = new System.Drawing.Size(240, 27);
            this.largeimagetext.TabIndex = 12;
            this.largeimagetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // detailstext
            // 
            this.detailstext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailstext.AutoSize = true;
            this.detailstext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailstext.Location = new System.Drawing.Point(358, 506);
            this.detailstext.Name = "detailstext";
            this.detailstext.Size = new System.Drawing.Size(85, 30);
            this.detailstext.TabIndex = 13;
            this.detailstext.Text = "Details:";
            // 
            // details
            // 
            this.details.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.details.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(280, 548);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(240, 27);
            this.details.TabIndex = 14;
            this.details.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statetext
            // 
            this.statetext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statetext.AutoSize = true;
            this.statetext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statetext.Location = new System.Drawing.Point(366, 578);
            this.statetext.Name = "statetext";
            this.statetext.Size = new System.Drawing.Size(68, 30);
            this.statetext.TabIndex = 15;
            this.statetext.Text = "State:";
            // 
            // state
            // 
            this.state.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.state.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.Location = new System.Drawing.Point(280, 611);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(240, 27);
            this.state.TabIndex = 16;
            this.state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // initialize
            // 
            this.initialize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.initialize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.initialize.FlatAppearance.BorderSize = 0;
            this.initialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initialize.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialize.ForeColor = System.Drawing.Color.Lime;
            this.initialize.Location = new System.Drawing.Point(12, 653);
            this.initialize.Name = "initialize";
            this.initialize.Size = new System.Drawing.Size(195, 38);
            this.initialize.TabIndex = 17;
            this.initialize.Text = "Initialize";
            this.initialize.UseVisualStyleBackColor = true;
            this.initialize.Click += new System.EventHandler(this.initialize_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(593, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Deinitialize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Blue;
            this.update.Location = new System.Drawing.Point(303, 653);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(195, 38);
            this.update.TabIndex = 19;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(313, 110);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(180, 30);
            this.name.TabIndex = 20;
            this.name.Text = "OpenDiscordRPC";
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(5, 694);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(214, 37);
            this.time.TabIndex = 21;
            this.time.Text = "{timegoeshere}";
            this.time.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // updatetime
            // 
            this.updatetime.Enabled = true;
            this.updatetime.Interval = 1000;
            this.updatetime.Tick += new System.EventHandler(this.updatetime_Tick);
            // 
            // copyright
            // 
            this.copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(521, 706);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(267, 25);
            this.copyright.TabIndex = 22;
            this.copyright.Text = "©2021 TPS™ Enterprises Inc.";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // icon
            // 
            this.icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.icon.Image = global::OpenDiscordRPC.Properties.Resources.icon;
            this.icon.Location = new System.Drawing.Point(335, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(131, 107);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // github
            // 
            this.github.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.github.Image = global::OpenDiscordRPC.Properties.Resources.github;
            this.github.Location = new System.Drawing.Point(715, 0);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(84, 56);
            this.github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.github.TabIndex = 23;
            this.github.TabStop = false;
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 740);
            this.Controls.Add(this.github);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.time);
            this.Controls.Add(this.name);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.initialize);
            this.Controls.Add(this.state);
            this.Controls.Add(this.statetext);
            this.Controls.Add(this.details);
            this.Controls.Add(this.detailstext);
            this.Controls.Add(this.largeimagetext);
            this.Controls.Add(this.largeimagetexttext);
            this.Controls.Add(this.largeimagekey);
            this.Controls.Add(this.largeimagekeytext);
            this.Controls.Add(this.smallimagetext);
            this.Controls.Add(this.smallimagetexttext);
            this.Controls.Add(this.smallimagekey);
            this.Controls.Add(this.smallimagekeytext);
            this.Controls.Add(this.applicationid);
            this.Controls.Add(this.applicationidtext);
            this.Controls.Add(this.status);
            this.Controls.Add(this.statustext);
            this.Controls.Add(this.icon);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "OpenDiscordRPC";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.github)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label statustext;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label applicationidtext;
        private System.Windows.Forms.TextBox applicationid;
        private System.Windows.Forms.Label smallimagekeytext;
        private System.Windows.Forms.TextBox smallimagekey;
        private System.Windows.Forms.Label smallimagetexttext;
        private System.Windows.Forms.TextBox smallimagetext;
        private System.Windows.Forms.Label largeimagekeytext;
        private System.Windows.Forms.TextBox largeimagekey;
        private System.Windows.Forms.Label largeimagetexttext;
        private System.Windows.Forms.TextBox largeimagetext;
        private System.Windows.Forms.Label detailstext;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.Label statetext;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Button initialize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer updatetime;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.PictureBox github;
    }
}

