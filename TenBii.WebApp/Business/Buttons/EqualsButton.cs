using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class EqualsButton: IButton
    {
        public string PrimaryText { get; } = "=";
        public string SecondaryText { get; } = "DIS";
        public string TertiaryText { get; } = null;
    }
}