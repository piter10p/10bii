using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class MuButton: IButton
    {
        public string PrimaryText { get; } = "MU";
        public string SecondaryText { get; } = "TVM";
        public string TertiaryText { get; } = null;
    }
}