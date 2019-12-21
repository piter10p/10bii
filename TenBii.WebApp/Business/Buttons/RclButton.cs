using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class RclButton: IButton
    {
        public string PrimaryText { get; } = "RCL";
        public string SecondaryText { get; } = "STO";
        public string TertiaryText { get; } = null;
    }
}