using sellcar.entity;
using System.Collections.Generic;

namespace sellcar.business.Abstract
{
    public interface IMarkaService
    {
        void Create(Marka entity);
        void Update(Marka entity);
        void Delete(Marka entity);
        Marka GetById(int id);
        List<Marka> GetMarkalar();
        Marka GetByIdWithIlanlar(int markaId);
    }
}
