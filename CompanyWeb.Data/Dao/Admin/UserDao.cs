using CompanyWeb.Data.EF;
using CompanyWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWeb.Data.Dao.Admin
{
    public class UserDao
    {
        private readonly CompanyDbContext _context;
        public UserDao(CompanyDbContext context)
        {
            _context = context;
        }

        public byte Login(string username, string password, ref string returnText, ref int IDUser)
        {
            byte res = 0;
            IDUser = 0;
            var user = _context.dUsers.FirstOrDefault(x => x.Username == username && x.Status != 10);
            if (user == null)
            {
                res = 0;
                returnText = "Tài khỏa không tồn tại trong hệ thống, vui lòng thử lại!";
            }
            else
            {
                if(user.Password != password)
                {
                    res = 0;
                    returnText = "Tài khỏa không tồn tại trong hệ thống, vui lòng thử lại!";
                }
                else
                {
                    if (user.Status != 1)
                    {
                        res = 0;
                        returnText = "Có lỗi xảy ra, đăng nhập không thành công, vui lòng thử lại sau!";
                    }
                    else
                    {
                        res = 1;
                        IDUser = user.ID;
                        returnText = "Đăng nhập thành công! Xin chào " + user.Name;
                    }
                }
            }
            return res;
        }

        public dUser getUserDetail(int ID)
        {
            return _context.dUsers.FirstOrDefault(x => x.ID == ID);
        }
    }
}
