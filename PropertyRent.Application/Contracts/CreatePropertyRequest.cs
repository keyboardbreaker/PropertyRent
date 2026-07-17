namespace PropertyRent.Application.Contracts;

public record CreatePropertyRequest(
    string Address,
    decimal MonthlyRent
);