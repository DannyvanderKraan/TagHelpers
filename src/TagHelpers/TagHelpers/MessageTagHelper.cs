﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Razor.TagHelpers;
using Microsoft.AspNet.Mvc.ViewFeatures;

namespace TagHelpers.TagHelpers
{
	[HtmlTargetElement("span", Attributes = MessageValueAttributeName)]
	public class MessageTagHelper : TagHelper
    {
		private const string MessageValueAttributeName = "asp-message-value";
		private const string LevelValueAttributeName = "asp-level-value";

		[HtmlAttributeName(MessageValueAttributeName)]
		public string MessageValue { get; set; }

		[HtmlAttributeName(LevelValueAttributeName)]
		public int LevelValue { get; set; } = 1;

		[ViewContext]
		private ViewContext VwContext { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
				
			output.TagName = "div";
			output.TagMode = TagMode.StartTagAndEndTag;
			var content = $@"<h{LevelValue}>{MessageValue}</h{LevelValue}>";
			output.Content.AppendHtml(content);
		}
    }
}
