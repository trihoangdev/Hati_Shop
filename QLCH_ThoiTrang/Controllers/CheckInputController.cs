using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public interface CheckInputController
    {
        bool IsNameValid(string name);
        bool IsUsernameValid(string username);
        bool IsUsernameExist(string username, List<String> usernames);
        bool IsPasswordValid(string password);
        bool IsEmailValid(string email);
        bool IsPhoneValid(string phone);
    }
    public class CheckInputImp : CheckInputController
    {

        public bool IsEmailValid(string email)
        {
            return Regex.IsMatch(email, "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");
        }

        public bool IsNameValid(string name)
        {
            return Regex.IsMatch(name, @"^[\p{L} ]{2,40}$");
        }

        public bool IsPasswordValid(string password)
        {
            return Regex.IsMatch(password, @"^(.{0,7}|[^0-9]*|[^A-Z])$");
        }

        public bool IsPhoneValid(string phone)
        {
            return Regex.IsMatch(phone, @"^0(3|5|8|7|9)\d{8}$");
        }

        public bool IsUsernameExist(string username, List<String> usernames)
        {
            for (int i = 0; i < usernames.Count; i++)
                if (usernames[i] == username)
                    return true;
            return false;
        }

        public bool IsUsernameValid(string username)
        {
            return Regex.IsMatch(username, @"^[a-zA-Z][a-zA-Z0-9]*([._-][a-zA-Z0-9]+)*$");
        }
    }
}
