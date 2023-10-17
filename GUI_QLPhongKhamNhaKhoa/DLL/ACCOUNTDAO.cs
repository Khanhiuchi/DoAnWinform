using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class ACCOUNTDAO
    {
        private NhaKhoaModel dbContext;
       
        public ACCOUNTDAO(){
            dbContext = new NhaKhoaModel();
         }

        //public bool CheckAccess(String userName, String password)
        //{
        //    var user = dbContext.ACCOUNTs.FirstOrDefault(u => u.USERNAME == userName);
        //    if (user == null)
        //    {
        //        return false; // Người dùng không tồn tại
        //    }

        //    // Kiểm tra mật khẩu của người dùng
        //    if (user.PASSWORD == password)
        //    {
        //        return true; // Có quyền truy cập
        //    }

        //    return false; // Không có quyền truy cập
        //}

        public bool AuthenticateUser(string username, string password)
        {

            using (NhaKhoaModel dbContext = new NhaKhoaModel())
            {
                ACCOUNT user = dbContext.ACCOUNTs.FirstOrDefault(u => u.USERNAME == username && u.PASSWORD == password);
                return user != null;
            }
        }

        public string GetUserRole(string username)
        {
            using (NhaKhoaModel dbContext = new NhaKhoaModel())
            {
                ACCOUNT user = dbContext.ACCOUNTs.FirstOrDefault(u => u.USERNAME == username);
                return user?.TYPE;
            }
        }
    }
}
