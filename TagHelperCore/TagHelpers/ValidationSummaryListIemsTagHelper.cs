using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;

namespace TagHelperCore.TagHelpers
{
    public class ValidationSummaryListIemsTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        [HtmlAttributeName("validation-order")]
        public Dictionary<int, string> ValidationOrder { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)

        {
            var errors = ViewContext.ModelState
                .Where(x => x.Value.Errors.Any())
                .Select(s => new { ControlId = s.Key, s.Value.Errors.FirstOrDefault()?.ErrorMessage })
                .ToList();

            if (errors.Any())
            {
                var orderedErrors = errors
                    .Select(s => new { Order = ValidationOrder?.Single(d => d.Value.Equals(s.ControlId)).Key, s.ErrorMessage, s.ControlId })
                    .OrderBy(o => o.Order)
                    .ToList();

                output.Content.AppendHtml(@"<div class=""alert alert-danger mrgn-tp-xl"" tabindex=""-1"">");
                output.Content.AppendHtml("<section>");
                output.Content.AppendFormat("<h2>The form could not be submitted because {0} errors were found.</h2>", orderedErrors.Count);
                output.Content.AppendHtml("<ul>");

                foreach (var error in orderedErrors)

                {
                    output.Content.AppendFormat(@"<li><a href=""#{0}"">Error: {1}</a></li>", error.ControlId, error.ErrorMessage);
                }

                output.Content.AppendHtml("</ul>");
                output.Content.AppendHtml("</section>");
                output.Content.AppendHtml("</div>");

            }
            else
            {
                output.SuppressOutput();
            }
        }
    }
}