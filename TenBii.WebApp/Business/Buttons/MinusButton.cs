using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class MinusButton: IButton
    {
        public string PrimaryText { get; } = "-";
        public string SecondaryText { get; } = "√𝑥";
        public string TertiaryText { get; } = null;
    }
}