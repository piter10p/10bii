using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class ThreeButton : IButton
    {
        public string PrimaryText { get; } = "3";
        public string SecondaryText { get; } = "𝑛!";
        public string TertiaryText { get; } = null;
    }
}