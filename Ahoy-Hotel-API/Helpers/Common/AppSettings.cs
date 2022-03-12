namespace Ahoy_Hotel_API.Helpers.Common;

/* -------------------------------------------------------------------------- */
/*                                App Settings                                */
/* -------------------------------------------------------------------------- */

/*
* contains properties defined in the appsettings.json file and is used for accessing 
* application settings via objects that are injected into classes using DI 
*/
public class AppSettings
{
    public string Secret { get; set; }
}
