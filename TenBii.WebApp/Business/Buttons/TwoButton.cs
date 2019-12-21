using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class TwoButton: IButton
    {
        public string PrimaryText { get; } = "2";
        public string SecondaryText { get; } = "LN";
        public string TertiaryText { get; } = null;
    }
}