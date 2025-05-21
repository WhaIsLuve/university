namespace Core.Screenings;

public record Screening(int Id, string MovieName, string HallName, int Price, DateTime StartDateTime, DateTime EndDateTime);
