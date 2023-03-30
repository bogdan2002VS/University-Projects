using Logic.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Pool
{
    public static class ConverterPool
    {
        private static Dictionary<Type, object> objectPool = new();

        public static IConverter<Tsource, tdestination> GetConverter<Tsource, tdestination>()
        {
            var type = typeof(IConverter<Tsource, tdestination>);
            if (!objectPool.ContainsKey(type))
            {
                var types = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => type.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract);

                Type? converterType = types.FirstOrDefault();

                if (converterType is null)
                    throw new ArgumentException("Converter not found");


                objectPool.Add(type, Activator.CreateInstance(converterType));
            }
            return objectPool[type] as IConverter<Tsource, tdestination>;

        }
    }

}
