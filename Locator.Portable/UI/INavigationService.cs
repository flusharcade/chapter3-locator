﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INavigationService.cs" company="Flush Arcade">
//   Copyright (c) 2015 Flush Arcade All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Locator.Portable.UI
{
	using Locator.Portable.Enums;
	using System.Collections.Generic;

	public interface INavigationService
	{
		void Navigate (PageNames pageName, IDictionary<string, object> navigationParameters);
	}
}

