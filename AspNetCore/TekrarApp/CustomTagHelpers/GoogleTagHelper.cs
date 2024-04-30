using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TekrarApp.CustomTagHelpers
{
    [HtmlTargetElement("Google")]
    public class GoogleTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Content.SetContent("google a git");
            output.Attributes.SetAttribute("href", "https://www.google.com.tr/?hl=tr");
        }
    }
}
