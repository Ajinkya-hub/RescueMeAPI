using RescueMe.Models;

namespace RescueMe.Service.Interface
{
    public interface IMessageService
    {
        bool SendMessage(smsModel message);
    }
}
