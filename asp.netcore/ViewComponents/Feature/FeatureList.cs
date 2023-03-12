using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcore.ViewComponents.Feature
{
    public class FeatureList:ViewComponent  /*ViewCompnonets dersem namaspace ceker*/
    {

        FeatureManager featureManager = new FeatureManager(new EfFeautureDal()); 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    //o bolumu burdaki feature list ile parcaladaik bu metot
    //    sadece araci invoke seklinde 
    //    C:\Users\Casper\source\repos\asp.netcore\asp.netcore\Pages\Shared
    //    \Components\FeatureList\

    //    bu adrese gidip kontrol ediyor
}
