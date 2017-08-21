using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.AbstractService
{
    public interface IResidentDBService
    {
        /// <summary>
        /// Get Age of required person using Id.
        /// </summary>
        /// <param name="Id">Id number of a person.</param>
        /// <returns></returns>
        Task<int> GetAge(long Id);

        Task<string> GetFullName();
    }
}
