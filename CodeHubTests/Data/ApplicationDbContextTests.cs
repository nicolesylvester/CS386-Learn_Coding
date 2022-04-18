using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeHub.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHub.Data.Tests
{
    
    public class ApplicationDbContextTests
    {
       
        public void ApplicationDbContextTest()
        {
            Assert.Fail();
        }

        public async void PingCheck()
        {
            DateTime now = DateTime.Now;
            var hostUrl = "www.trinket.io";
            Ping ping = new Ping();


            PingReply result = await ping.SendPingAsync(hostUrl);

            using (FileStream fs = File.Create("pingData.txt"))
            {
                AddText(fs, "Date: " + now.ToString("F"));
                AddText(fs, result);
            }
        }
    }
}