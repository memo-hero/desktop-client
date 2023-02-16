using MemoHeroDesktopClient.Common;

namespace MemoHeroDesktopClient.Infrastructure.Translation
{
    internal class LocalizableControl : ILocalizableControl
    {
        private readonly object control;
        private readonly LocalizationService.LocalizedControl controlEnum;
        protected string propertyName;

        public LocalizableControl(object control)
        {
            this.control = control;
            var controlName = ReflectionUtils.GetObjectPropertyValue(this.control, "Name");
            controlEnum = Extensions.GetValueFromDescription<LocalizationService.LocalizedControl>(controlName);
        }

        public LocalizationService.LocalizedControl GetControlEnum() => controlEnum;

        public void SetText(string value) => ReflectionUtils.SetObjectPropertyValue(control, propertyName, value);
    }
}