using JetBrains.Annotations;

namespace TenBii.WebApp.Business.Buttons
{
    [UsedImplicitly]
    internal class MultiplyButton: IButton
    {
        public string PrimaryText { get; } = "×";
        public string SecondaryText { get; } = "𝑦ˣ";
        public string TertiaryText { get; } = null;
    }
}