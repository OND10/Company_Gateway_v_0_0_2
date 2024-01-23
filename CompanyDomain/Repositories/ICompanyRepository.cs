using CompanyDomain.Exception;
using Gateway_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayDomain.Interfaces
{
    public interface ICompanyRepository:IGenericRepository<Company>
    {
        Task<Result<IEnumerable<Company>>> GetAllAsync();
        Task<Result<Company>> AddAsync(Company model);
        Task<Result<Company>> UpdateAsync(Company model);
        Task<Result<Company>> DeleteAsync(Company model);
        Task<Result<Company>> GetByIdAsync(int id);
        Task<Result<Company>> GetByCodeAsync(string code);
        Task<Result<IEnumerable<Company>>> Query(string query);

    }
}
