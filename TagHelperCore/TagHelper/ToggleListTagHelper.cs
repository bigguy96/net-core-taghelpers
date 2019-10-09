using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperCore.TagHelper
{
    [HtmlTargetElement("fieldset")]
    public class ToggleListTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        [HtmlAttributeName("items")]
        public ICollection<SelectListItem> SelectedItems { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var checkboxCount = 1;
            var htmlContent = new StringBuilder("");
            htmlContent.AppendLine(@"<legend><span class=""field-name"">Rating</span></legend>");

            foreach (var item in SelectedItems)
            {
                htmlContent.AppendLine(@"<div class=""checkbox"">");
                htmlContent.AppendLine($@"<input aria-required=""true"" data-val=""true"" id=""checkbox-{checkboxCount}"" name=""checkbox"" type=""checkbox"" value=""{item.Value}"">");
                htmlContent.AppendLine($@"<label for=""checkbox-{checkboxCount}"">{item.Text}</label>");
                htmlContent.AppendLine(@"</div>");
                checkboxCount++;
            }

            output.TagName = "fieldset";
            output.Attributes.Add("aria-required","true");
            output.Attributes.Add("data-val","true");
            output.Attributes.Add("class", "toggle-list-items-container checkbox-toggle-list");

            output.Content.SetHtmlContent(htmlContent.ToString());
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
