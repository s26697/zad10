using WebApplication10.DTOs;
using WebApplication10.Enums;

namespace WebApplication10.Services;

public interface IPharmacyService
{
    Task<Errors> AddPrescription(PrescriptionInDTO prescriptionInDto);
    Task<PatientDataDTO> GetPatientData(int IdPatient);
}