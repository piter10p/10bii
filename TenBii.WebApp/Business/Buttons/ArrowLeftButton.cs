using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class ArrowLeftButton: IButton
    {
        public string PrimaryText { get; } = "←";
        public string SecondaryText { get; } = "RND";
        public string TertiaryText { get; } = null;
    }
}