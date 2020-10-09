using sellcar.entity;

namespace sellcar.business.Abstract
{
    public interface IResimService
    {
        void Create(Resim entity);
        void Update(Resim entity);
        void Delete(Resim entity);
        Resim GetById(int id);
        Resim GetByUrl(string url);
    }
}
