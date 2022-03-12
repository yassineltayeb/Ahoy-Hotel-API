using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Ahoy_Hotel_API.Installers;
using Ahoy_Hotel_API.Interfaces;
using Ahoy_Hotel_API.Repositories;

namespace O.AlMamoon.Mobile.APP.API.Installers;

/* -------------------------------------------------------------------------- */
/*                            Interfaces Installer                            */
/* -------------------------------------------------------------------------- */

public class InterfacesInstaller : IInstaller
{
    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* ---------------------------- Install Services ---------------------------- */
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        /* --------------------------- Register Interfaces -------------------------- */
        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IGuestRepository, GuestRepository>();
        services.AddScoped<IRoomRepository, RoomRepository>();
    }
}
