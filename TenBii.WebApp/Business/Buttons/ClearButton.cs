using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class ClearButton: IButton
    {
        public string PrimaryText { get; } = "C";
        public string SecondaryText { get; } = "C ALL";
        public string TertiaryText { get; } = null;
    }
}