namespace WebApplication10.DTOs;

public record PrescriptionInDTO(PatientDTO patient, List<MedicamentDTO> medicaments,int IdDoctor , DateTime Date, DateTime DueDate);