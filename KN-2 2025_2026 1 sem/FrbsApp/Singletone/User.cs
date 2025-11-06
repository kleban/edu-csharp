using System;
using System.Collections.Generic;
using System.Text;

namespace Singletone
{
    public class User
    {
        private User()
        {
        }

        private static User _instance;

        public static User GetInstance()
        {
            if (_instance == null)
            {
                _instance = new User();
            }
            return _instance;
        }
    }
}
