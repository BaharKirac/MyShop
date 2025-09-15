using Microsoft.AspNetCore.Mvc;  //MVC yapısını kullanmak için gerekli kütüphaneyi projeye dahil eder.

namespace MyShop.Controllers  //Bu dosyanın MyShop projesindeki Controllers klasörüne ait olduğunu belirtir.
{
    public class HomeController : Controller  //HomeController sınıfı Controller sınıfından miras alır. Böylece bu sınıf, HTTP isteklerini işleyebilir.
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}

/*Varsayılan action metodu.

/Home/Index adresine gidildiğinde bu metot çalışır.

return View(); → Views/Home/Index.cshtml dosyasını döndürür. */


/*MVC Mimarisi Açıklaması

MVC, uygulamayı 3 ana katmana ayıran bir tasarım desenidir:

Model (Veri ve İş Mantığı)

Uygulamadaki veriyi ve iş mantığını temsil eder.

Örnek: Item.cs dosyasında ürün bilgilerini saklamak.

View (Görünüm)

Kullanıcıya gösterilen arayüzdür.

Örnek: Index.cshtml dosyası.

Controller (Denetleyici)

Kullanıcıdan gelen istekleri alır.

Gerekirse Model’den veri çeker.

Son olarak veriyi View’a gönderir. */