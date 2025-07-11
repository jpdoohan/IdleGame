using IdleBusiness.Data.Entities;

namespace IdleBusiness.Data.Services;

public interface ICashService
{
    //Initialise repo
    void Initialise();

    Cash GetCash(int userId);

    Cash UpdateCash(int user);

    // ------------- User Management -------------------
    User GetUser(int id);
}