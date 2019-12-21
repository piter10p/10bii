using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class DivideButton: IButton
    {
        public string PrimaryText { get; } = "÷";
        public string SecondaryText { get; } = "1/𝑥";
        public string TertiaryText { get; } = null;
    }
}