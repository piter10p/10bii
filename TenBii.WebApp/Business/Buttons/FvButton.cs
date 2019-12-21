using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class FvButton: IButton
    {
        public string PrimaryText { get; } = "FV";
        public string SecondaryText { get; } = "AMORT";
        public string TertiaryText { get; } = null;
    }
}