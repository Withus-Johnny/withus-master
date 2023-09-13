using APIServer.Entitys;
using APIServer.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace APIServer.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(Dictionary<string, string> reqData)
        {            
            if (reqData is null) return BadRequest("요청 데이터가 없습니다.");

            if (!reqData.ContainsKey("Email") ||
                !reqData.ContainsKey("Password") ||
                !reqData.ContainsKey("UserName") ||
                !reqData.ContainsKey("UserPhone") ||
                !reqData.ContainsKey("Recommender") ||
                !reqData.ContainsKey("Advisor"))
                return BadRequest("필수 요소가 누락 되어있습니다.");

            if (string.IsNullOrEmpty(reqData["Email"]) ||
                string.IsNullOrEmpty(reqData["Password"]) ||
                string.IsNullOrEmpty(reqData["UserName"]) ||
                string.IsNullOrEmpty(reqData["UserPhone"]))
                return BadRequest("필수 요소 데이터가 누락 되어있습니다.");

            _logger.LogInformation($"회원가입 시도 : {reqData["Email"]}");

            bool isfoundEmail = await _userService.FindUserEmail(reqData["Email"]);
            bool isFoundPhone = await _userService.FindUserPhone(reqData["UserPhone"]);

            if (isfoundEmail || isFoundPhone)
            {
                _logger.LogInformation($"회원가입 거부 : 이메일 또는 휴대폰 번호 중복");
                return BadRequest("이메일 또는 휴대폰 번호 중복으로 가입 할 수 없습니다.");
            }

            var entity = await _userService.AddUserAsync(reqData["Email"], reqData["Password"],
                                                         reqData["UserName"], reqData["UserPhone"],
                                                         reqData["Recommender"], reqData["Advisor"]);

            if (entity == null)
            {
                _logger.LogInformation($"회원가입 실패 : 데이터 저장 실패");
                return Problem("회원가입에 실패했습니다.");
            }

            _logger.LogInformation($"회원가입 승인 : [UID:{entity.uid}] [EMAIL:{reqData["Email"]}]");
            return Ok(entity);
        }
    }
}
