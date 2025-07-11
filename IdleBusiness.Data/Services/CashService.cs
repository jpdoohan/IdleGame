using IdleBusiness.Data;

namespace IdleBusiness.Data.Services;

public class CashService : ICashService
{
    private readonly DataContext db;

    public CashService(DataContext dbContext) {
        db = dbContext;
    }
    //Initialise repo
    public void Initialise()
    {
        db.Initialise();
    }

    Cash GetCash(int userId)
    {
        return db.Cash.FirstOrDefault(u => userId == u.id);
    }

    Cash UpdateCash(User pUser)
    {
        var cash = GetCash(pUser.id);
        if (cash == null) return 0;
        cash.User = pUser;
        cash.amount = pUser.amount;
        cash.appreciation = pUser.appreciation;

        db.saveChanges();
        return cash;
    }

    // ------------- User Management -------------------
    User GetUser(int id)
    {
        return db.Users.FirstOrDefault(u => u.Id == id);
    }
}

