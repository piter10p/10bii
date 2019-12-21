using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class OneButton: IButton
    {
        public string PrimaryText { get; } = "1";
        public string SecondaryText { get; } = "𝑒ˣ";
        public string TertiaryText { get; } = null;
    }
}