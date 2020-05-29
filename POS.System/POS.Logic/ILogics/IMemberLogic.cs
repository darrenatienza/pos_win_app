using POS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.ILogics
{
    public interface IMemberLogic
    {



        void Edit(int memberID, MemberModel model);

        void Add(MemberModel model);

        MemberModel Get(int memberID);

        List<MemberModel> GetAllBy(string p);

        void Delete(int memberID);

        List<string> GetAllFullNamesOnly();

        MemberModel Get(string memberName);
    }
}
