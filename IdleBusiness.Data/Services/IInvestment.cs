using IdleBusiness.Data.Entities;

namespace IdleBusiness.Data.Services;

public interface IInvestment
{
    void Initialise();

    List<Investment> GetInvestments();
    
}