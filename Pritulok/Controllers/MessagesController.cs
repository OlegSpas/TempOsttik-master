using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

namespace Pritulok.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MessagesController : ControllerBase
    {
        private readonly IMessagesService _messagesService;
        public MessagesController(IMessagesService messagesService)
        {
            _messagesService = messagesService;
        }
        [HttpGet]
        public IEnumerable<Messages> GetAll()
        {
            return _messagesService.GetMessages().ToArray();
        }
        [HttpPost]
        public void AddMessage(Messages newMessage)
        {
            _messagesService.AddMessage(newMessage);
        }
    }
}
