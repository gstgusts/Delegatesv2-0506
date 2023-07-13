using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatesv2_0506
{
    internal class PolicyService
    {
        public void SendEmail() {
            var to = "gusts.rcs@gmail.com";
            var subject = "Blalalalalasw";
            var body = "asdfa sdfas dfasdf asdf";

            var emailService = new EmailService(EmailSent);

            emailService.SendEmail();
        }

        private void EmailSent(double timeElapsed)
        {
            Console.WriteLine("Email was sent in " + timeElapsed);
        }
    }
}
