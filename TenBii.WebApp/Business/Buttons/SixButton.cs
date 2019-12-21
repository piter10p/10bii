using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class SixButton: IButton
    {
        public string PrimaryText { get; } = "6";
        public string SecondaryText { get; } = "x̄ᵥᵥ";
        public string TertiaryText { get; } = "∑𝑦";
    }
}