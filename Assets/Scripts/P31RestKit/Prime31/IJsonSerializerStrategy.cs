namespace Prime31
{
	public interface IJsonSerializerStrategy
	{
		bool serializeNonPrimitiveObject(object input, out object output);
	}
}
