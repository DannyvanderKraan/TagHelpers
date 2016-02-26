using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Model
{
	public class SomeModel
	{
		[Required]
		[Display(Name="Type something here")]
		public string SomeString { get; set; }
		[MaxLength(5000)]
		public string SomeLargeString { get; set; }
	}
}
