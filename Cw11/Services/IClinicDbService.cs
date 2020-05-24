using System.Collections;
using Cw11.DTOs;
using Cw11.Models;

namespace Cw11.Services
{
    public interface IClinicDbService
    {
        public IEnumerable GetDoctors();
        public Doctor AddDoctor(AddDoctorRequest request);
        public Doctor ModifyDoctor(ModifyDoctorRequest request);
        public Doctor DeleteDoctor(int id);
    }
}