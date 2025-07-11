using IdleBusiness.Data.Entities;

namespace IdleBusiness.Data.Services;

public interface IUserService
{
    void Initialise();

    User Register(string pName, string pPassword);
    User Authenticate(string pName, string pPassword);
    User GetUserByName(string pName);
    User GetUser(int pID);
}