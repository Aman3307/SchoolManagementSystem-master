using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Interface;
using SchoolManagementSystem.Repositary;
using System;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SchoolDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SchoolDbContext")));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAdminRepositary, AdminRepositary>();
            services.AddScoped<ISuperAdminRepositary, SuperAdminRepositary>();
            services.AddScoped<ICashierRepositary, CashierRepositary>();
            services.AddScoped<ITeacherRepositary, TeacherRepositary>();
            services.AddScoped<IStudentRepositary, StudentRepositary>();
            services.AddScoped<JwtService>();

            services.AddControllers();

            var key = Encoding.ASCII.GetBytes(Configuration["Jwt:SecretKey"]);
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidateAudience = true,
                    ValidAudience = Configuration["Jwt:Audience"],
                    ValidateLifetime = true, // Ensure token hasn't expired
                    ClockSkew = TimeSpan.Zero // Adjust this value if necessary
                };
                options.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.Response.Headers.Add("Token-Expired", "true");
                        }
                        return Task.CompletedTask;
                    }
                };
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("SuperAdminOnly", policy =>
                {
                    policy.RequireRole("1");
                });
            });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("TeacherOnly", policy =>
                {
                    policy.RequireRole("2");

                });
            });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("StudentOnly", policy =>
                {
                    policy.RequireRole("3");
                });
            });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("CashierOnly", policy =>
                {
                    policy.RequireRole("4");
                });
            });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", policy =>
                {
                    policy.RequireRole("5");
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
