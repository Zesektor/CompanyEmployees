﻿using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface ICompanyRepository
    {
         IEnumerable<Company> GetAllCompanies(bool trackChanges);
         void AnyMethodFromCompanyRepository();
    }
}
