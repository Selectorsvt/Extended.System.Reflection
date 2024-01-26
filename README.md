# Extended.System.Reflection
## Assembly extensions:
```C#
IEnumerable<Type> GetInheritedTypes(this Assembly[] assemblies, Type inheritedType)
IEnumerable<Type> GetInheritedTypes<T>(this Assembly[] assemblies)
```
## Type extensions:
```C#
bool IsInherited(this Type type, Type inheritedType)
bool IsInherited<T>(this Type type)
```