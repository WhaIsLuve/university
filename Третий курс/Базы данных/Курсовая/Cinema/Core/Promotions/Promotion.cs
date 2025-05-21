namespace Core.Promotions;

public record Promotion(string DisplayName, int DiscountPercent, DateTime StartDateTime, DateTime EndDateTime);
