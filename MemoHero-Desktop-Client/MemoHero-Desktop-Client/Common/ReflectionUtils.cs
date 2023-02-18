namespace MemoHeroDesktopClient.Common
{
    internal static class ReflectionUtils
    {
        internal static void SetObjectPropertyValue(object obj, string propertyName, string value)
            => obj.GetType().GetProperty(propertyName).SetValue(obj, value);

        internal static string GetObjectPropertyValue(object obj, string propertyName)
            => obj.GetType().GetProperty(propertyName).GetValue(obj).ToString();
    }
}