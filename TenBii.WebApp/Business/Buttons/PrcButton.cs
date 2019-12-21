using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class PrcButton: IButton
    {
        public string PrimaryText { get; } = "PRC";
        public string SecondaryText { get; } = "NPV";
        public string TertiaryText { get; } = null;
    }
}