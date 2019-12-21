using System;
using JetBrains.Annotations;

namespace TenBii.WebApp.Business
{
    public class Button: IButton
    {
        public Button([NotNull] string primaryText, string secondaryText, string tertiaryText)
        {
            PrimaryText = primaryText ?? throw new ArgumentNullException(nameof(primaryText));
            SecondaryText = secondaryText;
            TertiaryText = tertiaryText;
        }

        public string PrimaryText { get; }
        public string SecondaryText { get; }
        public string TertiaryText { get; }
    }
}