using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PostOfficeManagement.BLL
{
    public class Login
    {
        private Login _Login;

        public Login()
        {
            _Login = new Login();
        }

        public DataSet GetAll()
        {
            return _Login.GetAll();
        }
    }
}
