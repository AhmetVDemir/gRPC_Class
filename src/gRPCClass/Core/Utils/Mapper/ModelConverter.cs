using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace gRPC.Core.Utils.Mapper
{
    public static class ModelConverter
    {
        private static readonly ConditionalWeakTable<object, object> PropertyCache = new ConditionalWeakTable<object, object>();

        public static TDestination Convert<TSource, TDestination>(TSource source)
            where TDestination : new()
        {
            TDestination destination = new TDestination();
            Type sourceType = typeof(TSource);
            Type destinationType = typeof(TDestination);

            foreach (PropertyInfo sourceProperty in sourceType.GetProperties())
            {
                PropertyInfo destinationProperty = destinationType.GetProperty(sourceProperty.Name);
                if (destinationProperty != null && destinationProperty.PropertyType == sourceProperty.PropertyType)
                {
                    object value;
                    if (!PropertyCache.TryGetValue(sourceProperty, out value))
                    {
                        value = sourceProperty.GetValue(source);
                        PropertyCache.Add(sourceProperty, value);
                    }

                    destinationProperty.SetValue(destination, value);
                }
            }

            return destination;
        }
    }
}
