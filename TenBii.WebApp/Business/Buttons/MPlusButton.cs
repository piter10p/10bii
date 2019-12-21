using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class MPlusButton: IButton
    {
        public string PrimaryText { get; } = "M+";
        public string SecondaryText { get; } = ")";
        public string TertiaryText { get; } = null;
    }
}