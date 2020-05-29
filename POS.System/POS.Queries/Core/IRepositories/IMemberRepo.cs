using POS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.IRepositories
{
    public interface IMemberRepo : IRepository<Member>
    {


        IEnumerable<Member> GetAllBy(string criteria);

        Member Get(string memberName);
    }
}
