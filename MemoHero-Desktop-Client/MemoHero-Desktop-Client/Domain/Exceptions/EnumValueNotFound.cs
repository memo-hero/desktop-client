using System;

namespace MemoHeroDesktopClient.Domain.Exceptions
{
    internal class EnumValueNotFound : ArgumentException
    {
        public EnumValueNotFound(string value) : base($"Value { value } was not found.") { }
    }
}
