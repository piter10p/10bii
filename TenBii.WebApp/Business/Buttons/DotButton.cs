using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class DotButton: IButton
    {
        public string PrimaryText { get; } = ".";
        public string SecondaryText { get; } = "./,";
        public string TertiaryText { get; } = null;
    }
}