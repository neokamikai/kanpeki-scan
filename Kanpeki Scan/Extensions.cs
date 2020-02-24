using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class Extensions
    {
        public static string ToYesNo(this bool input)
        {
            return (input?"Yes":"No");
        }
        public static void Serialize<T>(this  System.IO.StreamWriter input, T obj)
        {
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(T),"http://schema.kanpekiitsolutions.com/");
            xs.Serialize(input, obj);

        }
        public static T Deserialize<T>(this System.IO.StreamReader input)
        {
            object obj = null;
            
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(T),"http://schema.kanpekiitsolutions.com/");
            obj = xs.Deserialize(input);

            return (T) obj;
        }
    }
}
