namespace WebApplication10.DTOs;

public record PatientDataDTO(PatientDTO Patient, List<PrescriptionOutDTO> Prescriptions);