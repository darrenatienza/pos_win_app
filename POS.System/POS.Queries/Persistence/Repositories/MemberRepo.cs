using POS.Queries.Core.Domain;
using POS.Queries.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace POS.Queries.Persistence.Repositories
{
    public class MemberRepo : Repository<Member>, IMemberRepo
    {
        public MemberRepo(DataContext context)
            :base(context)
        {

        }
        public DataContext DataContext
        {
            get
            {
                return Context as DataContext;
            }
        }



        public IEnumerable<Member> GetAllBy(string criteria)
        {
            return DataContext.Members.Where(x => x.FullName.Contains(criteria) && x.Address.Contains(criteria));
        }


        public Member Get(string memberName)
        {
            return DataContext.Members.FirstOrDefault(x => x.FullName == memberName);
        }
    }
}
