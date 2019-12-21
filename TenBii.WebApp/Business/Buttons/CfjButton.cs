using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class CfjButton: IButton
    {
        public string PrimaryText { get; } = "CFj";
        public string SecondaryText { get; } = "Nj";
        public string TertiaryText { get; } = null;
    }
}