using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{
	[HtmlTargetElement("panel-body", ParentTag = "panel")]
	public class PanelBodyTagHelper : TagHelper
	{
		public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "div";
			output.Attributes["class"] = output.Attributes.ContainsName("class") ? $"{output.Attributes["class"].Value} panel-body" : "panel-body";
		}
	}
}
