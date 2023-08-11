using Microsoft.AspNetCore.Razor.TagHelpers;

namespace taghelpersuygulama.TagHelpers
{
    [HtmlTargetElement("sayi")]
    public class Sayi : TagHelper
    {
        public int Sayim { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Sayim % 2 == 0)
            {
                output.Content.SetContent("Cift");
            }
            else
            {
                output.Content.SetContent("Tek");
            }
        }

    }
}
