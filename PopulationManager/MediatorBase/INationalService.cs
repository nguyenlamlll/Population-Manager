using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Model;

/// <summary>
/// Provide interfaces and models for the need (implementation) of Mediator component.
/// </summary>
namespace MediatorBase
{
    /// <summary>
    /// Provide logic and services relating to national service.
    /// </summary>
    public interface INationalService
    {

        /// <summary>
        /// Validate whether a resident is in national service age range.
        /// </summary>
        /// <returns>Return true if the person is in range, return false if otherwise.</returns>
        Task<bool> IsInNationalServiceAgeRange(Resident resident, int minAge, int maxAge);
    }
}
