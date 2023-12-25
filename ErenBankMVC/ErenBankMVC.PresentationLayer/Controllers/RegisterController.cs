using ErenBankMVC.DtoLayer.Dtos.AppUserDtos;
using ErenBankMVC.EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace ErenBankMVC.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if(ModelState.IsValid)
            {
                Random random = new Random();
                int code = random.Next(100000, 1000000);

                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegisterDto.Username,
                    Name = appUserRegisterDto.Name,
                    Surname = appUserRegisterDto.Surname,
                    Email = appUserRegisterDto.Email,
                    City = "İstanbul",
                    District = "Ataşehir",
                    ImageUrl = "Resim",
                    ConfirmCode = code
                };

                var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);

                if (result.Succeeded) 
                {

                    MimeMessage mimeMessage = new MimeMessage();
                    MailboxAddress mailboxAddressFrom = new MailboxAddress("Eren Bank Admin", "erenincedayi@gmail.com");
                    MailboxAddress mailboxAddressTo = new MailboxAddress("User", appUser.Email);

                    mimeMessage.From.Add(mailboxAddressFrom);
                    mimeMessage.To.Add(mailboxAddressTo);

                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = "Kayıt işlemini gerçekleştirmek için onay kodunuz : " + code;
                    mimeMessage.Body = bodyBuilder.ToMessageBody();

                    mimeMessage.Subject = "Eren Bank - Onay Kodu";

                    SmtpClient Client = new SmtpClient();
                    Client.Connect("smtp.gmail.com", 587, false);
                    Client.Authenticate("erenincedayi@gmail.com", "sebssznrhzzycrwj");
                    Client.Send(mimeMessage);
                    Client.Disconnect(true);



                    return RedirectToAction("Index", "ConfirmMail");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View();
        }
    }
}
