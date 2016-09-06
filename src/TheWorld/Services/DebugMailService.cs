using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace TheWorld.Services
{
    public class DebugMailService : IMailService
    {
        public void SendMail(string from, string to, string subject, string message)
        {
            Debug.WriteLine($"Sending mail from{from} to {to} Subject{subject}, Message {message}");
        }
    }
}
