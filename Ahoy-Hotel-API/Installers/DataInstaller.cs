using O.AlMamoon.Mobile.APP.API.Data;
using Microsoft.EntityFrameworkCore;
using Ahoy_Hotel_API.Helpers.Common;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using AutoMapper;
using Ahoy_Hotel_API.Helpers.Mapper;


namespace Ahoy_Hotel_API.Installers;

/* -------------------------------------------------------------------------- */
/*                               Data Installer                               */
/* -------------------------------------------------------------------------- */

public class DataInstaller : IInstaller
{
    /* -------------------------------------------------------------------------- */
    /*                                  Functions                                 */
    /* -------------------------------------------------------------------------- */

    /* ---------------------------- Install Services ---------------------------- */
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {

        /* ---------------------------- Connection String --------------------------- */
        services.AddDbContext<DataContext>(options =>
           options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
       );

        /* ---------------------------------- Cors ---------------------------------- */
        services.AddCors(options => options.AddPolicy("DevCorsPolicy", builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        }));

        /* ---------------------- Configure JWT authentication ---------------------- */
        var appSettingsSection = configuration.GetSection("AppSettings");
        services.Configure<AppSettings>(appSettingsSection);

        var appSettings = appSettingsSection.Get<AppSettings>();

        /* ---------------------- Configure jwt authentication ---------------------- */
        var key = Encoding.ASCII.GetBytes(appSettings.Secret);
        services.AddAuthentication(x =>
        {
            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(x =>
        {
            x.RequireHttpsMetadata = false;
            x.SaveToken = true;
            x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });

        /* ----------------------- Auto Mapper Configurations ----------------------- */
        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new BookingProfile());
            mc.AddProfile(new GuestProfile());
            mc.AddProfile(new HotelFacilityProfile());
            mc.AddProfile(new HotelImageProfile());
            mc.AddProfile(new HotelProfile());
            mc.AddProfile(new ReviewProfile());
            mc.AddProfile(new RoomProfile());
        });

        IMapper mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);
    }
}
