using sellcar.business.Abstract;
using sellcar.data.Abstract;
using sellcar.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace sellcar.business.Concrete
{
    public class IlManager : IIlService
    {
        private IIlRepository _IilRepository;
        public IlManager(IIlRepository Iilrepository)
        {
            _IilRepository = Iilrepository;
        }
        public void Create(Il entity)
        {
            _IilRepository.Create(entity);
        }

        public void Delete(Il entity)
        {
            _IilRepository.Delete(entity);
        }

        public Il enAzIlanVerilenIl()
        {
           return _IilRepository.enAzIlanVerilenIl();
        }

        public Il enÇokIlanVerilenIl()
        {
            return _IilRepository.enÇokIlanVerilenIl();
        }

        public Il GetById(int id)
        {
            return _IilRepository.GetById(id);
        }

        public Il GetByIdWithIlanlar(int ilId)
        {
            return _IilRepository.GetByIdWithIlanlar(ilId);
        }

        public List<Il> GetIller()
        {
            return _IilRepository.GetIller();
        }

        public void Update(Il entity)
        {
            _IilRepository.Update(entity);
        }
    }
}
