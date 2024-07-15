using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommonServices.GetAppSettingData
{
    public class AppSettingData
    {
        private IConfigurationRoot AllData;
        public AppSettingData()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            AllData = configurationBuilder.Build();
        }
        public string ConnectionString
        {
            get
            {
                return AllData.GetSection("ConnectionString").GetSection("DataConnection").Value;
            }
        }

        public string NubisGlobalEmail()
        {
            return AllData.GetSection("NubisGlobal").GetSection("Emails").Value;
        }
        public string ClientEncryption()
        {
            return AllData.GetSection("ClientEncryption").GetSection("EcncryptKey").Value;
        }
        //public SmsApi GetSmsApi()
        //{
        //    IConfiguration cIC = AllData.GetSection("SmsApi");
        //    return new SmsApi()
        //    {
        //        Url = cIC.GetSection("ApiUrl").Value,
        //        Token = cIC.GetSection("ApiToken").Value,
        //        From = cIC.GetSection("From").Value,
        //        SendCode = Convert.ToBoolean(cIC.GetSection("SendCode").Value)
        //    };
        //}
        public void GetSmtpData()
        {
            IConfiguration csmtp = AllData.GetSection("SMTPAuthProvider");


            //SMTPAuthProvider.SMTPServerAddress = csmtp.GetSection("SMTPServerAddress").Value;
            //SMTPAuthProvider.SMTPPort = Convert.ToInt32(csmtp.GetSection("SMTPPort").Value);
            // SMTPAuthProvider.SMTPUsesSSL = Convert.ToBoolean(csmtp.GetSection("SMTPUsesSSL").Value);
            //SMTPAuthProvider.SMTPUserName = csmtp.GetSection("SMTPUserName").Value;
            // SMTPAuthProvider.SMTPPassword = csmtp.GetSection("SMTPPassword").Value;


        }
    }
}
