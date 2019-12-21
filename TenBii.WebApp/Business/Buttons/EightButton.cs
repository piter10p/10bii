using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class EightButton: IButton
    {
        public string PrimaryText { get; } = "8";
        public string SecondaryText { get; } = "𝑆𝑥,𝑆𝑦";
        public string TertiaryText { get; } = "∑𝑦²";
    }
}