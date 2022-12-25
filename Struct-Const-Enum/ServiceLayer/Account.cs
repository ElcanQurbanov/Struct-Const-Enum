using ServiceLayer.ErrorsClass;
using ServiceLayer.Interfaces;
using Struct_Const_Enum.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class Account : IAccount
    {
       public string Login(string username, string password, Role roles)
        {
            if (username == "test@code.edu.az" && password == "test12345" && role == (role)Roles.SuperAdmin)
            {
                return Errors.Success;
            }
            else if (password== "test@code.edu.az" && password == "test12345" && !=roles.super)
            {
                return Errors.LoginError;
            }
            else
            {
                return Errors.LoginRolesErrors;
            }



        }

        public int Login(string username, string password)
        {
            
        }
    }
}




