﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Samples.Models
{
	public class Album
	{
		public int AlbumID { get; set; }
		public string Name { get; set; }
		public int ArtistID { get; set; }
		public string Artist { get; set; }
		
		[Timestamp()]
		public byte[] RowVersion { get; set; }
	}
}
