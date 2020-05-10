using RescueMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueMe.Repository.Interface
{
    public interface IMessageRepository
    {
        bool SendMessage(smsModel user, MessageConfiguration Msgconfig);
    }
}
