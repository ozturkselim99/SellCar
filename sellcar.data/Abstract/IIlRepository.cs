using sellcar.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace sellcar.data.Abstract
{
    public interface IIlRepository:IRepository<Il>
    {
        List<Il> GetIller();
        Il GetByIdWithIlanlar(int ilId);
        Il enÇokIlanVerilenIl();
        Il enAzIlanVerilenIl();
    }
}
