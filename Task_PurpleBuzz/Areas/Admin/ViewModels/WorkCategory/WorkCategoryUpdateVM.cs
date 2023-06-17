﻿using System.ComponentModel.DataAnnotations;

namespace Task_PurpleBuzz.Areas.Admin.ViewModels.WorkCategory
{
	public class WorkCategoryUpdateVM
	{
		[Required(ErrorMessage = "Name of new Category is required")]
		[MinLength(3, ErrorMessage = "Name must consist of at least 3 characters")]
		[MaxLength(20, ErrorMessage = "Name can not be set over 20 characters")]
		public string Name { get; set; }
    }
}
