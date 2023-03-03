using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
                                      //IGenericService----> Icinde Ekle Sil Guncelle var
                                      //IGenericService<About> ---> Icinde About icinde gelen Entityler 
                                      //                        Yani o bolumun tuttugu ozellikler var
                                      //                  About icinde gelen ozelliklerle crud islemleri
                
                                            
    public interface IAboutService : IGenericService<About>
    {
        
    }
}
