namespace MoreLinq
{
    #if UNITY_5_6_OR_NEWER
    #pragma warning disable CS3015
    [System.AttributeUsage(System.AttributeTargets.All)]
    public class MaybeNullAttribute : System.Attribute {}

    [System.AttributeUsage(System.AttributeTargets.All)]
    public class MaybeNullWhenAttribute : System.Attribute
    {
        public MaybeNullWhenAttribute(params object[] any) { }
    }
    #endif
}
