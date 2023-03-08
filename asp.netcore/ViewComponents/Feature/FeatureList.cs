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
}
