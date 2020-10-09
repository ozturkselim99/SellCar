using sellcar.entity;
using System.Collections.Generic;

namespace sellcar.data.Abstract
{
    public interface IMarkaRepository:IRepository<Marka>
    {
        List<Marka> GetMarkalar();
        Marka GetByIdWithIlanlar(int markaId);
    }
}
