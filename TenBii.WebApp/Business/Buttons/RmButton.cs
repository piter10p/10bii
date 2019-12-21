using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class RmButton: IButton
    {
        public string PrimaryText { get; } = "RM";
        public string SecondaryText { get; } = "(";
        public string TertiaryText { get; } = null;
    }
}