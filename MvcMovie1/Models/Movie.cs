﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using MvcMovie1.Models;

namespace MvcMovie1.Models
{
	public class Movie
	{
		public int ID {  get; set; }
		public string Title { get; set; } 
		[Display(Name = "Realease Date")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime ReleaseDate { get; set; }
		public string Genre { get; set; }
		public decimal Price { get; set; } 
	}
}

 public class MovieDBContext : DbContext 
 {
 	 public DbSet<Movie> Movies { get; set; }
 }