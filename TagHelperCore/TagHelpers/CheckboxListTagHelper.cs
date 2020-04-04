using TagHelperCore.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Text;

namespace TagHelperCore.TagHelpers
{
    [HtmlTargetElement("checkbox-list", Attributes = ForAttributeName + "," + ItemsAttributeName)]
    public class CheckboxListTagHelper : TagHelper
    {
        private const string ForAttributeName = "asp-for";
        private const string ItemsAttributeName = "asp-items";

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }

        [HtmlAttributeName(ItemsAttributeName)]
        public IEnumerable<Store> Items { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (ViewContext == null || For == null || Items == null) return;

            output.SuppressOutput();
            output.Content.Clear();

            var sb = new StringBuilder("");
            sb.AppendLine(@"<ul id=""tree"">");

            foreach (var item in Items)
            {
                sb.AppendLine("<li>");
                sb.AppendLine("<label>");
                sb.AppendFormat($@"<input type=""checkbox"" name=""{For.Name}"" id=""{For.Name}"" value=""{item.Id}"">");
                sb.Append(item.Name);
                sb.AppendLine("</label>");
                sb.AppendLine("<ul>");

                foreach (var i in item.Departments)
                {
                    //sb.AppendLine("<ul>");
                    sb.AppendLine("<li>");
                    sb.AppendLine("<label>");
                    sb.AppendFormat($@"<input type=""checkbox"" name=""{i.Id}"" id=""{i.Id}"" value=""{i.Name}"">");
                    sb.Append(i.Name);
                    sb.AppendLine("</label>");
                    sb.AppendLine("</li>");
                }

                sb.AppendLine("</ul>");
                sb.AppendLine("</li>");
            }

            sb.AppendLine("</ul>");
            output.Content.AppendHtml(sb.ToString());
        }
    }
}
