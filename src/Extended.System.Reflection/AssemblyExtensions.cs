using System.Reflection;

namespace Extended.System.Reflection
{
    /// <summary>
    /// The assembly extensions class.
    /// </summary>
    public static class AssemblyExtensions
    {
        /// <summary>
        /// Gets the inherited types using the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="inheritedType">The inherited type.</param>
        /// <returns>The types from assemblies.</returns>
        public static IEnumerable<Type> GetInheritedTypes(this Assembly[] assemblies, Type inheritedType)
        {
            var typesFromAssemblies = assemblies.SelectMany(a => a.DefinedTypes.Where(t => !t.IsAbstract && t.IsClass && t.IsInherited(inheritedType)));
            return typesFromAssemblies;
        }

        /// <summary>
        /// Gets the inherited types using the specified assemblies.
        /// </summary>
        /// <typeparam name="T">The .</typeparam>
        /// <param name="assemblies">The assemblies.</param>
        /// <returns>An enumerable of type.</returns>
        public static IEnumerable<Type> GetInheritedTypes<T>(this Assembly[] assemblies)
        {
            var inheritedType = typeof(T);
            return assemblies.GetInheritedTypes(inheritedType);
        }
    }
}
