using Library.Core.Entities;
using Library.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ProjectManagementTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to use this dark power...");
            Console.ReadKey();
            SyncronizeEntities(@"C:\Users\User\Source\Repos\template");
        }

        private static void SyncronizeEntities(string projectPath)
        {
            var entities = GetEntites();

            foreach (var entity in entities)
            {
                if (IsEntityAlreadyAdded(projectPath, entity))
                {
                    continue;
                }
                else
                {
                    var factory = new FactoryHelper(projectPath, entity);

                    factory.As<DtoFactory>().CreateDtoDirectory().CreateDtos();
                    factory.As<AutomapperProfileFactory>().CreateMapperProfile();
                    factory.As<SearchQueryFactory>().CreateSearchQuery();
                    factory.As<DbContextFactory>().CreateDbContext();
                    factory.As<RepositoryInterfaceFactory>().CreateRepositoryInterface();
                    factory.As<ServiceInterfaceFactory>().CreateServiceInterface();
                    factory.As<AutomapperProfileFactory>().CreateMapperProfile();
                    factory.As<RepositoryImplementationFactory>().Create();
                    factory.As<ServiceImplementationFactory>().Create();
                    factory.As<ConfigureServiceHelperFactory>().Create();
                    factory.As<ControllerFactory>().Create();
                }
            }
        }

        private static IEnumerable<Type> GetEntites()
        {
            Assembly mscorlib = typeof(EntityBase).Assembly;
            var resp = mscorlib.GetTypes().Where(t => t.Name != "EntityBase");
            return resp;
        }


        // დროებით ეს ნიშნავდეს რომ უკვე გადატარებულია ამ ენთითიზე.
        private static bool IsEntityAlreadyAdded(string projectPath, Type entity)
        {
            string dtoDir = $"{projectPath}\\Library.Services\\Dtos\\{entity.Name}Dtos";
            var exists = Directory.Exists(dtoDir);
            return exists;
        }
    }
}
