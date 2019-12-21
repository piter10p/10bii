using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class RightArrowMButton: IButton
    {
        public string PrimaryText { get; } = "→M";
        public string SecondaryText { get; } = "CL∑";
        public string TertiaryText { get; } = null;
    }
}