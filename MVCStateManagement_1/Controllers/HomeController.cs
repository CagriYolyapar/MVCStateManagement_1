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
            #region SessionState
            //SessionState => Sunucu(server) tarafında siteye baglanan her bir kullanıcı icin olusturulan ayrı bir hafıza bölgesidir...Bu kullanıcı ile ilgili bazı bilgileri saklamak istiyorsak (giriş yapan kullanıcı nesnesi, sepeti , özel nesneler) bunu Session dedigimiz alanlarda  yaparız...Session kullanıcı bazlı olusur...Eger siz girdiginizde Session yaratılırsa o anki kullanıcıya (size) özel bir hafıza alanı yaratılır....
            #endregion


            Session["oturum"] = 1;

            return View();
        }

        [HttpPost]
        public ActionResult SessionState(string veri)
        {
            Session["deneme"] = veri;
            return RedirectToAction("SessionTest");
        }

        public ActionResult SessionTest()
        {
            return View();
        }
        
        public ActionResult LogOut()
        {
            //Session.Clear() bu ifade varolan bütün Session nesnelerini temizler...
            if(Session["deneme"] != null)
            {
                Session.Remove("deneme"); //ilgili oturumda sadece bu key'e sahip olan Session'u temizler...
            }

            return RedirectToAction("SessionTest");
           
        }
       
    }
}