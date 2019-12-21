using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class PmtButton: IButton
    {
        public string PrimaryText { get; } = "PMT";
        public string SecondaryText { get; } = "P/YR";
        public string TertiaryText { get; } = null;
    }
}