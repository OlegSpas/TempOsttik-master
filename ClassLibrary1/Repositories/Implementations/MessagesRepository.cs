using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Implementations
{
    public class MessagesRepository : IMessagesRepository
    {
        private readonly PritulokDBContext _dBContext;

        public MessagesRepository(PritulokDBContext dbContext)
        {
            _dBContext = dbContext;
        }

        public List<Messages> GetMessages()
        {
            return _dBContext.Messages.ToList();
        }
        public void AddMessage(Messages newMessage)
        {
            _dBContext.Messages.Add(newMessage);
            _dBContext.SaveChanges();
        }
    }
}
