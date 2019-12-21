using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class NineButton: IButton
    {
        public string PrimaryText { get; } = "9";
        public string SecondaryText { get; } = "𝜎𝑥,𝜎𝑦";
        public string TertiaryText { get; } = "∑𝑥𝑦";
    }
}