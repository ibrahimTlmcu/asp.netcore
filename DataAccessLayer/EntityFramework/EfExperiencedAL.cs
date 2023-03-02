using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    internal class EfExperiencedAL:GenericRepository<Experince>,IExperinceDal
    {
    }
}





//GenericRepository metotlar tutuluyor ekle sil guncelle getir vs icinde bunlari 

//(GenericRepository<T> : IGenericDal<T> where T : class) icinde bu yapi ile tutuyor

//<Experionce> entity almis oluyor

//IExperinceDal icinde metot isimleri var ozellileri tanimli 

