using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace PHD_TOOLS
{
    public partial class InfoForm : UserControl
    {
        ClassINI ini;
        private string strIniFIle = @"\Phdtools_config.ini";
        public InfoForm()
        {
            InitializeComponent();
        }
        private void LoadIni()
        {
            ini = new ClassINI();
            textBox_ID.Text = Global.strPHD_Username;
            textBox_Host.Text = Global.strPHD_HOST;
            textBoxPW.Text = Global.strPHD_Password;
            checkbox_RemoteAPI.Checked = Convert.ToBoolean(Global.strPHD_Remote);

        }
        private void SaveIni()
        {
            Global.strPHD_HOST = textBox_Host.Text.ToString();
            Global.strPHD_Username = textBox_ID.Text.ToString();
            Global.strPHD_Password = textBoxPW.Text.ToString();
            Global.strPHD_Remote = checkbox_RemoteAPI.Checked.ToString();

            Assembly asm = Assembly.GetAssembly(typeof(InfoForm));
            ini.writeINI(Path.GetDirectoryName(asm.Location) + strIniFIle, "PHD", "HOST", Global.strPHD_HOST);
            ini.writeINI(Path.GetDirectoryName(asm.Location) + strIniFIle, "PHD", "User name", Global.strPHD_Username);
            ini.writeINI(Path.GetDirectoryName(asm.Location) + strIniFIle, "PHD", "Password", Global.strPHD_Password);
            ini.writeINI(Path.GetDirectoryName(asm.Location) + strIniFIle, "PHD", "RemoteAPI", Global.strPHD_Remote);

        }

        private void BtnClick_IniSave(object sender, EventArgs e)
        {
            SaveIni();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            LoadIni();
        }
    }
}
