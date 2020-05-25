using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Uniformance.PHD;
using System.Windows.Forms;

namespace PHD_TOOLS
{
    public class ClassPHD
    {
        public PHDHistorian m_oPhd;
        private PHDServer m_PhdServer;

        public double[] m_fValue = null;
        public double[] m_timeStamp = null;
        public short[] m_conf = null;

        public void ConnectServer(string strHostName, string strUser, string strPass)
        {
            m_oPhd = new PHDHistorian();
            m_PhdServer = new PHDServer(strHostName);
            m_PhdServer.APIVersion = SERVERVERSION.RAPI200;
            m_PhdServer.UserName = strUser;
            m_PhdServer.Password = strPass;

            m_oPhd.DefaultServer = m_PhdServer;
        }

        public void CloseServer()
        {
            m_PhdServer.Dispose();
            m_oPhd.Dispose();
        }

        public string ConvertToPHDTime(DateTime dt)
        {
            string strConvertTime = m_oPhd.ConvertToPHDTime(dt);
            return strConvertTime;
        }

        public string ConvertToPHDTime(string strTime)
        {
            string strConvertTime = m_oPhd.ConvertToPHDTime(strTime, false);
            return strConvertTime;
        }

        public void GetPhdValue(string strTagName, string strStart, string strEnd, int nFrequency, SAMPLETYPE type)
        {
            m_oPhd = new PHDHistorian();
            m_oPhd.DefaultServer = m_PhdServer;
            m_oPhd.StartTime = strStart;
            m_oPhd.EndTime = strEnd;
            m_oPhd.SampleFrequency = Convert.ToUInt32(nFrequency);
            m_oPhd.Sampletype = type;

            try
            {
                m_oPhd.FetchData(new Tag(strTagName), ref m_timeStamp, ref m_fValue, ref m_conf);
            }
            catch(Exception)
            {
                return;
            }
        }

        public void GetPhdValue(string strTagName, string strStart, string strEnd, string strLine, string strMethod, string strItem, string strGubun, string Value1, string Value2, string Value3, int nFrequency, SAMPLETYPE type, ref double[] dTimeStamp, ref double[] fValue, ref short[] fConf)
        {
            m_oPhd.StartTime = strStart;
            m_oPhd.EndTime = strEnd;

            m_oPhd.SampleFrequency = Convert.ToUInt32(nFrequency);
            m_oPhd.Sampletype = type;

            try
            {
                m_oPhd.FetchData(new Tag(strTagName), ref dTimeStamp, ref fValue, ref fConf);
            }
            catch (Exception)
            {
                return;
            }
        }

        public DataSet GetTagList(string _str, string _rdi)
        {
            TagFilter tagFilter = new TagFilter();
            //tagFilter.SourceTagname = "1BATCH0.STR02";
            tagFilter.Tagname = _str;
            tagFilter.Collector = _rdi;
            DataSet dt;

            try
            {                
                dt = m_oPhd.BrowsingTags(m_PhdServer, 99999999, tagFilter);
                return dt;
            }
            catch (Exception)
            {
                dt = null;
                return dt;
            }
        }

        public ArrayList GetRDIList()
        {
            ArrayList list = new ArrayList();
            try
            {
                TagFilter tagFilter = new TagFilter();
                tagFilter.Collector = "*";

                
                for (int i = 0; i < m_oPhd.GetRDIs(m_PhdServer).Tables[0].Rows.Count; i++)
                {
                    list.Add(m_oPhd.GetRDIs(m_PhdServer).Tables[0].Rows[i].ItemArray[0].ToString());
                }

            
                return list;
            }
            catch (Exception)
            {
                list = null;
                return list;
            }
        }

        public ArrayList GetStructValue(Tags oTags, string strStart, string strEnd, int nFrequency, SAMPLETYPE type)
        {
            ArrayList arlList = new ArrayList();
            PHDataStruct PHDData = new PHDataStruct();

            m_oPhd.StartTime = strStart;
            m_oPhd.EndTime = strEnd;
            m_oPhd.SampleFrequency = Convert.ToUInt32(nFrequency);
            m_oPhd.Sampletype = type;

            try
            {
                arlList = m_oPhd.FetchStructData(oTags);
                return arlList;
            }
            catch (Exception)
            {
                arlList = null;
                return arlList;
            }
        }

        public PHDataStruct[] GetPhdStructValue(Tags oTags, string strStart, string strEnd, int nFrequency, SAMPLETYPE type)
        {
            ArrayList arlList = new ArrayList();

            m_oPhd.StartTime = strStart;
            m_oPhd.EndTime = strEnd;
            m_oPhd.SampleFrequency = Convert.ToUInt32(nFrequency);
            m_oPhd.Sampletype = type;

            try
            {
                arlList = m_oPhd.FetchStructData(oTags);

                PHDataStruct[] stPhd = new PHDataStruct[arlList.Count];
                for (int i = 0; i < arlList.Count; i++)
                {
                    stPhd[i] = (PHDataStruct)arlList[i];
                }
                return stPhd;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet FetchDataSet(Tags oTags, string strStart, string strEnd, int nFrequency, SAMPLETYPE type)
        {
            DataSet ds;

            m_oPhd.StartTime = strStart;
            m_oPhd.EndTime = strEnd;
            m_oPhd.SampleFrequency = Convert.ToUInt32(nFrequency);
            m_oPhd.Sampletype = type;

            try
            {
                ds = m_oPhd.FetchRowData(oTags);
                return ds;
            }
            catch (Exception)
            {
                ds = null;
                return ds;
            }
        }

        public DataTable FetchDataTable(Tags oTags, string strStart, string strEnd, int nFrequency, SAMPLETYPE type)
        {
            DataSet ds;
            DataTable dt;

            m_oPhd.StartTime = strStart;
            m_oPhd.EndTime = strEnd;
            m_oPhd.SampleFrequency = Convert.ToUInt32(nFrequency);
            m_oPhd.Sampletype = type;

            try
            {
                ds = m_oPhd.FetchRowData(oTags);
                dt = ds.Tables[0];

                return dt;
            }
            catch (Exception)
            {
                ds = null;
                dt = null;

                return dt;
            }
        }

        public DataTable FetchDataTable(string[] strTags, string strStart, string strEnd, int nFrequency, SAMPLETYPE type)
        {
            DataSet ds;
            Tags oTags = new Tags();

            m_oPhd.StartTime = strStart;
            m_oPhd.EndTime = strEnd;
            m_oPhd.SampleFrequency = Convert.ToUInt32(nFrequency);
            m_oPhd.Sampletype = type;

            try
            {
                //ds = m_oPhd.FetchReductionsSpecified(oTags, true, new REDUCTIONTYPE[]{REDUCTIONTYPE.Maximum, REDUCTIONTYPE.Minimum});
                ds = m_oPhd.FetchRowData(oTags);
                return ds.Tables[0];
            }
            catch (Exception)
            {
                ds = null;
                return null;
            }
        }

        public DataTable FetchDataTable(string strTagName, string strStart, string strEnd, int nFrequency)
        {
            DataTable dt;
           


            m_oPhd.StartTime = strStart;
            m_oPhd.EndTime = strEnd;
            m_oPhd.SampleFrequency = Convert.ToUInt32(nFrequency);
            m_oPhd.Sampletype = SAMPLETYPE.Snapshot;

            try
            {
                DataSet ds = m_oPhd.FetchRowData(strTagName);
                

                dt = ds.Tables[0];
            }
            catch (PHDErrorException e)
            {
                if (MessageBox.Show(e.ToString(), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                }

                //return false;
                dt = new DataTable(); ;
            }
            return dt;
        }


        public string GetValue(string strTagName, string strTime)
        {
            DataSet ds;
            DataTable dt;

            m_oPhd.StartTime = strTime;
            m_oPhd.EndTime = strTime;
            m_oPhd.SampleFrequency = Convert.ToUInt32(60);
            m_oPhd.Sampletype = SAMPLETYPE.Snapshot;

            try
            {
                ds = m_oPhd.FetchRowData(strTagName);
                dt = ds.Tables[0];

                if (dt.Rows[0][2].ToString().Trim() == "")
                {
                    return "0";
                }

                return dt.Rows[0][2].ToString();
            }
            catch (Exception)
            {
                return "0";
            }
        }

        public string ModifyTag(string strTagName, string strValue, string strTime)
        {
            Tag tag = new Tag(strTagName);
            object value = strValue.Length > 0 ? strValue : "0";
            string time = DateTime.ParseExact(strTime, "yyyyMMddHHmm", null).ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                m_oPhd.ModifyTag(tag, value, time);
                return "success";
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("10044"))
                {
                    return "not connected";
                }
                else
                {
                    return "error";
                }
            }
        }
    }
}
