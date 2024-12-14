using AutoMapper;
using Core.Models.SettingModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Application;

namespace NUnitProject
{
    public static class BaseIntegrationTestGlobal
    {
        private static string ASPNETCORE_ENVIRONMENT = "ASPNETCORE_ENVIRONMENT";
        private static string _appsettingsForTesting = "appsettings.test.Local.json";

        private static IConfigurationRoot Configuration;
        public static AppSettings _appSettings { get; private set; }

        private static ServiceCollection _servicesCollection;
        private static ServiceProvider _serviceProvider;

        /// <summary>
        /// Load appsetting  
        /// </summary>
        public static void InitConfig()
        {
            string env = GetEnvironment();

            if (string.IsNullOrEmpty(env))
            {
                throw new Exception("Please set environment");
            }

            Configuration = new ConfigurationManager()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(_appsettingsForTesting, optional: true)
                .Build();

            _appSettings = new AppSettings();
            Configuration.GetSection("AppSettings").Bind(_appSettings);


        }

        /// <summary>
        /// Tạo mới service collection để thực hiện test
        /// </summary>
        /// <returns></returns>
        public static void InitServiceCollection()
        {
            _servicesCollection = new ServiceCollection();

            _servicesCollection.UseServices();
            _servicesCollection.AddSingleton(typeof(AppSettings), _appSettings);


            _serviceProvider = _servicesCollection.BuildServiceProvider();
        }

        public static T GetService<T>()
        {
            return _serviceProvider.GetService<T>();
        }

        /// <summary>
        /// Xác định môi trường cần test AppSetting
        /// </summary>
        /// <param name="env"></param>
        public static void SetEnvironment(string env)
        {
            Environment.SetEnvironmentVariable(ASPNETCORE_ENVIRONMENT, env);
        }

        /// <summary>
        /// Trả về môi trường đang test hiện tại
        /// </summary>
        public static string GetEnvironment()
        {
            return Environment.GetEnvironmentVariable(ASPNETCORE_ENVIRONMENT);
        }
    }

}
