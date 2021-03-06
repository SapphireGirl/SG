﻿using System;
using System.Collections;
using System.Configuration;
using System.Reflection;

namespace SG.Logging
{
    public class ServiceLocator
    {
        private static readonly Hashtable services = new Hashtable();

        public static void AddService<T>(T t)
        {
            services.Add(typeof(T).Name, t);
        }

        public static void AddService<T>(string name,T t)
        {
            services.Add(name, t);
        }

        public static T GetService<T>()
        {
            return (T) services[typeof(T).Name];
        }

        public static T GetService<T>(string serviceName)
        {
            return (T) services[serviceName];
        }

        // Register from App Settings
        public static void RegisterServiceFromAppSettings(string serviceName)
        {
            var loggerEntry = ConfigurationManager.AppSettings[serviceName];
            var loggingObject = Assembly.GetExecutingAssembly().CreateInstance(loggerEntry);

            AddService(serviceName,loggingObject);
        }
    }
}
