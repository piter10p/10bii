using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class IyrButton: IButton
    {
        public string PrimaryText { get; } = "IYR";
        public string SecondaryText { get; } = "NOM%";
        public string TertiaryText { get; } = null;
    }
}