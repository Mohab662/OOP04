using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interfaces_Q03
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
