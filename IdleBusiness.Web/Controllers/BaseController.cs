namespace IdleBusiness.Web.Controllers;

public enum AlertType { Success, Danger, Warning, Info } // PascalCase for enums

public class BaseController : Controller
{
    // Store Alert in TempData Storage thus only accessible in next Request
    public void Alert(string message, AlertType type = AlertType.Info)
    {
        TempData["Alert.Message"] = message;
        TempData["Alert.Type"] = type.ToString();
    }

    public void SendAlert(bool condition, string success, string failure)
    {
        if (condition)
        {
            Alert(success, AlertType.Success);
        }
        else
        {
            Alert(failure, AlertType.Danger);
        }
    }

    public int GetUserId() // Slight name polish for consistency
    {
        var idClaim = User.Claims.FirstOrDefault(c => c.Type == "Id");
        return idClaim != null ? int.Parse(idClaim.Value) : 0;
    }
}