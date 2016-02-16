using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNet.Html.Abstractions;
using Microsoft.AspNet.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{

	[RestrictChildren("panel-header", "panel-body", "panel-footer")]
	public class PanelTagHelper : TagHelper
	{
		public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			var classNames = "panel";
			output.TagName = "div";
			output.Attributes["class"] = output.Attributes.ContainsName("class") ? $"{output.Attributes["class"].Value} {classNames}" : classNames;
		}
	}
}
