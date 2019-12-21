using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class ZeroButton: IButton
    {
        public string PrimaryText { get; } = "0";
        public string SecondaryText { get; } = null;
        public string TertiaryText { get; } = null;
    }
}