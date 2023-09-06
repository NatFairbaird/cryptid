using Cryptid.Domain.Enums;
using Microsoft.AspNetCore.Components;

namespace Cryptid.Components
{
    public partial class Icon
    {
        [Parameter]
        public IconType IconType { get; set; }

        [Parameter]
        public IconColor Color { get; set; }

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
    }
}
