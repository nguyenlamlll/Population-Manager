using MediatorBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer.Model;
using DataLayer.AbstractService;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// Provide methods that manage National Service business requirement.
    /// </summary>
    public class NationalServiceMediator : INationalService
    {
        private readonly IResidentDBService residentDBService;

        /// <summary>
        /// Default constructor (for testing).
        /// </summary>
        public NationalServiceMediator() { }

        public NationalServiceMediator(IResidentDBService residentDBService)
        {
            this.residentDBService = residentDBService;
        }

        async Task<bool> INationalService.IsInNationalServiceAgeRange(Resident resident, int minAge, int maxAge)
        {
            int age = await residentDBService.GetAge(resident.ResidentId);
            if ((age <= maxAge) && (age >= minAge))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
