using AutoMapper;
using Csv.Api.Repositories;
using Csv.Api.Config;
using Csv.Api.Models.Context;
using Csv.Api.Services;
using Csv.Api.Utils;
using Microsoft.EntityFrameworkCore;


namespace Csv.Api
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
            var connection = Configuration["MySqlConnection:MySqlConnectionString"];

            services.AddDbContext<MySqlContext>(options => options.
                     UseMySql(connection,
                            new MySqlServerVersion(
                               new Version(8, 0, 30))));

            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            services.AddSingleton(mapper);

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            FileUtil fileUtil = FileUtilConfig.InstanceFileUtil();
            services.AddSingleton(fileUtil);


            services.AddTransient<ITemperatureRepository, TemperatureRepository>();

            services.AddTransient<ITemperatureService, TemperatureService>();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();



        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }




    }
}