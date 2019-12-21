using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class SecondaryButton: IButton
    {
        public string PrimaryText { get; } = "SCD";
        public string SecondaryText { get; } = null;
        public string TertiaryText { get; } = null;
    }
}