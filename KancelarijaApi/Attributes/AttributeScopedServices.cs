﻿using System;
using System.Linq;
using System.Reflection;
using KancelarijaApi.Attributes;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;


namespace RrepTest.MyAttributes
{
    public static class AttributeScopedServices
    {

        public static void AddDI(this IServiceCollection services)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(x => x.GetCustomAttributes<UniversalDiAttribute>().Any());

            foreach (var type in types)
            {
                var getEnumVal = type.GetCustomAttribute<UniversalDiAttribute>().Name;
                Type t = type;
                Type[] getAllInterfaces = type.GetInterfaces();
                foreach (var it in getAllInterfaces)
                {
                    if (it.IsGenericType && type.IsGenericType)
                    {
                        if (it.IsGenericTypeDefinition && type.IsGenericTypeDefinition)
                        {
                            switch (getEnumVal)
                            {
                                case EnumServiceForDI.Scoped:
                                    services.AddScoped(it, t);
                                    break;
                                case EnumServiceForDI.Transient:
                                    services.AddTransient(it, t);
                                    break;
                                case EnumServiceForDI.Singleton:
                                    services.AddSingleton(it, t);
                                    break;
                            }
                        }
                    }
                    else
                    {
                        switch (getEnumVal)
                        {
                            case EnumServiceForDI.Scoped:
                                services.AddScoped(it, t);
                                break;
                            case EnumServiceForDI.Transient:
                                services.AddTransient(it, t);
                                break;
                            case EnumServiceForDI.Singleton:
                                services.AddSingleton(it, t);
                                break;
                        }
                    }
                }
            }

        }

    }

}
