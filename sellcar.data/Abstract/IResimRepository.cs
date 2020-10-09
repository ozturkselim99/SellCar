using sellcar.entity;

namespace sellcar.data.Abstract
{
    public interface IResimRepository:IRepository<Resim>
    {
        Resim GetByUrl(string url);
    }
}
