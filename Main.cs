using System.Diagnostics;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;
using System.Net;
using System.ComponentModel;
using System.Threading;

namespace Setup_EvoGS_Rep
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            //Drive
            foreach (var Drive in DriveInfo.GetDrives())
            {
                Drive_CB.Items.Add(Drive.Name);
            }
            Drive_CB.SelectedItem = Drive_CB.Items[0];

            //Rep
            Rep_CB.Items.Add("DK");
            Rep_CB.SelectedItem = Rep_CB.Items[0];

            //Setup Button
            Update_Setup_Button(sender, e);

        }

        private void Drive_CB_TextUpdate(object sender, EventArgs e)
        {
            Drive_CB.SelectedItem = Drive_CB.Items[0];
            Update_Setup_Button(sender, e);
        }

        private void Rep_CB_TextUpdate(object sender, EventArgs e)
        {
            Rep_CB.SelectedItem = Rep_CB.Items[0];
            Update_Setup_Button(sender, e);
        }

        private void Update_Setup_Button(object sender, EventArgs e)
        {
            bool Enabled = false;
            if (Drive_CB.SelectedItem != null)// && Rep_CB.SelectedItem != null)
            {
                //if (User_TxB.TextLength >= 3 && Password_TxB.TextLength >= 3)
                {
                    Enabled = true;
                }
            }
            Setup_Bt.Enabled = Enabled;
        }

        private async void Setup_Bt_Click(object sender, EventArgs e)
        {

            Setup_PB.Value = 0;
            await Task.Delay(500);

            if (Drive_CB.SelectedItem is not null)
            {

                //Directory
                string Path = Drive_CB.SelectedItem.ToString()!.Replace(@"\", "/") + "Workspace/EvoGS/EvoGS-DK/";
                Directory.CreateDirectory(Path);
                Setup_PB.Value = 10;
                await Task.Delay(500);

                //SVN
                bool SVN_Found = false;
                string SVN_URL = "https://18.230.121.220/svn/EvoGS-DK/";
                Process SVN_Proc = new Process();
                SVN_Proc.StartInfo.FileName = "svn.exe";
                SVN_Proc.StartInfo.Arguments = "checkout " + SVN_URL + " " + Path.Replace("/", @"\").Remove(Path.Length - 1);

                try
                {
                    SVN_Found = SVN_Proc.Start();
                }
                catch (Exception exc)
                {

                    //Progress Bar
                    Setup_PB.Value = 25;
                    await Task.Delay(500);

                    //Download
                    if (!File.Exists("TortoiseSVN.msi"))
                    {
                        WebClient WebClt = new WebClient();
                        WebClt.DownloadFile("https://sinalbr.dl.sourceforge.net/project/tortoisesvn/1.14.5/Application/TortoiseSVN-1.14.5.29465-x64-svn-1.14.2.msi", "TortoiseSVN.msi");
                    }

                    Setup_PB.Value = 40;
                    await Task.Delay(500);

                    //Install
                    Process SVN_Install_Proc = new Process();
                    SVN_Install_Proc.StartInfo.FileName = Directory.GetCurrentDirectory().Replace("/", @"\") + @"\TortoiseSVN.msi";
                    SVN_Install_Proc.StartInfo.UseShellExecute = true;
                    SVN_Install_Proc.Start();
                    SVN_Install_Proc.WaitForExit();
                    Setup_PB.Value = 50;
                    await Task.Delay(500);

                    //Delete
                    File.Delete("TortoiseSVN.msi");
                    Setup_PB.Value = 60;
                    await Task.Delay(500);

                }

                Setup_PB.Value = 80;
                await Task.Delay(500);

                if (!SVN_Found)
                {
                    try
                    {
                        SVN_Found = SVN_Proc.Start();
                    }
                    catch (Exception exc)
                    {
                        SVN_Proc.StartInfo.FileName = @"C:\Program Files\TortoiseSVN\bin\svn.exe";
                    }
                }

                if (!SVN_Found)
                {
                    try
                    {
                        SVN_Found = SVN_Proc.Start();
                    }
                    catch (Exception exc)
                    {
                    }
                }

                if (SVN_Found)
                {
                    SVN_Proc.WaitForExit();
                }

                Setup_PB.Value = 100;
                await Task.Delay(2000);

            }

            //App
            Application.Exit();

        }

    }

}
