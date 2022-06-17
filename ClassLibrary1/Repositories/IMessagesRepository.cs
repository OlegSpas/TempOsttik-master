using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IMessagesRepository
    {
        public List<Messages> GetMessages();
        public void AddMessage(Messages newMessage);
    }
}
