﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ITS.CORE.Dto
{
	public class CreateIsDto
	{
		public CreateIsDto()
		{
			Tarih = DateTime.Now;
		}
		public int IsId { get; set; }
		public string IsAdi { get; set; }
		public DateTime Tarih { get;  set; }
		public int IsverenId { get; set; }
		public int GrupId { get; set; }
	}
}
