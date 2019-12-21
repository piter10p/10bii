using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class PvButton: IButton
    {
        public string PrimaryText { get; } = "PV";
        public string SecondaryText { get; } = "E F F %";
        public string TertiaryText { get; } = null;
    }
}