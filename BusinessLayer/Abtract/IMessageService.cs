using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abtract
{
    public interface IMessageService
    {
        List<Message> GetListInboxAdmin();
        List<Message> GetListInbox(string p);
        List<Message> GetListSendboxAdmin();
        List<Message> GetListSendbox(string p);
        void MessageAdd(Message message);
        Message GetByID(int id);
        void MessageDelete(Message message);
        void MessageUpdate(Message message);
    }
}
