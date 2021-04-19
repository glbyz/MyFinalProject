using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression <Func<T, bool>> filter=null);//filtre null tü data listelenir
        T Get(Expression<Func<T, bool>> filter); //tek veri gelmesini istediğimizde bu kod kullanılır ,filter şarttır .
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //List<T> GetAllByCategory(int categoryId); burada yapılan filtrelemeyi  yukarıda expression ile yapacagımız için
                                                    //bu koda ihtiyac kalmadı

    }
}
