namespace MemoHeroDesktopClient.Infrastructure.Translation
{

    internal class LocalizableControlText : LocalizableControl
    {
        public LocalizableControlText(object control) : base (control)  { propertyName = "Text"; }
    }
}