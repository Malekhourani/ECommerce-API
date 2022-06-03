using System.Reflection;
using System.Text;
using App.Application.Contracts;
using App.Application.Contracts.Common;
using App.Application.Services.CategoryServices;
using App.Application.Services.OrderProductServices;
using App.Application.Services.OrderServices;
using App.Application.Services.ProductServices;
using App.Domain.Models.Users;
using App.Infrastructure.Identity;
using App.Infrastructure.Services.Common;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using TanvirArjel.EFCore.GenericRepository;
using Microsoft.OpenApi.Models;
using App.Application.Services.DiscountActivationServices;
using App.Application.Services.DiscountTypeServices;
using App.Application.Services.AuctionParticipantServices;
using App.Application.Services.ProdcutMediaServices;
using App.Application.Services.AuctionServices;
using App.Application.Services.AuctionOfferServices;

namespace App.Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        private static readonly Type _typeOfProfile = typeof(Profile);
        private static readonly Type[] _automappersProfileChildren = Assembly.GetExecutingAssembly()
                                                .GetTypes()
                                                .Where(type => type.IsSubclassOf(_typeOfProfile))
                                                .ToArray();

        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContextPool<AppDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DbConnection"), builder =>
                {
                    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                });
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultForbidScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["Jwt:Secret"])),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    RequireExpirationTime = false
                };
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy(Roles.SHOP_OWNER_ROLE, builder =>
                {
                    builder.RequireClaim("Role", Roles.SHOP_OWNER_ROLE);
                });

                options.AddPolicy(Roles.ADMIN_ROLE, builder =>
                {
                    builder.RequireClaim("Role", Roles.ADMIN_ROLE);
                });

                options.AddPolicy(Roles.CUSTOMER_ROLE, builder =>
                {
                    builder.RequireClaim("Role", Roles.CUSTOMER_ROLE);
                });

                options.AddPolicy(Roles.SHOP_OWNER_OR_ADMIN, builder =>
                {
                    builder.RequireAssertion(context =>
                        context.User.HasClaim(c =>
                                 (c.Type == "Role") && (c.Value == Roles.ADMIN_ROLE || c.Value == Roles.SHOP_OWNER_ROLE))
                                 );
                });

                options.AddPolicy("ShopOwnerOrCustomer", builder =>
                {
                    builder.RequireAssertion(context =>
                        context.User.HasClaim(c =>
                                 (c.Type == "Role") && (c.Value == Roles.CUSTOMER_ROLE || c.Value == Roles.SHOP_OWNER_ROLE))
                                 );
                });
            });

            services.AddServices();

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            })
                        .AddEntityFrameworkStores<AppDbContext>()
                        .AddDefaultTokenProviders();

            services.AddGenericRepository<AppDbContext>(ServiceLifetime.Scoped);

            services.AddHttpContextAccessor();

            services.AddAutoMapper(_automappersProfileChildren);

            services.AddSwaggerGen();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAppService, AppService>();
            services.AddTransient<IDbService, DbService>();
            services.AddTransient<IAuthenticationService, IdentityService>();
            services.AddTransient<IRoleService, RoleService>();

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductCategoryService, CategoryService>();
            services.AddTransient<IProductMediaService, ProductMediaService>();
            services.AddTransient<IOrderProductService, OrderProductService>();
            services.AddTransient<IOrderService, OrderService>();

            services.AddTransient<IDiscountActivationService, DiscountActivationService>();
            services.AddTransient<IDiscountTypeService, DiscountTypeService>();

            services.AddTransient<IAuctionParticipantService, AuctionParticipantService>();
            services.AddTransient<IAuctionService, AuctionService>();
            services.AddTransient<IAuctionOfferService, AuctionOfferService>();
        }

        private static void AddSwaggerGen(this IServiceCollection services)
        {
            services.AddSwaggerGen(swagger =>
            {

                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "E-Commerce API",
                    Description = "Authentication and Authorization in ASP.NET 5 with JWT and Swagger"
                });

                swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Enter \"Bearer\" [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",
                });

                swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                            {
                                new OpenApiSecurityScheme
                                    {
            Reference = new OpenApiReference
                        {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                        }
        },
        new string[] {}
    }
        });
            });
        }
    }
}