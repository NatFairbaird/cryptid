using Microsoft.AspNetCore.Components;

namespace Cryptid.Pages
{
    public partial class Index
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private void HandleNewGameClick()
        {
            Console.Out.WriteLine($"Navigation Manager, BaseUri: {NavigationManager.BaseUri}, Uri: {NavigationManager.Uri}");
        }
    }
}
