using GatewayDomain.Interfaces;
using GatewayDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Gateway_Domain.Entities;
using CompanyDomain.Exception;
using CompanyXUnit.Core.Domain.Shared;

namespace CompanyXUnit.Core.Domain.Interfaces
{
    public class UnitTest_Domain_CompanyRepo:MockedEntities
    {
        private readonly Mock<ICompanyRepository> _mock;
        public UnitTest_Domain_CompanyRepo()
        {
            _mock = new Mock<ICompanyRepository>();
        }

        [Fact]
        public async Task Domain_Company_Test_AddAsync_Method()
        {

            //Arrange
            _mock.Setup(repo => repo.AddAsync(It.IsAny<Company>())).ReturnsAsync(await Result<Company>.Success("Added Successfully"));

            //Acting
            ICompanyRepository companyRepository = _mock.Object;
            var actualed_value = await companyRepository.AddAsync(company);

            //Asserting
            Assert.NotNull(actualed_value);
        }

        [Fact]
        public async Task Domain_Company_Test_GetAllAsync_Method()
        {

            //Arrange
            //_mock.Setup(repo => repo.AddAsync(It.IsAny<Company>())).ReturnsAsync(await Result<Company>.Success("Added Successfully"));
            _mock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(await Result<IEnumerable<Company>>.Success("View Successfully"));

            //Acting
            ICompanyRepository companyRepository = _mock.Object;
            var actualed_value = await companyRepository.GetAllAsync();

            //Asserting
            Assert.NotNull(actualed_value);
        }



    }
}
