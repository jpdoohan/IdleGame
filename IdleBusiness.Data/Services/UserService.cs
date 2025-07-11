using IdleBusiness.Data.Entities;

namespace IdleBusiness.Data.Services;

public class UserService : IUserService
{
    private readonly DataContext db;

    public UserService(DataContext db)
    {
        this.db = db;
    }

    void Initialise()
    {
        db.Initialise();
    }

    User Register(string pName, string pPassword)
    {
        if (db.Users.Any(u => u.name == pName)) return null;
        var user = new User
        {
            name = pName,
            password = pPassword,
        };

        db.Users.Add(user);
        db.SaveChanges();
        return user;
    }
    User Authenticate(string pName, string pPassword)
    {
        return db.Users.FirstOrDefault(u => u.name == pName && u.password == pPassword);
    }
    User GetUserByName(string pName)
    {
        return db.Users.FirstOrDefault(u => u.name == pName);
    }
    User GetUser(int pID)
    {
        return db.Users.FirstOrDefault(u => u.Id == id);
    }
}

