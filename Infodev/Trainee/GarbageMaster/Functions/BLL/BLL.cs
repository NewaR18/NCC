using Functions.Data_Link_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Functions.Business_Logic_Layer
{
    public class BLL
    {

        private readonly DLL _dll;
        public BLL()
        {
            _dll = new DLL();
        }
        public string QuickMessage(string Name, string Email, string Subject, string Message)
        {
            return _dll.InsertMessage(Name, Email, Subject, Message);
        }
        public string Register(string FName, string MName, string LName, string Email, string UName, string Password, int Ward)
        {
            return _dll.RegisterUser(FName, MName, LName, Email, UName, Password, Ward);
        }
        public string Login(string UName, string Password)
        {
            string value= _dll.LoginUser(UName, Password);
            if(value== "ValidUser")
            {
                Session("UserName") = UName;
                Session["PassWord"] = Password;
                System.Web.HttpContext.Current.Session["loginId"]
            }
            return value;
        }
    }
}
