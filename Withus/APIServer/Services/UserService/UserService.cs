using APIServer.Contexts;
using APIServer.Entitys;
using Microsoft.EntityFrameworkCore;

namespace APIServer.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly WithusContext withusDB;

        public UserService(WithusContext withusDB)
        {
            this.withusDB = withusDB;
        }

        public async Task<bool> FindUserEmail(string email)
        {
            var target = await this.withusDB.table_user_info.FirstOrDefaultAsync(x => x.user_email == email);
            if (target == null) return false;
            else return true;
        }

        public async Task<bool> FindUserPhone(string phone)
        {
            var target = await this.withusDB.table_user_info.FirstOrDefaultAsync(x => x.user_phone == phone);
            if (target == null) return false;
            else return true;
        }

        public async Task<Tb_User_Info> FindUserAsync(string email, string password)
        {
            var userInfo = await this.withusDB.table_user_info
                                 .FirstOrDefaultAsync(x => x.user_email == email &&
                                                      x.user_password == password);
            return userInfo;
        }

        public async Task<Tb_User_Info> AddUserAsync(string reqEmail, string reqPassword, string reqUnserName, string reqUserPhone, string reqRecommender, string reqAdvisor)
        {
            string emptyString = "Empty";

            Tb_User_Info newUser = new Tb_User_Info();
            newUser.user_email = reqEmail;
            newUser.user_password = reqPassword;
            newUser.user_name = reqUnserName;
            newUser.user_phone = reqUserPhone;
            newUser.recommender = string.IsNullOrEmpty(reqRecommender) ? emptyString : reqRecommender;
            newUser.advisor = string.IsNullOrEmpty(reqAdvisor) ? emptyString : reqAdvisor;
            newUser.is_activity = true;

            var temp = await this.withusDB.table_user_info.AddAsync(newUser);
            int result = await this.withusDB.SaveChangesAsync();
            if (result == 1)
                return temp.Entity;
            else return null;
        }
    }
}
