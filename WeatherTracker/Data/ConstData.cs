using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WeatherTracker.Data
{
    public class ConstData
    {
        public const string SERVER = "192.168.1.29";        //Set here ip address of your MySql server
        public const string DATABASE = "saa_asema";         //Set your DataBase
        public const string USERNAME = "";           //Set your username for database access
        public const string PASSWORD = "";           //Set your password for database access
        public const string SETINTERVALURL = "http://192.168.1.29/setinterval.php?minutes=";    //Set address of your setinterval php page
        public const string GETINTERVALURL = "http://192.168.1.29/readinterval.php";            //Set address of your readinterval php page

    }
}
