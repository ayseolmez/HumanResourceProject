using HumanResourse.DataAccess.Abstract;
using HumanResourse.DataAccess.Context;
using HumanResourse.DataAccess.Repository;
using HumanResourse.Entitiy.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourse.DataAccess.EntityFramework
{
    public class EfPermitDal : GenericRepository<Permit>, IPermitDal
    {
        private readonly HumanResoursesContext _humanResoursesContext;
        public EfPermitDal(HumanResoursesContext context, HumanResoursesContext humanResoursesContext) : base(context)
        {
            _humanResoursesContext = humanResoursesContext;
        }

        public List<Permit> GetListByUserName()
        {
            var values = _humanResoursesContext.Permits.Include("AppUsers").ToList();
            return values;

        }

        public int GetPermitDay(AppUser user)
        {
            
                int izinHakki = 0;
                var calismaZamani = (DateTime.Now - user.HiredDate).TotalDays;

                if (calismaZamani < 1825)
                    izinHakki = 14;

                if (calismaZamani >= 1825 && calismaZamani < 5475)
                    izinHakki = 20;

                if (calismaZamani >= 5475)

                    izinHakki = 26;


                return izinHakki;
            
        }
    }
}
