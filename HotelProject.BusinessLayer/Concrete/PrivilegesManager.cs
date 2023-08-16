using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class PrivilegesManager : IPrivilegesServices
    {
        private readonly IPrivilegesDal _privilegesDal;

        public PrivilegesManager(IPrivilegesDal privilegesDal)
        {
            _privilegesDal = privilegesDal;
        }

        public void TDelete(Privileges t)
        {
            _privilegesDal.Delete(t);
        }

        public Privileges TGetByID(int id)
        {
            return _privilegesDal.GetByID(id);
        }

        public List<Privileges> TGetList()
        {
            return _privilegesDal.GetList();
        }

        public void TInsert(Privileges t)
        {
            _privilegesDal.Insert(t);
        }

        public void TUpdate(Privileges t)
        {
            _privilegesDal.Update(t);
        }
    }
}
