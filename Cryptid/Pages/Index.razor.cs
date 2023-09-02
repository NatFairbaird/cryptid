using Microsoft.AspNetCore.Components;

namespace Cryptid.Pages
{
    public partial class Index
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private void HandleNewGameClick()
        {
            NavigationManager.NavigateTo($"{NavigationManager.BaseUri}{Create.Path}");
        }
    }
}
