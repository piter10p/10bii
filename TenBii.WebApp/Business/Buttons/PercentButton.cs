using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class PercentButton: IButton
    {
        public string PrimaryText { get; } = "%";
        public string SecondaryText { get; } = "%CHG";
        public string TertiaryText { get; } = null;
    }
}