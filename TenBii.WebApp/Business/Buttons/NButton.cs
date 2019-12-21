using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class NButton: IButton
    {
        public string PrimaryText { get; } = "N";
        public string SecondaryText { get; } = "xP/YR";
        public string TertiaryText { get; } = null;
    }
}