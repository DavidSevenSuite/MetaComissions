using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ConnectionString
    {
        private string _DataSource;
        private string _DataBase;
        private string _User;
        private string _Password;

        public ConnectionString() { }

        public ConnectionString(string DataSource, string DataBase, string User, string Password)
        {
            this.DataSource = DataSource;
            this.DataBase = DataBase;
            this.User = User;
            this.Password = Password;
        }

        public string DataSource
        {
            get
            {
                return _DataSource;
            }
            set
            {
                _DataSource = value;
            }
        }

        public string DataBase
        {
            get
            {
                return _DataBase;
            }
            set
            {
                _DataBase = value;
            }
        }

        public string User
        {
            get
            {
                return _User;
            }
            set
            {
                _User = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
    }
}
