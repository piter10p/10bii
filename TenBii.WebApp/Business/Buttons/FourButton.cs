using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class FourButton: IButton
    {
        public string PrimaryText { get; } = "4";
        public string SecondaryText { get; } = "x̂,r";
        public string TertiaryText { get; } = "𝑛";
    }
}