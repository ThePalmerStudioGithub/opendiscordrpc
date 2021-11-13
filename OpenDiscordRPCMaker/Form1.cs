using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;

namespace OpenDiscordRPC
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public DiscordRpcClient client;

        private void initialize_Click(object sender, EventArgs e)
        {
            status.Text = "Initialized";
            status.ForeColor = Color.Lime;
			InitializeRPC();
			this.Text = "OpenDiscordRPC - Initialized - Version " + Application.ProductVersion;
		}

        private void Home_Load(object sender, EventArgs e)
        {
			largeimagekey.Text = "logo";
			largeimagetext.Text = "OpenDiscordRPC";
			smallimagekey.Text = "none";
			smallimagetext.Text = "hi";
			applicationid.Text = "909155101833314354";
			state.Text = "Running";
			details.Text = "Initialized";
			this.Text = "OpenDiscordRPC - Not Initialized - Version " + Application.ProductVersion;
		}

        private void button1_Click(object sender, EventArgs e)
        {
            status.Text = "Not Initialized";
            status.ForeColor = Color.Red;
		
				client.Deinitialize();
			this.Text = "OpenDiscordRPC - Not Initialized - Version " + Application.ProductVersion;

		}
		void InitializeRPC()
		{
			/*
			Create a Discord client
			NOTE: 	If you are using Unity3D, you must use the full constructor and define
					 the pipe connection.
			*/
			client = new DiscordRpcClient(applicationID: applicationid.Text);

			//Set the logger
			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

			//Subscribe to events
			client.OnReady += (sender, e) =>
			{
				Console.WriteLine("Received Ready from user {0}", e.User.Username);
			};

			client.OnPresenceUpdate += (sender, e) =>
			{
				Console.WriteLine("Received Update! {0}", e.Presence);
			};

			//Connect to the RPC
			client.Initialize();

			//Set the rich presence
			//Call this as many times as you want and anywhere in your code.
			client.SetPresence(new RichPresence()
			{
				Details = details.Text,
				State = state.Text,
				Assets = new Assets()
				{
					LargeImageKey = largeimagekey.Text,
					LargeImageText = largeimagetext.Text,
					SmallImageKey = smallimagekey.Text,
					SmallImageText = smallimagetext.Text
				}
			}) ; 
		}

        private void update_Click(object sender, EventArgs e)
        {
		
				client.UpdateDetails(details.Text);
				client.UpdateState(state.Text);
				client.UpdateLargeAsset(largeimagekey.Text);
				client.UpdateSmallAsset(smallimagekey.Text);
				client.CurrentPresence.Assets.LargeImageText = largeimagetext.Text;
				client.CurrentPresence.Assets.SmallImageText = smallimagetext.Text;
		
        }

        private void updatetime_Tick(object sender, EventArgs e)
        {
			time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void github_Click(object sender, EventArgs e)
        {
			System.Diagnostics.Process.Start("https://github.com/ThePalmerStudioGithub/opendiscordrpc");
        }
    }
}
