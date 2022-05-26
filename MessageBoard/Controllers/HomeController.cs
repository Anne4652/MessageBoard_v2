using MessageBoard.Models;
using MessageBoard.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MessageBoard.Services.Interfaces;

namespace MessageBoard.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageService _messageService;

        public HomeController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
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

        public async Task AddNewMessage(Message message)
        {
            await _messageService.AddNewMessage(message);
        }
    }
}