using StoreMaterial.DataBase;
using StoreMaterial.Helper;
using System;
using System.Linq;

namespace StoreMaterial.Repository.Administrator
{
    public class UserService : IUser
    {
        private KhoNguyenLieuEntities db = new KhoNguyenLieuEntities();
        public bool Login(string un, string pw)
        {
            try
            {
                var check = db.spLogin(un, pw).FirstOrDefault();
                return check > 0;
            }
            catch (Exception ex)
            {
                NlogHelper.Logger.Error(string.Format("Login Error: {0}", ex));
                return false;
            }
        }
    }
}