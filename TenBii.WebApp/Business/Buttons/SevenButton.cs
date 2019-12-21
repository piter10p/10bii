using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class SevenButton: IButton
    {
        public string PrimaryText { get; } = "7";
        public string SecondaryText { get; } = "x̄,ȳ";
        public string TertiaryText { get; } = "∑𝑥²";
    }
}