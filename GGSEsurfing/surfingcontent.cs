using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace GGSEsurfing
{
    class surfingcontent
    {
        //客户端信息
        public string _username = "StudentID";
        public string _password = "Password";
        public string _GGSIP;
        public static string _macCode = Common.GetConfig("ggssurfing", "MAC");//= "B4-2E-99-E1-2F-64";
        public static string _nasip= Common.GetConfig("ggssurfing", "NACIP");
        public static string esurfingIP= Common.GetConfig("ggssurfing", "ESURIP");
        public string _iswifi = "4060";

        //客户端识别地址
        private string LOGINURL = "http://"+ esurfingIP + ":10001/client/login";
        private string LOGOUTURL = "http://" + esurfingIP + ":10001/client/logout";
        private string CHALLENGEURL = "http://" + esurfingIP + ":10001/client/challenge";
        private string HEARTBEATURL = "http://" + esurfingIP + ":8001/hbservice/client/active";
        private string CHECKINTERNETURL = "http://www.baidu.com";
        private string SECRET = "Eshore!@#";
        private string UA = "Mozilla/4.0 (compatible; MSIE 5.01; Windows NT 5.0)";

        public surfingcontent(string username,string password,string ip,string ggsip,string mac)
        {
            _username = username;
            _password = password;
            _GGSIP = ip;
            _macCode = mac;
        }
        public string GetTimestamp()
        {
            TimeSpan timestamp = DateTime.UtcNow - new DateTime(2020, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(timestamp.TotalMilliseconds).ToString();//以毫秒为单位
        }

        public string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] data = Encoding.UTF8.GetBytes(str);
            byte[] data2 = md5.ComputeHash(data);

            return GetbyteToString(data2);
        }
        public string GetJSONString(Dictionary<string, string> datas)
        {
            string JSONString = "{";
            int i = 1;
            foreach (KeyValuePair<string, string> data in datas)
            {
                JSONString += "\"" + data.Key + "\":\"" + data.Value + "\"";
                if (i < data.Key.Count())
                {
                    JSONString += ",";
                }
            }
            JSONString += "}";
            return JSONString;
        }

        private string GetbyteToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public string GetToken(string response)
        {
            if (response != "failed")
            {
                string[] temp = response.Split('"');
                return temp[3];
            }
            return "failed";
        }
        //上传验证码
        public string PostChallenge()
        {
            string timestamp = GetTimestamp();
            string authenticator = GetMD5(_GGSIP + _nasip + _macCode + timestamp + SECRET);

            Dictionary<string, string> datas = new Dictionary<string, string>();
            datas.Add("username", _username);
            datas.Add("clientip", _GGSIP);
            datas.Add("nasip", _nasip);
            datas.Add("mac", _macCode);
            datas.Add("timestamp", timestamp);
            datas.Add("authenticator", authenticator);

            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("User-agent", UA);

            string response = string.Empty;

            try
            {
                response = Common.HTTPPost(CHALLENGEURL, headers, GetJSONString(datas));
            }
            catch (Exception ex)
            {
                response = "failed";
            }
            if (response == null)
            {
                response = "failed";
            }
            return response;
        }

        public string PostLogout()
        {
            string timestamp = GetTimestamp();
            string authenticator = GetMD5(_GGSIP + _nasip + _macCode + timestamp + SECRET);

            Dictionary<string, string> datas = new Dictionary<string, string>();
            datas.Add("username", _username);
            datas.Add("clientip", _GGSIP);
            datas.Add("nasip", _nasip);
            datas.Add("mac", _macCode);
            datas.Add("timestamp", timestamp);
            datas.Add("authenticator", authenticator);

            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("User-agent", UA);

            string response = string.Empty;

            try
            {
                response = Common.HTTPPost(LOGOUTURL, headers, GetJSONString(datas));
            }
            catch (Exception ex)
            {
                response = "failed";
            }
            if (response == null)
            {
                response = "failed";
            }
            return response;
        }
        //提交登录表单
        public string PostLogin(string token)
        {
            string timestamp = GetTimestamp();
            string authenticator = GetMD5(_GGSIP + _nasip + _macCode + timestamp + token + SECRET);

            Dictionary<string, string> datas = new Dictionary<string, string>();
            datas.Add("username", _username);
            datas.Add("password", _password);
            datas.Add("clientip", _GGSIP);
            datas.Add("nasip", _nasip);
            datas.Add("mac", _macCode);
            datas.Add("timestamp", timestamp);
            datas.Add("authenticator", authenticator);
            datas.Add("iswifi", _iswifi);

            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("User-agent", UA);

            string response = string.Empty;

            try
            {
                response = Common.HTTPPost(LOGINURL, headers, GetJSONString(datas));
            }
            catch (Exception ex)
            {
                response = "failed";
            }
            return response;
        }

        //每次回传的频率
        public string Heartbeat()
        {
            string timestamp = GetTimestamp();
            string authenticator = GetMD5(_GGSIP + _nasip + _macCode + timestamp + SECRET);
            string url = HEARTBEATURL + "username=" + _username + "&clientip=" + _GGSIP + "&nasip=" + _nasip + "&mac=" + _macCode + "&timestamp=" + timestamp + "&authenticator=" + authenticator;

            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("User-agent", UA);

            string response = string.Empty;
            try
            {
                response = Common.HTTPGet(url, headers);
            }
            catch (Exception ex)
            {
                response = "failed";
            }
            return response;
        }
        //获取MAC码
        public static string GetMacCodeDown(string macAdress)
        {
            _macCode = macAdress;
            Process p = null;
            StreamReader reader = null;
            try
            {
                ProcessStartInfo start = new ProcessStartInfo("cmd.exe");

                start.FileName = "ipconfig";
                start.Arguments = "/all";

                start.CreateNoWindow = true;

                start.RedirectStandardOutput = true;

                start.RedirectStandardInput = true;

                start.UseShellExecute = false;

                p = Process.Start(start);

                reader = p.StandardOutput;
                
                string line = reader.ReadLine();
                
                while (!reader.EndOfStream)
                {
                    if (line.ToLower().IndexOf("physical address") > 0 || line.ToLower().IndexOf("物理地址") > 0)
                    {
                        int index = line.IndexOf(":");
                        index += 2;
                        macAdress = line.Substring(index);
                        macAdress = macAdress.Replace('-', ':');
                        break;
                    }
                   
                    line = reader.ReadLine();
                }
            }
            catch
            {
                

            }
            finally
            {
                if (p != null)
                {

                    p.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return macAdress;
        }

        //获取天翼校园网IP地址
        public static string EsurfingIP(string ipaddress)
        {
            IPHostEntry hostInfo = Dns.GetHostEntry("enet.10000.gd.cn");
            IPAddress ip = hostInfo.AddressList[0];
            return ip.ToString();
        }

    }
}
