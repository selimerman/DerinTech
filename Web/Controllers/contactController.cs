using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Net.Mail;
using Web.Models;

namespace Web.Controllers
{
    public class contactController : Controller
    {
        private readonly ILogger<contactController> _logger;
        private readonly IConfiguration _configuration;

        public contactController(ILogger<contactController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendContactForm(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.To.Add(_configuration["EmailSettings:ToAddress"]); // Hedef e-posta adresi
                    mailMessage.Subject = "İletişim Formu Mesajı - Yeni Mesaj";
                    mailMessage.Body = $"Ad Soyad: {model.Ad}<br>Email: {model.Email}<br>Mesaj: {model.Mesaj}";
                    mailMessage.IsBodyHtml = true;

                    // Gönderen e-posta adresi
                    mailMessage.From = new MailAddress(_configuration["EmailSettings:FromAddress"]);

                    // Webmail hesabınıza ait e-posta adresi ve şifresi
                    NetworkCredential credentials = new NetworkCredential(
                        _configuration["EmailSettings:FromAddress"],
                        _configuration["EmailSettings:Password"]
                    );

                    SmtpClient smtpClient = new SmtpClient("mail.agarthateknoloji.com.tr");
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = credentials;
                    smtpClient.Port = 587; // Webmail'in SMTP portu
                    smtpClient.EnableSsl = false; // SSL/TLS kullanılacak mı?

                    smtpClient.Send(mailMessage);

                    TempData["Message"] = "Mesajınız gönderildi. En kısa sürede size geri dönüş yapılacaktır.";
                }
                catch (Exception ex)
                {
                    TempData["Message"] = "Mesaj gönderilemedi. Hata nedeni: " + ex.Message;
                }
            }
            else
            {
                TempData["Message"] = "Form geçersiz. Lütfen tüm gerekli alanları doldurun.";
            }

            return RedirectToAction("Index");
        }
    }
}
