using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class KButton: IButton
    {
        public string PrimaryText { get; } = "K";
        public string SecondaryText { get; } = "SWAP";
        public string TertiaryText { get; } = null;
    }
}