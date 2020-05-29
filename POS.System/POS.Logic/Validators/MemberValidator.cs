using FluentValidation;
using POS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.Validators
{
    public class MemberValidator : AbstractValidator<MemberModel>
    {
        public MemberValidator()
        {
            RuleFor(x => x.Address).NotEmpty();
            RuleFor(x => x.ContactNumber).NotEmpty().MaximumLength(11).MinimumLength(11).Matches(@"^[0][1-9]\d{9}$|^[1-9]\d{10}$");
            RuleFor(x => x.FullName).NotEmpty();
        }
    }
}
