using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDomain.ValueObject
{
    public class ProviderPhoneNumber
    {
        public string Value {  get; set; } = string.Empty;

        public ProviderPhoneNumber(string value)
        {
            Value = value;
        }
    }
}
