﻿using COO.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COO.Application.Config.CountryShip
{
    public interface ICountryShipService
    {
        Task<List<TblCountryShip>> GetListAll();
        Task<Guid> Create(TblCountryShip request);
        Task<int> Update(Guid id, TblCountryShip request);
        Task<int> Delete(Guid id);
        Task<TblCountryShip> GetById(Guid id);
        Task<string> GetCountryByName(string countryName);
        Task<int> InsertList(List<TblCountryShip> listCountry);

    }
}
