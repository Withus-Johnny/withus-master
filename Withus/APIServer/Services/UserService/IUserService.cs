using APIServer.Entitys;

namespace APIServer.Services.UserService
{
    public interface IUserService
    {
        Task<bool> FindUserEmail(string email);
        Task<bool> FindUserPhone(string phone);

        Task<Tb_User_Info> FindUserAsync(string email, string password);
        Task<Tb_User_Info> AddUserAsync(string reqEmail, string reqPassword, string reqUnserName, string reqUserPhone, string ReqRecommender, string reqAdvisor);
    }
}
