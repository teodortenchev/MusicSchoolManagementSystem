namespace DubaiMusicSchool.Web.Controllers
{
    using System;
    using System.Net;
    using System.Net.Mail;

    using DubaiMusicSchool.Data.Common.Models;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;

    public class MailerController : Controller
    {
        [HttpPost]
        public IActionResult SendMessage([FromBody]ContactFormModel form)
        {
            if (form == null)
            {
                return this.BadRequest();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    // TO DO: Put this in a config file which is ignored. Don't expose.
                    var credentials = new NetworkCredential("dubaimusicschool2@gmail.com", "Password@123");

                    var mail = new MailMessage()
                    {
                        From = new MailAddress(form.Email),
                        Subject = "Website Inquiry",
                        Body = this.FormattedBody(form.Name, form.Email, form.Phone, form.Message),
                    };

                    mail.IsBodyHtml = true;
                    mail.To.Add(new MailAddress("dubaimusicschool2@gmail.com"));

                    var client = new SmtpClient()
                    {
                        UseDefaultCredentials = false,
                        Host = "mtp.gmail.com",
                        Credentials = credentials,
                        Port = 465,
                        EnableSsl = true,
                    };

                    client.Send(mail);

                    return this.Json(new { success = true, message = "Your message was successfully sent." });
                }
                catch (Exception ex)
                {
                    return this.Json(new { success = false, message = ex.Message });
                }
            }

            return this.BadRequest();
        }

        private string FormattedBody(string name, string email, string phone, string message)
        {
            var senderInfo = String.Format(
                "<b>From</b>: {0}<br/><b>Email</b>: {1}<br/><b>Phone</b>: {2}<br/><br/>",
                name, email, phone);
            return senderInfo + message;
        }

        private bool Validate(string gResponse)
        {
            using (var client = new System.Net.WebClient())
            {
                try
                {
                    // TODO: Don't expose this key. Put it in a separate file which is ignored.
                    string secretKey = "6LfZNvAUAAAAAGH0Vg8wIghQWVMOx5gipNtsz68I";
                    var gReply = client.DownloadString(string.Format(
                            "https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}",
                            secretKey, gResponse));

                    var jsonReturned = JsonConvert.DeserializeObject<ReCaptcha>(gReply);
                    return jsonReturned.Success.ToLower() == "true";
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    }
}