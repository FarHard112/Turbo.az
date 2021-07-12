using System.Linq;
using System.Reflection;

namespace Turbo.AZ_ONION__.TypeConverter
{
    public static class TypeConversion
    {
        public static TResult Converter<T, TResult>(T model) where TResult : class, new()
        {
            TResult result = new TResult();
            typeof(T).GetProperties().ToList().ForEach(x =>
            {
                PropertyInfo property = typeof(TResult).GetProperty(x.Name);
                property.SetValue(result, x.GetValue(model));
            });

            return result;
        }
    }
}