using MemoHeroDesktopClient.Common;
using MemoHeroDesktopClient.Infrastructure.Translation;
using System;

namespace MemoHeroDesktopClient.Domain.Events
{

    internal class LocalizationChangedEventArgs : EventArgs
    {
        internal string ISOCode;
        public LocalizationChangedEventArgs(ISOCode isoCode) => ISOCode = isoCode.GetDescription();
    }
}