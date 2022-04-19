using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStateManagement_1.Controllers
{
    public class HomeController : Controller
    {

        /*
                State Management(Durum YÖnetimi) => İkiye ayrılırlar(Server side,client side)

        Server Side'daki durum yönetimleri => Session ve Application State'lerdir...

        1) Session her kişi icin ayrı bir oturum alanında saklanan verileri tutar...
        2) Application State herkesin görecegi bir state'tir...

        Client Side'daki durum yönetimleri => Cookie ve cache

        1) Cookie , remember me vs.. durumlarında ilgili alanlara kullanıcı isminiz ve şifrenizi tekrar yazmaktansa browser'inizin cerezlerinde bunları kaydetmenizi saglayarak oradan bu bilgileri getirir...Browser bazlı calısır...

        2) Cache => Performans yönetimi icin (class list vs) server'in degil Client'in sistemini kullanarak karsınıza veri getirmei daha kolay bir hale sokan yapılardır...
         
         
         
         */


        public ActionResult SessionState()
        {
            return View();
        }

       
    }
}