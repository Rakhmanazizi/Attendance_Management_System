using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTENDANCEMANAGEMENTSYSTEM
{
    public static class UserSession
    {
        public static string Username { get; private set; }

        public static void setLogin(string username)
        {
            Username = username;
        } 

        public static void clearSession()
        {
            Username = null;
        }
    }
}
