using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassLibrary2
{
    public class dllPosInfo
    {
        private string sAdminId;
        private string sAdminPwd;
        private string sPosId;
        private string sIp;
        private int nPort;

        /// <summary>
        /// 관리자 ID
        /// </summary>
        public string m_sAdminId { get { return sAdminId; } }
        /// <summary>
        /// 관리자 Password
        /// </summary>
        public string m_sAdminPwd { get { return sAdminPwd; } }
        /// <summary>
        /// 포스 Id
        /// </summary>
        public string m_sPosId { get { return sPosId; } }
        /// <summary>
        /// IP번호
        /// </summary>
        public string m_sIp { get { return sIp; } }
        /// <summary>
        /// 포트번호
        /// </summary>
        public int m_nPort { get { return nPort; } }
        public dllPosInfo()
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(@"config.xml");
                XmlNodeList xmlList = xml.SelectNodes("/config");
                foreach (XmlNode xn in xmlList)
                {
                    sAdminId = xn["ID"].InnerText;
                    sAdminPwd = xn["Pw"].InnerText;
                    sPosId = xn["PosId"].InnerText;
                    sIp = xn["Ip"].InnerText;
                    nPort = Convert.ToInt32(xn["Port"].InnerText);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
