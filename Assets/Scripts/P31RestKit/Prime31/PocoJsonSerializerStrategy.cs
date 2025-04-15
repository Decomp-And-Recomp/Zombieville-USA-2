using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Prime31.Reflection;

namespace Prime31
{
	public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
	{
		internal CacheResolver cacheResolver;

		private static readonly string[] Iso8601Format = new string[3] { "yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z", "yyyy-MM-dd\\THH:mm:ss\\Z", "yyyy-MM-dd\\THH:mm:ssK" };

		public PocoJsonSerializerStrategy()
		{
			cacheResolver = new CacheResolver(buildMap);
		}

		protected virtual void buildMap(Type type, SafeDictionary<string, CacheResolver.MemberMap> memberMaps)
		{
			PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (PropertyInfo propertyInfo in properties)
			{
				memberMaps.add(propertyInfo.Name, new CacheResolver.MemberMap(propertyInfo));
			}
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (FieldInfo fieldInfo in fields)
			{
				memberMaps.add(fieldInfo.Name, new CacheResolver.MemberMap(fieldInfo));
			}
		}

		public virtual bool serializeNonPrimitiveObject(object input, out object output)
		{
			return trySerializeKnownTypes(input, out output) || trySerializeUnknownTypes(input, out output);
		}

		protected virtual object serializeEnum(Enum p)
		{
			return Convert.ToDouble(p, CultureInfo.InvariantCulture);
		}

		protected virtual bool trySerializeKnownTypes(object input, out object output)
		{
			bool result = true;
			if (input is DateTime)
			{
				output = ((DateTime)input).ToUniversalTime().ToString(Iso8601Format[0], CultureInfo.InvariantCulture);
			}
			else if (input is Guid)
			{
				output = ((Guid)input).ToString("D");
			}
			else if (input is Uri)
			{
				output = input.ToString();
			}
			else if (input is Enum)
			{
				output = serializeEnum((Enum)input);
			}
			else
			{
				result = false;
				output = null;
			}
			return result;
		}

		protected virtual bool trySerializeUnknownTypes(object input, out object output)
		{
			output = null;
			Type type = input.GetType();
			if (type.FullName == null)
			{
				return false;
			}
			IDictionary<string, object> dictionary = new JsonObject();
			SafeDictionary<string, CacheResolver.MemberMap> safeDictionary = cacheResolver.loadMaps(type);
			foreach (KeyValuePair<string, CacheResolver.MemberMap> item in safeDictionary)
			{
				if (item.Value.Getter != null)
				{
					dictionary.Add(item.Key, item.Value.Getter(input));
				}
			}
			output = dictionary;
			return true;
		}
	}
}
