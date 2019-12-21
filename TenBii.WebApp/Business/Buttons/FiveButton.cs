using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class FiveButton: IButton
    {
        public string PrimaryText { get; } = "5";
        public string SecondaryText { get; } = "ŷ,m";
        public string TertiaryText { get; } = "∑𝑥";
    }
}