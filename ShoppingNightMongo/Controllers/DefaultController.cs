using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Models;
using ShoppingNightMongo.Services.ProductServices;
using MimeKit;
using MailKit.Net.Smtp;

namespace ShoppingNightMongo.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IProductService _productService;

        public DefaultController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var products = await _productService.GetAllProductsAsync(); // NULL dönmemeli
            return View(products);
        }
        [HttpPost]
        public IActionResult SendMail(AdminMailViewModel model)
        {
            model.Subject = "✨ Shopping| Bülten Aboneliğiniz Aktif!";

            var discountRate = "Shoopping20";
            model.DiscountCoupon = discountRate;

            model.Message = $"Shopping  özel kampanyalarından ve yeni ürünlerinden haberdar olmanız için haber bültenimize başarıyla abone oldunuz." +
                $" \n\n🎁 Size özel bir indirim kuponumuz var!\n\nKupon Kodu: {model.DiscountCoupon}\nİndirim: %20\nGeçerlilik: Tüm ürünlerde\n\nKuponunuzu hemen kullanarak alışverişin keyfini çıkarın! 👉" +
                $"  https://www.Shopping.com.trr\n\nEğer herhangi bir sorunuz varsa, bizimle iletişime geçmekten çekinmeyin. " +
                $"\n\nKeyifli alışverişler dileriz!\n\nSevgilerle,\nCoza Store Ekibi";
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Shopping Kağan", "projectsdotnet1@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Message;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            client.Authenticate("ikagancevik@gmail.com", "egzm xgkj defr chvi");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return RedirectToAction("Index");
        }
    }
}
