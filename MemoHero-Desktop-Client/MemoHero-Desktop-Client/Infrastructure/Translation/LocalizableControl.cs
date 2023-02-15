using MemoHeroDesktopClient.Common;

namespace MemoHeroDesktopClient.Infrastructure.Translation
{
    internal class LocalizableControl : ILocalizableControl
    {
        private readonly object control;
        private readonly TranslationService.Control controlEnum;
        protected string propertyName;

        public LocalizableControl(object control)
        {
            this.control = control;
            var controlName = ReflectionUtils.GetObjectPropertyValue(this.control, "Name");
            controlEnum = Extensions.GetValueFromDescription<TranslationService.Control>(controlName);
        }

        public TranslationService.Control GetControlEnum() => controlEnum;

        public void SetText(string value) => ReflectionUtils.SetObjectPropertyValue(control, propertyName, value);
    }
}