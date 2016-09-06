﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWorld.Services
{
   public interface IMailService
    {
        void SendMail(string from, string to, string subject, string message);
    }
}
