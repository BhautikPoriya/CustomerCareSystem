using CustomerCareSystem.Models;
using CustomerCareSystem.Models.Domain;
using CustomerCareSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace CustomerCareSystem.Controllers
{
    public class HomeController : Controller
    {
        #region Fields

        private readonly ITokenService _tokenService;
        private readonly IExecutiveService _executiveService;

        #endregion

        #region Ctor 

        public HomeController(ITokenService tokenService,
            IExecutiveService executiveService)
        {
            _tokenService = tokenService;   
            _executiveService = executiveService;
        }

        #endregion

        #region Utils

        private string GetDescription(Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo == null)
            {
                return enumValue.ToString();
            }

            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : enumValue.ToString();
        }

        #endregion

        #region Methods

        public IActionResult Index()
        {
            var enumValues = Enum.GetValues(typeof(Models.Domain.Type))
                .Cast<Models.Domain.Type>()
                .Select(v => new SelectListItem
                {
                    Value = ((int)v).ToString(),
                    Text = GetDescription(v)
                }).ToList();

            return View(enumValues);
        }

        [HttpPost]
        public async Task<IActionResult> Index(string selectedValue)
        {
            var token = new Token()
            {
                TokenId = new Guid(),
                Type = (Models.Domain.Type)int.Parse(selectedValue),
                CustomerName = string.Empty,
                Mobile = string.Empty,
                Status = Status.Pending
            };

            await _tokenService.InsertTokenAsync(token);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Inquiry()
        {
            return View(await _tokenService.GetAllTokenAsync());
        }

        public IActionResult Login()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            var login = await _executiveService.ValidateExecutive(loginModel);
            if (login == null)
                return RedirectToAction(nameof(Login));

            return RedirectToAction(nameof(Executive));
        }

        public async Task<IActionResult> Executive()
        {
            return View();
        }

        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #endregion
    }
}
