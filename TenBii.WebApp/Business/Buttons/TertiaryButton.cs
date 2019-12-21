using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class TertiaryButton: IButton
    {
        public string PrimaryText { get; } = "TER";
        public string SecondaryText { get; } = null;
        public string TertiaryText { get; } = null;
    }
}