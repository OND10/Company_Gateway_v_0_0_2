﻿using GatewayDomain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayDomain.Entities
{
    public class Products: AuditableEntity, IBaseValidation
    {

        [Key]
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Amount {  get; set; }
        public int CategoryId {  get; set; }

        public async Task<string> Idvalidate()
        {
            if (Id == null)
            {
                return await Task<string>.FromResult("Please Enter an Id");
            }
            return await Task.FromResult<string>("");
        }

        public async Task<string> Namevalidate()
        {
            if (string.IsNullOrEmpty(Name))
            {
                return await Task.FromResult<string>("Please Enter a correct Name to be considered");
            }
            if (Name.Trim().Any())
            {
                return await Task.FromResult<string>("Please Enter a correct Name to be considered");
            }
            return await Task.FromResult<string>("");
        }
    }
}
