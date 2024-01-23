﻿using CompanyDomain.Entities;
using CompanyXUnit.Core.Domain.Shared;
using GatewayDomain.Common;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyXUnit.Core.Domain
{
    public class UnitTest_Domain_Location_Properties_Validation
    {
        private readonly Mock<IUnitofTest> _Utest;
        public UnitTest_Domain_Location_Properties_Validation()
        {
            _Utest = new Mock<IUnitofTest>();
        }

        [Theory]
        [InlineData("TharwatCompany")]
        public async Task Domain_Location_English_Name_Validation_Test_Method(string defaultname)
        {
            //Arrange
            Location location = new Location();
            _Utest.Setup(demo => demo.baseValidation.Namevalidate()).ReturnsAsync(await location.Namevalidate());

            //Acting
            IUnitofTest baseValidation = _Utest.Object;
            var actualed_value = baseValidation.baseValidation.Namevalidate();

            //Asserting
            Assert.NotNull(actualed_value);
            Assert.Matches(IBaseValidation.NameRegex, defaultname);
        }


        [Theory]
        [InlineData("12433")]
        //[InlineData("12433asas")]
        public async Task Domain_Location_Id_Validation_Test_Method(string defaultnumber)
        {
            //Arrange
            Location location = new Location();
            _Utest.Setup(demo => demo.baseValidation.Idvalidate()).ReturnsAsync(await location.Idvalidate());

            //Acting
            IUnitofTest baseValidation = _Utest.Object;
            var actualed_value = baseValidation.baseValidation.Idvalidate();

            //Asserting
            Assert.NotNull(actualed_value);
            Assert.Matches(IBaseValidation.IdRegex, defaultnumber);
        }

    }
}
