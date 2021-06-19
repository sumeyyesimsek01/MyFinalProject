using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{   //generic constraint(generic kısıtı)
    //class: referans tip olmalı diyor
    //IEntity: ientity veya ientity implemente eden bir nesne olmalı.
    //new: newlenebilir olmalı. IEntity newlenemediği için sadece implemente edilenleri kullanmak için.

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {//Ürünleri filtrelemek için kullanılan yapı.
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
