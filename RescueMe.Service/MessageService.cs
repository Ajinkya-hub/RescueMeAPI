using RescueMe.Models;
using RescueMe.Repository.Interface;
using RescueMe.Service.Interface;
using System.Configuration;

namespace RescueMe.Service
{

    public class MessageService : IMessageService
    {
        IMessageRepository _messageRepo;
        public MessageService(IMessageRepository messageRepo)
        {
            _messageRepo = messageRepo;
        }

       public bool SendMessage(smsModel message) {
            MessageConfiguration Msgconfig = new MessageConfiguration {
                AccountSID = ConfigurationManager.AppSettings.Get("accountSID"),
                AuthToken = ConfigurationManager.AppSettings.Get("authToken"),
                FromMobileNo = ConfigurationManager.AppSettings.Get("fromMobileNo"),
                MobileMessageText = ConfigurationManager.AppSettings.Get("mobileMessageText")
            };
            
            return _messageRepo.SendMessage(message, Msgconfig);
        }

    }
}
