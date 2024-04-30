using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TekrarApp.CustomTagHelpers
{

    [HtmlTargetElement("TC")]
    public class TekCiftTagHelper : TagHelper
    {
        public int Sayi { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Sayi % 2 == 0)
                output.Content.SetContent("Çift");
            else
                output.Content.SetContent("Tek");
        }
    }
}
