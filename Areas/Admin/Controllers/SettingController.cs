﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MadhuBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class SettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
