﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopApp.services
{
    public class NullMailService : IMailService
    {
        private ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;

        }
        public void SendMessage(string to, string subject, string body)
        {
            _logger.LogInformation($"To: { to} subject {subject} body: {body} "); 
        }
        //public void sendMessage { get; set; }
    }
}
