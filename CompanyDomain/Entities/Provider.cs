﻿using CompanyDomain.Common;
using CompanyDomain.ValueObject;
using Gateway_Domain.Entities;
using GatewayDomain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GatewayDomain.Entities
{
    public class Provider : AuditableEntity, IBaseValidation, IEmailValidation, IPhoneNumberValidation
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        private ProviderPhoneNumber phonenumber { get; set; } = new ProviderPhoneNumber(string.Empty);
        public string PhoneNumber
        {
            get
            {
                return  phonenumber.Value; 
            }
            set
            {
                phonenumber = new ProviderPhoneNumber(value);
            }
        }
        public string Email { get; set; } = string.Empty;
        public ICollection<Company>? companies { get; set; }
        public ICollection<Service>? services { get; set; }
        public ICollection<Currency>? currencies { get; set; }
        public async Task<string> Emailvalidate()
        {
            string validEmail = IBaseValidation.EmailRegx;
            if (string.IsNullOrWhiteSpace(Email))
            {
                return await Task.FromResult<string>("Please Enter a correct CompanyEmail to be considered");
                //return await Task.FromResult<string>("osama@gmail.com");
            }

            if (!Regex.IsMatch(Email, validEmail))
            {
                return await Task.FromResult<string>("Please Enter a correct CompanyEmail to be considered");
                //return await Task.FromResult<string>("osama@gmail.com");
            }

            return await Task.FromResult<string>("");
        }

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
            if (string.IsNullOrEmpty(EnglishName))
            {
                return await Task.FromResult<string>("Please Enter a correct EnglishName to be considered");
            }
            if (string.IsNullOrEmpty(Name))
            {
                return await Task.FromResult<string>("Please Enter a correct ArabicName to be considered");
            }
            if (Name.Trim().Any())
            {
                return await Task.FromResult<string>("Please Enter a correct ArabicName to be considered");
            }
            if (EnglishName.Trim().Any())
            {
                return await Task.FromResult<string>("Please Enter a correct EnglishName to be considered");
            }

            return await Task.FromResult<string>("");
        }

        public async Task<string> PhoneNumbervalidate()
        {
            string validPhone = IBaseValidation.PhoneNumberRegx;
            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                return await Task.FromResult<string>("Please Enter a correct CompanyPhone to be considered");
            }

            if (!Regex.IsMatch(PhoneNumber, validPhone))
            {
                return await Task.FromResult<string>("Please Enter a correct CompanyPhone to be considered");
            }

            return await Task.FromResult<string>("");
        }

    }
}
