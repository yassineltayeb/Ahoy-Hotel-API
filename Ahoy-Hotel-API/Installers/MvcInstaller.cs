using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using Ahoy_Hotel_API.Installers;

namespace O.AlMamoon.Mobile.APP.API.Installers;

/* -------------------------------------------------------------------------- */
/*                                Mvc Installer                               */
/* -------------------------------------------------------------------------- */

public class MvcInstaller : IInstaller
{
    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* ---------------------------- Install Services ---------------------------- */
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        /* --------------------- Add MVC And Serializer Settings -------------------- */
        services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                    .AddNewtonsoftJson(options =>
                        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    )
                    .AddFluentValidation(fv =>
                        {
                            fv.RegisterValidatorsFromAssemblyContaining<Program>();
                            fv.DisableDataAnnotationsValidation = true;
                        })
                    .AddDataAnnotationsLocalization();
    }
}
