using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class MarButton: IButton
    {
        public string PrimaryText { get; } = "MAR";
        public string SecondaryText { get; } = "BEG/END";
        public string TertiaryText { get; } = null;
    }
}