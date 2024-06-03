namespace WebApplication10.DTOs;

public record PrescriptionMedicamentDTO(int IdMedicament, int IdPrescription, int? Dose, string Details);