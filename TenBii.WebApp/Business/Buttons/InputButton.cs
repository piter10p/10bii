using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class InputButton: IButton
    {
        public string PrimaryText { get; } = "INP";
        public string SecondaryText { get; } = "TVM /";
        public string TertiaryText { get; } = null;
    }
}