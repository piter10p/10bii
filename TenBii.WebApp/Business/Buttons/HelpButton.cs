using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class HelpButton: IButton
    {
        public string PrimaryText { get; } = "HLP";
        public string SecondaryText { get; } = null;
        public string TertiaryText { get; } = null;
    }
}