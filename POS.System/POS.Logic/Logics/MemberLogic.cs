using FluentValidation.Results;
using Helpers;
using POS.Logic.ILogics;
using POS.Logic.Models;
using POS.Logic.Validators;
using POS.Queries.Core.Domain;
using POS.Queries.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.Logics
{
    public class MemberLogic : IMemberLogic
    {
        public MemberLogic() { }






        public void Edit(int memberID, MemberModel model)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Members.Get(memberID);
                obj.Address = model.Address;
                obj.ContactNumber = model.ContactNumber;
                obj.FullName = model.FullName;
                uow.Members.Edit(obj);
                uow.Complete();
            }

        }

        public void Add(MemberModel model)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {

               
                    var obj = new Member();
                    obj.Address = model.Address;
                    obj.ContactNumber = model.ContactNumber;
                    obj.FullName = model.FullName;
                    uow.Members.Add(obj);
                    uow.Complete();
               
                

            }
        }


        public MemberModel Get(int memberID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Members.Get(memberID);
                var model = new MemberModel();
                if (obj != null)
                {
                    model.Address = obj.Address;
                    model.FullName = obj.FullName;
                    model.ContactNumber = obj.ContactNumber;
                }
                return model;
            }
        }

        
        public List<MemberModel> GetAllBy(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.Members.GetAllBy(criteria);
                var models = new List<MemberModel>();
                foreach (var item in objs)
                {
                    var model = new MemberModel();
                    model.ID = item.MemberID;
                    model.Address = item.Address;
                    model.FullName = item.FullName;
                    model.ContactNumber = item.ContactNumber;
                    models.Add(model);
                }
               
                return models;
            }
        }


        public void Delete(int memberID)
        {
            // default record walk in must not delete
            if (memberID == 1)
            {
                throw new ApplicationException("Default Customer Walk-In can't be deleted!");
            }
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Members.Get(memberID);

                if (obj != null)
                {
                    uow.Members.Remove(obj);
                    uow.Complete();
                }
                
            }
        }


        public List<string> GetAllFullNamesOnly()
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.Members.GetAll();
                var names = new List<string>();
                foreach (var item in objs)
                {
                    names.Add(item.FullName);
                }
                return names;
            }
        }


        public MemberModel Get(string memberName)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.Members.Get(memberName);
                var model = new MemberModel();
                if (obj != null)
                {
                    model.Address = obj.Address;
                    model.FullName = obj.FullName;
                    model.ContactNumber = obj.ContactNumber;
                    model.ID = obj.MemberID;
                }
                return model;
            }
        }
    }
}
