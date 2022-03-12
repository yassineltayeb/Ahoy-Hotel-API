using Ahoy_Hotel_API.Installers;

namespace O.AlMamoon.Mobile.APP.API.Installers;

/* -------------------------------------------------------------------------- */
/*                            Installer Extensions                            */
/* -------------------------------------------------------------------------- */

public static class InstallerExtensions
{
    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* ----------------------- Install Servies In Assemply ---------------------- */
    public static void InstallServiesInAssemply(this IServiceCollection services, IConfiguration configuration)
    {
        /* ------------- Get All The Classes That Implements IInstaller ------------- */
        var installers = typeof(Program).Assembly.ExportedTypes
                                                   .Where(x => typeof(IInstaller).IsAssignableFrom(x) && !x.IsAbstract)
                                                   .Select(Activator.CreateInstance)
                                                   .Cast<IInstaller>()
                                                   .ToList();

        installers.ForEach(installer => installer.InstallServices(services, configuration));
    }
}
