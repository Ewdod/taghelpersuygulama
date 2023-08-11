using Microsoft.AspNetCore.Razor.TagHelpers;

namespace taghelpersuygulama.TagHelpers
{
    public class Google : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "https://www.google.com");
            output.Content.SetContent("Google a git");
        }
    }
}
