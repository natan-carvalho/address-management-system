using Newtonsoft.Json;

namespace AeCAddress.Helpers
{
    public class MySession : IMySession
    {
        private readonly IHttpContextAccessor _httpContext;
        public MySession(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }
        public void CreateSession(UserModel user)
        {
            string userJsonString = JsonConvert.SerializeObject(user);
            _httpContext.HttpContext!.Session.SetString("sessionLogin", userJsonString);
        }

        public UserModel GetSession()
        {
            string? userSession = _httpContext.HttpContext?.Session.GetString("sessionLogin");
            if (string.IsNullOrEmpty(userSession)) return null;

            return JsonConvert.DeserializeObject<UserModel>(userSession)!;
        }

        public void RemoveSession()
        {
            _httpContext.HttpContext!.Session.Remove("sessionLogin");
        }
    }
}