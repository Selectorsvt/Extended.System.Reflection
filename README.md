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
## Expression extensions:
```C#
string GetPropertyName<TSource, TProperty>(this Expression<Func<TSource, TProperty>> propertyLambda)
PropertyInfo GetPropertyInfo<TSource, TProperty>(Expression<Func<TSource, TProperty>> propertyLambda)
```