using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Client
{
    class posInfo
    {
        public string sAdminId { get; set; }
        public string sAdminPwd { get; set; }
        public string sPosId { get; set; }
        public string sIp { get; set; }
        public int nPort { get; set; }
        public posInfo()
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
