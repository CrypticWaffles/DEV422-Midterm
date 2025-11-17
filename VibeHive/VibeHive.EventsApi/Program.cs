using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer; // Auth
using Microsoft.IdentityModel.Tokens; // Auth
using VibeHive.EventsApi.Services;// in-memory store



namespace VibeHive.EventsApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Read the JWT secret code from appsettings.json and convert it to bytes:
            var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:SecretKey"]);

            // =========== Configure the JWT authentication: ============
            builder.Services.AddAuthentication(options =>
            {
                // Set default auth scheme to JWT:
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;

                // Set default challenge scheme to JWT:
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }
            ).AddJwtBearer(options =>
            {
                // Config. validation token parameters:
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    // Specify that signing key should be validated:
                    ValidateIssuerSigningKey = true,

                    // Set the validating key of the token's signature to the SecretKey in appsettings:
                    IssuerSigningKey = new SymmetricSecurityKey(key),

                    // TEMPORARY: When you go LIVE ( deploy API to the public ), this will be set to true.
                    // Disable issuer validation for testing purposes:
                    ValidateIssuer = false,
                    ValidateAudience = false,
                };
            });
            // =========================================================

            // In-memory store for events and tickets; shared for the whole API
            builder.Services.AddSingleton<EventStore>();

            // --------- Section might be reoved later -----------------
            //// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            //builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();
            // ---------------------------------------------------------

            var app = builder.Build();

            // --------- Section might be reoved later -----------------
            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}
            // ---------------------------------------------------------

            app.UseHttpsRedirection();

            app.UseAuthentication(); // Auth

            app.UseAuthorization();


            builder.Services.AddControllers();

            // In-memory store for events and tickets; shared for the whole API
            builder.Services.AddSingleton<EventStore>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
