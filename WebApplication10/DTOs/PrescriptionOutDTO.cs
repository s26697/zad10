﻿namespace WebApplication10.DTOs;

public record PrescriptionOutDTO(int IdPrescription, DateTime Date, DateTime DueDate, List<MedicamentDTO> Medicaments, DoctorDTO Doctor);