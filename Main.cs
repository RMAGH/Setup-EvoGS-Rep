using System.Diagnostics;
using System.IO;
using System.Security.Policy;

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

        private void Setup_Bt_Click(object sender, EventArgs e)
        {

            //Directory
            string Path = Drive_CB.SelectedItem.ToString().Replace(@"\", "/") + "Workspace/EvoGS/EvoGS-DK/";
            Directory.CreateDirectory(Path);

            //SVN
            string SVN_URL = "https://18.230.121.220/svn/EvoGS-DK/";
            Process SVN_Proc = new Process();
            SVN_Proc.StartInfo.FileName = "svn.exe";
            SVN_Proc.StartInfo.Arguments = "checkout " + SVN_URL + " " + Path.Replace("/", @"\").Remove(Path.Length - 1);
            SVN_Proc.Start();
            SVN_Proc.WaitForExit();

            //App
            Application.Exit();

        }

    }

}
