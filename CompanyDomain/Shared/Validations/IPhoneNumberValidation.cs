﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDomain.Common
{
    public interface IPhoneNumberValidation
    {
        Task<string> PhoneNumbervalidate();
    }
}
