using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AeCAddress.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string? sessionUser = HttpContext.Session.GetString("sessionLogin");
            if (string.IsNullOrEmpty(sessionUser)) return null;

            UserModel? user = JsonConvert.DeserializeObject<UserModel>(sessionUser);
            return await Task.Run(() => View(user));
        }
    }
}