using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Cryptid.Components
{
    public partial class Button
    {
        [Parameter]
        public string DisplayValue { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> ClickEvent { get; set; }

        [Parameter]
        public bool? Disabled { get; set; }
    }
}
