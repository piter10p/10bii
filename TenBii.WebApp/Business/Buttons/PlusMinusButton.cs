using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class PlusMinusButton: IButton
    {
        public string PrimaryText { get; } = "+/-";
        public string SecondaryText { get; } = "E";
        public string TertiaryText { get; } = null;
    }
}