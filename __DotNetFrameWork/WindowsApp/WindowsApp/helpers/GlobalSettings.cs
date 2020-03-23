using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.helpers
{
    class GlobalSettings
    {
        private static GlobalSettings _instance = new GlobalSettings();

        private string _username;
        private int _idUser;
        public int  IdUser {
            get  { return _idUser; }
            set  {
                _idUser = value;
                this._loggedIn = true;
            }
        }
        private bool _loggedIn;

        private GlobalSettings()
        {
            LoggedIn = false;
        }

        public static GlobalSettings Instance { get => _instance; }
        public string Username { get => _username; set => _username = value; }
        public bool LoggedIn { get => _loggedIn; set => _loggedIn = value; }

    }
}
