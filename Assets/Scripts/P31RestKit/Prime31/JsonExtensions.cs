using System.Collections.Generic;

namespace Prime31
{
	public static class JsonExtensions
	{
		public static Dictionary<string, object> dictionaryFromJson(this string json)
		{
			return Json.decode(json) as Dictionary<string, object>;
		}
	}
}
