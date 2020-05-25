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
        private bool bHideManu = true;
        private int iPagenum = 0;
        TimePanel timepanel = new TimePanel();
        public MainForm()
        {
            InitializeComponent();
        }
        private void FormLoad(object sender, EventArgs e)
        {
            LOADINI();
            LoadRDI();
            Global.bGlobalSync = true;
            timepanel.Dock = DockStyle.Bottom;
            this.Controls.Add(timepanel);
            Btn_Sync.BackColor = Color.FromArgb(100, 0, 250, 0);


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

        private void LoadRDI()
        {
            ClassPHD oPhd = new ClassPHD();
            oPhd.ConnectServer(Global.strPHD_HOST, Global.strPHD_Username, Global.strPHD_Password);

            foreach (var rdi in oPhd.GetRDIList())
            {
                comboBox1.Items.Add(rdi);
            }
            oPhd.CloseServer();
        }

        private void BtnClick_TagSearch(object sender, EventArgs e)
        {
            try
            {
                ClassPHD oPhd = new ClassPHD();
                oPhd.ConnectServer(Global.strPHD_HOST, Global.strPHD_Username, Global.strPHD_Password);
                DataSet dt = oPhd.GetTagList(textBox1.Text, comboBox1.Text);

                dataGridView1.DataSource = dt.Tables[0];
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;

                oPhd.CloseServer();
            }
            catch
            {
                MessageBox.Show("Not connect to PHD Server");
            }
            

        }
        private void BtnClick_Info(object sender, EventArgs e)
        {
            panel_manu.Visible = bHideManu;
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
            tabControl1.SelectedIndex = tabControl1.TabCount-1;

        }
        private void BtnClick_Tag(object sender, EventArgs e)
        {
            AddTagTap();
        }

        private TagMain AddTagTap()
        {
            panel_manu.Visible = bHideManu;
            TabPage tpInfo = new TabPage("TAG");

            //TagMain tag = new TagMain(iPagenum.ToString());
            //tag.Name = iPagenum.ToString();
            // tag.Dock = DockStyle.Fill;
            TagMain tagpage = new TagMain(iPagenum.ToString());

            //tpInfo.Controls.Add(TagMain.GetTagMainForm(iPagenum.ToString()));
            //TagMain.GetTagMainForm(iPagenum.ToString()).Dock = DockStyle.Fill;            
            tagpage.Dock = DockStyle.Fill;
            tpInfo.Controls.Add(tagpage);
            tpInfo.Name = iPagenum.ToString();
            tpInfo.Text = "TAG";
            tabControl1.Controls.Add(tpInfo);
            tabControl1.SelectedIndex = tabControl1.TabCount - 1;
            iPagenum++;
            return tagpage;
        }

        private void BtnClick_ManuHide(object sender, EventArgs e)
        {
            
            if (bHideManu)
            {
                splitContainer1.SplitterDistance = 20;
                
                bHideManu = false;
                //for (int i = iNowsize; i > 20; i--)
                //{
                //    
                //    //panel_manu.Width = i;
                //    //panel_main.Dock = DockStyle.Fill;
                //    //Thread.Sleep(1);
                    
                //}
                //panel_manu.Visible = false;
                button_hide.Text = "▶";
            }
            else
            {
                bHideManu = true;
                splitContainer1.SplitterDistance = 200;
                //for (int i = 20; i < 200; i++)
                //{
                //    splitContainer1.SplitterDistance = i;
                //    //panel_manu.Width = i;
                //    //panel_main.Dock = DockStyle.Fill;
                //    //Thread.Sleep(1);

                //}
                button_hide.Text = "◀";
            }
        }

        private void SearchedTagDoubleClick(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab != null)
            {
                if (tabControl1.SelectedTab.Text == "TAG")
                {
                    test();
                }
                else if (tabControl1.SelectedTab.Text == "Trend")
                {

                }
                else
                {
                    //AddTagTap();
                    DoubleClick_TagSearch(true, AddTagTap());
                }
            }
            else
            {
                DoubleClick_TagSearch(true, AddTagTap());
            }
        }
        private void test()
        {
            string[] tag = { };
            ClassPHD oPhd = new ClassPHD();
            oPhd.ConnectServer(Global.strPHD_HOST, Global.strPHD_Username, Global.strPHD_Password);
            DataGridView dt = TagMain.GetTagMainForm(tabControl1.SelectedTab.Name).GetDataGridview_SearchTag();
            dt.Rows.Add(
                    "", dataGridView1.SelectedCells[1].Value, "", "",
                    dataGridView1.SelectedCells[0].Value, dataGridView1.SelectedCells[2].Value, dataGridView1.SelectedCells[3].Value,
                    dataGridView1.SelectedCells[4].Value, dataGridView1.SelectedCells[7]);

            TagMain.GetTagMainForm(tabControl1.SelectedTab.Name).SetDataGridview_SearchTag(dt);
                
                TagMain.GetTagMainForm(tabControl1.SelectedTab.Name).Refresh();
        }
        private void DoubleClick_TagSearch(bool b, TagMain tg)
        {
            string[] tag = { };
            ClassPHD oPhd = new ClassPHD();
            oPhd.ConnectServer(Global.strPHD_HOST, Global.strPHD_Username, Global.strPHD_Password);

            //TagMain.GetTagMainForm(tabControl1.SelectedTab.Name).GetDataGridview_SearchTag().Rows.Add("", dataGridView1.SelectedCells[1].Value, "", "", 
            //    dataGridView1.SelectedCells[0].Value, dataGridView1.SelectedCells[2].Value, dataGridView1.SelectedCells[3].Value, dataGridView1.SelectedCells[4].Value,
            //    dataGridView1.SelectedCells[7].Value
            //    );


            if (b)
            {
                tg = new TagMain(tabControl1.SelectedTab.Name);
                tg.GetDataGridview_SearchTag().Rows.Add("", dataGridView1.SelectedCells[1].Value, "", "",
                    dataGridView1.SelectedCells[0].Value, dataGridView1.SelectedCells[2].Value, dataGridView1.SelectedCells[3].Value, dataGridView1.SelectedCells[4].Value,
                    dataGridView1.SelectedCells[7].Value
                );
            }
            else
            {
                TagMain.GetTagMainForm(tabControl1.SelectedTab.Name).GetDataGridview_SearchTag().Rows.Add("", dataGridView1.SelectedCells[1].Value, "", "",
             dataGridView1.SelectedCells[0].Value, dataGridView1.SelectedCells[2].Value, dataGridView1.SelectedCells[3].Value, dataGridView1.SelectedCells[4].Value,
             dataGridView1.SelectedCells[7].Value
             );
            }
            //for(int i = 0; i < TagMain.GetTagMainForm(tabControl1.SelectedTab.Name).GetDataGridview_SearchTag().Rows.Count; i++)
            //{
            //    tag.SetValue(TagMain.GetTagMainForm(tabControl1.SelectedTab.Name).GetDataGridview_SearchTag().Rows[i].Cells[3].Value, i);
            //}
            //DataTable dt = oPhd.FetchDataTable(tag, "2020-01-01 00:00:00", "2020-04-25 00:00:00",30, Uniformance.PHD.SAMPLETYPE.Raw);
            // TagMain.GetTagMainForm(tabControl1.SelectedTab.Name).TableLayout_searchtag().Controls.Add();


        }

        private void BtnClick_Sync(object sender, EventArgs e)
        {

            if (Global.bGlobalSync)
            {
                Global.bGlobalSync = false;                
                Btn_Sync.BackColor = Color.FromArgb(100,255,0,0);
                timepanel.Visible = false;
            }
            else
            {
                Global.bGlobalSync = true;
                Btn_Sync.BackColor = Color.FromArgb(100,0,250,0);
                timepanel.Visible = true;

            }
        }
    }
}
