using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Reflection;

namespace PHD_TOOLS
{
    public partial class MainForm : Form
    {
        private string strIniFIle = @"\Phdtools_config.ini";
        private bool bHideManu = false;
        public MainForm()
        {
            InitializeComponent();
        }
        private void FormLoad(object sender, EventArgs e)
        {
            panel_manu.Width = 12;
            button_hide.Text = "▶";
            LOADINI();
        }
        private void LOADINI()
        {
            ClassINI ini = new ClassINI();
            Assembly asm = Assembly.GetAssembly(typeof(MainForm));
            Global.strPHD_HOST = ini.readINI(Path.GetDirectoryName(asm.Location) + strIniFIle, "PHD", "HOST");
            Global.strPHD_Username = ini.readINI(Path.GetDirectoryName(asm.Location) + strIniFIle, "PHD", "User name");
            Global.strPHD_Password = ini.readINI(Path.GetDirectoryName(asm.Location) + strIniFIle, "PHD", "Password");
            Global.strPHD_Remote = ini.readINI(Path.GetDirectoryName(asm.Location) + strIniFIle, "PHD", "RemoteAPI");
        }

        private void BtnClick_Info(object sender, EventArgs e)
        {
            //panel_manu.Visible = bHideManu;
            TabPage tpInfo = new TabPage("configuration");
            foreach(TabPage page in tabControl1.TabPages)
            {
                if (page.Name == "configuration")
                {
                    page.Dispose();
                }                
            }
            InfoForm info = new InfoForm();
            info.Dock = DockStyle.Fill;
            tpInfo.Controls.Add(info);
            tpInfo.Name = "configuration";
            tpInfo.Text = "configuration";
            tabControl1.Controls.Add(tpInfo);
            tabControl1.Controls[0].Show();
            
        }
        private void BtnClick_Tag(object sender, EventArgs e)
        {
            //panel_manu.Visible = bHideManu;
            TabPage tpInfo = new TabPage("TAG");
            TagMain tag = new TagMain();
            tag.Dock = DockStyle.Fill;
            tpInfo.Controls.Add(tag);
            tpInfo.Name = "TAG";
            tpInfo.Text = "TAG";
            tabControl1.Controls.Add(tpInfo);
            tabControl1.Controls[0].Show();

        }

        private void BtnClick_ManuHide(object sender, EventArgs e)
        {
            if(bHideManu)
            {
                bHideManu = false;
                            
                panel_manu.Width = 12;
                //panel_manu.Visible = false;
                button_hide.Text = "▶";
            }
            else
            {
                bHideManu = true;

                //for (int i = 20; i < 180; i++)
                //{
                //    panel_manu.Width = i;
                //    Thread.Sleep(1);
                //    //tabControl1.Dock = DockStyle.Fill;
                //   // panel_main.Dock = DockStyle.Fill;
                //}
                panel_manu.Width = 180;
                //panel_manu.Visible = true;
                button_hide.Text = "◀";
            }
            
            
        }

        private void Tagname_change(object sender, EventArgs e)
        {
            ClassPHD phd = new ClassPHD();
            DataSet dt = new DataSet();
            phd.ConnectServer(Global.strPHD_HOST, Global.strPHD_Username, Global.strPHD_Password);
            dt = phd.GetTagList(textBox1.Text.ToString());
            foreach(string tagname in dt.Tables[0].Rows[0].ItemArray)
            {
                tagname.ToString();
            }
        }
    }
}
