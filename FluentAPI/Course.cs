﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
	public class Course
	{
		public Course()
		{
			Tags = new HashSet<Tag>();
		}

		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public int Level { get; set; }

		public float FullPrice { get; set; }

		public virtual Author Author { get; set; }

		public ICollection<Tag> Tags { get; set; }
	}

}