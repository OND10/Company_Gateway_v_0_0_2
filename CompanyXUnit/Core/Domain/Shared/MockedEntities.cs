using Gateway_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompanyXUnit.Core.Domain.Shared
{
    public class MockedEntities
    {

        //Company
        public Company company = new Company
        {
            Id = 1,
            ArabicName = "ثروات",
            EnglishName = "Tharwat",
            Email = "tharwat@gmail.com",
            Address = "Almasbahi Round behind NiceWare"

        };

        public List<Company> companylist = new List<Company>()
        {
                new Company
                {
                    Id = 1,
                    ArabicName = "ثروات",
                    EnglishName = "Tharwat",
                    Email = "tharwat@gmail.com",
                    Address = "Almasbahi Round behind NiceWare"
                },

                new Company
                {
                    Id = 3,
                    ArabicName = "النجم",
                    EnglishName = "Alnajm",
                    Email = "najm@gmail.com",
                    Address = "AlDiari Round "
                },

        };


    }
}
