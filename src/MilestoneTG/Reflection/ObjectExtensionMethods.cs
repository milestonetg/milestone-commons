using System;
using System.Reflection;

namespace MilestoneTG.Reflection
{
    /// <summary>
    /// Extension methods for working with properties on objects using reflection
    /// </summary>
    public static class ObjectExtensionMethods
    {
        /// <summary>
        /// Gets the value of a property using reflection.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>System.Object.</returns>
        /// <exception cref="ArgumentNullException">instance</exception>
        /// <exception cref="ArgumentOutOfRangeException">propertyName</exception>
        public static object GetPropertyValue(this object instance, string propertyName)
        {
            if (instance == null)
                throw new ArgumentNullException(nameof(instance));

            Type objType = instance.GetType(); 
            PropertyInfo propInfo = GetPropertyInfo(objType, propertyName); 
            if (propInfo == null) 
                throw new ArgumentOutOfRangeException(nameof(propertyName), string.Format("Couldn't find property {0} in type {1}", propertyName, objType.FullName));
            
            return propInfo.GetValue(instance, null); 
        }

        private static PropertyInfo GetPropertyInfo(Type type, string propertyName)
        {
            PropertyInfo propInfo = null;
            do
            {
                propInfo = type.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic); 
                type = type.BaseType;
            } while (propInfo == null && type != null);    
            return propInfo;
        }

        /// <summary>
        /// Sets the value of a property using reflection.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="val">The value.</param>
        /// <exception cref="ArgumentNullException">instance</exception>
        /// <exception cref="ArgumentOutOfRangeException">propertyName</exception>
        public static void SetPropertyValue(this object instance, string propertyName, object val)
        {
            if (instance == null)       
                throw new ArgumentNullException(nameof(instance)); 

            Type objType = instance.GetType(); 
            PropertyInfo propInfo = GetPropertyInfo(objType, propertyName); 
            if (propInfo == null)       
                throw new ArgumentOutOfRangeException(nameof(propertyName), string.Format("Couldn't find property {0} in type {1}", propertyName, objType.FullName)); 
            
            propInfo.SetValue(instance, val, null);
        } 
    }
}
