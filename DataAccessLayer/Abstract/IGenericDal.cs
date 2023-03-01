using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class  /*T clasa dair butun ozellikleri*/ 
    //                                                alabilir entity gelen degeri gonderiyoruz
    {

        //Generic yapi Her bir entity yerine ayri  ayri yapi tanimlamak yerine tek bir cati tanimlamak

        void Insert(T t);

        void Delete(T t);

        void Update(T t);

        List<T> GetList();

        T GetById(int id); /*T turunde idye gore getir int turunde id al*/




    }
}
