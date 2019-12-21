using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class CstButton: IButton
    {
        public string PrimaryText { get; } = "CST";
        public string SecondaryText { get; } = "IRR/YR";
        public string TertiaryText { get; } = null;
    }
}