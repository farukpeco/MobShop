﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiMobiteli.ViewModel
{
	public class AdminProizvodjacDodajVM
	{
		public int ProizvodjacId { get; set; }
		public int DrzavaId { get; set; }
		public string Naziv { get; set; }
		public List<SelectListItem> Drzava { get; set; }
	}
}
