using Infrastructure.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Implementations
{
    public class MessagesService : IMessagesService
    {
        private readonly IMessagesRepository _messagesRepository;

        public MessagesService(IMessagesRepository messagesRepository)
        {
            _messagesRepository = messagesRepository;
        }
        public List<Messages> GetMessages()
        {
            return _messagesRepository.GetMessages();
        }
        public void AddMessage(Messages newMessage)
        {
            _messagesRepository.AddMessage(newMessage);
        }
    }
}
