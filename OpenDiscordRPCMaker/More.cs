using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenDiscordRPC
{
    public partial class More : Form
    {
        public More()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SetDetailsToWindowTitle detailsToWindowTitle = new SetDetailsToWindowTitle();
            detailsToWindowTitle.ShowDialog();
        }

        private void More_Load(object sender, EventArgs e)
        {
            version.Text = Application.ProductVersion;
            pcname.Text = Environment.MachineName;
            Process[] discord = Process.GetProcessesByName("Discord");
            if (discord.Length != 0)
            {
                if (discord[0].ProcessName != null)
                {
                    isdiscordrunning.Text = "Yes";
                }
            }
            else
            {
                isdiscordrunning.Text = "No";
            }
        }
    }
}
