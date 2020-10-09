using sellcar.entity;
using System.Collections.Generic;

namespace sellcar.business.Abstract
{
    public interface IIlService
    {
        void Create(Il entity);
        void Update(Il entity);
        void Delete(Il entity);
        Il GetById(int id);
        List<Il> GetIller();
        Il GetByIdWithIlanlar(int ilId);
        Il enÇokIlanVerilenIl();
        Il enAzIlanVerilenIl();
    }
}
