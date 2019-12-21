using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class PlusButton: IButton
    {
        public string PrimaryText { get; } = "+";
        public string SecondaryText { get; } = "𝑥²";
        public string TertiaryText { get; } = null;
    }
}