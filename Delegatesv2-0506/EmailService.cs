using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatesv2_0506
{
    internal class EmailService
    {
        public delegate void EmailSentDelegate(double timeElapsed);

        private EmailSentDelegate _emailSentDelegate;

        public EmailService(EmailSentDelegate emailSent)
        {
            _emailSentDelegate = emailSent;
        }

        public string? To { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }

        public void SendEmail()
        {
            var timeElapsed = 2d;
            Thread.Sleep(5000);

            if (_emailSentDelegate != null)
            {
                _emailSentDelegate(timeElapsed);
            }
        }
    }
}
