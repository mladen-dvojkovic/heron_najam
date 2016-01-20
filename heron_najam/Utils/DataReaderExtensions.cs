using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace heron_najam
{
    // Ovo ti je vrhunska pomoća klasa koja iz SqlDataReadera prebaci u neki objekt.     
    public static class DataReaderExtensions
    {
        /// <summary>
        /// Iz SqlDataReadera prebacujemo podatke u listu objekata. Nešto savršeno. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static List<T> MapToList<T>(this SqlDataReader dr) where T : new()
        {
            var entity = typeof(T);
            var entities = new List<T>();

            if (dr != null && dr.HasRows)
            {
                var propDict = new Dictionary<string, PropertyInfo>();
                var props = entity.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                propDict = props.ToDictionary(p => p.Name.ToUpper(), p => p);

                while (dr.Read())
                {
                    T newObject = new T();
                    for (int index = 0; index < dr.FieldCount; index++)
                    {
                        if (propDict.ContainsKey(dr.GetName(index).ToUpper()))
                        {
                            var info = propDict[dr.GetName(index).ToUpper()];
                            if ((info != null) && info.CanWrite)
                            {
                                var val = dr.GetValue(index);

                                if (val != DBNull.Value && val != null)
                                {
                                    var t = Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType;
                                    var newVal = Convert.ChangeType(val, t);

                                    info.SetValue(newObject, newVal, null);
                                }
                                else
                                {
                                    info.SetValue(newObject, null, null);
                                }
                            }
                        }
                    }
                    entities.Add(newObject);
                }
            }
            return entities;
        }
    }
}
