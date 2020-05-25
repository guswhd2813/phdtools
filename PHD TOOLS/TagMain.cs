using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHD_TOOLS
{
    public partial class TagMain : UserControl
    {
        private DataGridView Datagridview_searchtag = new DataGridView();
        private static TagMain _instance = null;
        TimePanel tp = new TimePanel();
        public TagMain(string _num)
        {
            this.Name = _num.ToString();
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            //Datagridview_searchtag 

            this.Controls.Add(tp);
            tp.Dock = DockStyle.Bottom;            
            splitContainer1.Panel2.Controls.Add(Datagridview_searchtag);
            Datagridview_searchtag.Dock = DockStyle.Fill;
            Datagridview_searchtag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Datagridview_searchtag.Location = new System.Drawing.Point(0, 0);
            Datagridview_searchtag.Name = "dataGridView1";
            Datagridview_searchtag.RowHeadersVisible = false;
            Datagridview_searchtag.RowTemplate.Height = 23;
            Datagridview_searchtag.Columns.Add("Color", "Color");
            Datagridview_searchtag.Columns.Add("no", "no");
            Datagridview_searchtag.Columns.Add("StartDate", "StartDate");
            Datagridview_searchtag.Columns.Add("EndDate", "EndDate");
            Datagridview_searchtag.Columns.Add("Name", "Name");
            Datagridview_searchtag.Columns.Add("Description", "Description");
            Datagridview_searchtag.Columns.Add("Unit", "Unit");
            Datagridview_searchtag.Columns.Add("RDI", "RDI");
            Datagridview_searchtag.Columns.Add("SourceTagName", "SourceTagName");
            tp.Visible = !(Global.bGlobalSync);


        }
        public DataGridView GetDataGridview_SearchTag()
        {
            return Datagridview_searchtag;
        }
        public void SetDataGridview_SearchTag(DataGridView _dt)
        {
            Datagridview_searchtag = _dt;
        }
        public TableLayoutPanel TableLayout_searchtag()
        {
            return Tablelayout_searchTag;
        }

        public static TagMain GetTagMainForm(string _num)
        {
            if(_instance == null)
            {
                _instance = new TagMain(_num);
            }
            return _instance;
        }
    }
}
