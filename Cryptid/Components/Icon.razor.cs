using Cryptid.Domain;
using Cryptid.Domain.Enums;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Cryptid.Components
{
    public partial class Icon
    {
        [Parameter]
        public IconType IconType { get; set; }

        [Parameter]
        public IconColor Color { get; set; }

        [Parameter]
        public Border? OuterBorder { get; set; }

        [Parameter]
        public Border? InnerBorder { get; set; }

        [Parameter]
        public string? Text { get; set; }

        [Inject]
        IJSRuntime JS { get; set; }

        private string Id => $"{IconType.ToString().ToLower()}-{Color.ToString().ToLower()}";

        private string IconClassName => IconType switch
        {
            IconType.Cross => "fa-xmark",
            IconType.House => "fa-house",
            IconType.LessThanOrEqual => "fa-less-than-equal",
            IconType.One => "fa-1",
            IconType.Three => "fa-3",
            IconType.Two => "fa-2",
            _ => throw new ArgumentOutOfRangeException(IconType.ToString())
        };

        private string ColorClassName => Color.ToString().ToLower();

        private string ColorCssName => Color switch
        {
            //if changing these, also update Icon.razor.css
            IconColor.Blue => "cornflowerblue",
            IconColor.Green => "forestgreen",
            IconColor.Purple => "rebeccapurple",
            IconColor.Yellow => "gold",
            _ => ColorClassName
        };

        private bool IsCanvas => IconType is IconType.Hexagon or IconType.Octagon or IconType.Triangle;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if(IsCanvas)
            {
                var module = await JS.InvokeAsync<IJSObjectReference>("import", "./Components/Icon.razor.js");
                var colour = ColorCssName;
                var numberOfSides = IconType switch
                {
                    IconType.Hexagon => "6",
                    IconType.Octagon => "8",
                    IconType.Triangle => "3"
                };

                if (InnerBorder == null)
                {
                    await module.InvokeVoidAsync("drawPolygon", $"canvas-{Id}", "11", "11", numberOfSides, colour, OuterBorder?.Color.ToString(), (OuterBorder?.LineType == LineType.Dashed).ToString());
                }
                else
                {
                    await module.InvokeVoidAsync("drawNestedPolygon", $"canvas-{Id}", "11", "11", numberOfSides, colour, OuterBorder?.Color.ToString(), (OuterBorder?.LineType == LineType.Dashed).ToString(), colour, InnerBorder.Color.ToString());
                }
            }

            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
