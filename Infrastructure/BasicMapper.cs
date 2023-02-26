using System.Reflection;

namespace Api.Dummies.Infrastructure {
    public static class BasicMapper {
        public static TDest? Map<TDest>(object source) where TDest : class, new() {
            if (source == null) return null;

            TDest dest = new();
            CopyProps(source, dest, typeof(TDest));
            return dest;
        }

        public static object? Map(object? source, Type? destType) {
            if (source == null) return null;
            if (destType == null) return source;

            var dest = Activator.CreateInstance(destType);
            if (dest == null) throw new Exception("cannot init dest obj");
            CopyProps(source, dest, destType);
            return dest;
        }

        private static void CopyProps(object source, object dest, Type destType) {
            foreach (PropertyInfo sourceProp in source.GetType().GetProperties()) {
                PropertyInfo? destProp = destType.GetProperty(sourceProp.Name);
                if (destProp != null && destProp.CanWrite)
                    destProp.SetValue(dest, sourceProp.GetValue(source));
            }
        }
    }
}
