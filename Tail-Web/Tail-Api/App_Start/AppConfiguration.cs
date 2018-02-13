
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tail_Api.App_Start
{
    public class AppConfiguration
    {
        public static void Register()
        {
            string cs = @"Server=172.31.25.70;uid=sa;pwd=stagingsa;Trusted_Connection=False;Application Name=MachinesLocalDebuggingApplication;";
            string secret = "NotASecretAnymore";
            //Set initial configuration for application.

            //Set all the application settings here.
            //IApplicationSetting appSet = new ApplicationSetting(100, 4, cs, cs, secret);
            //GlobalContext.Add(appSet);
        }
    }
}