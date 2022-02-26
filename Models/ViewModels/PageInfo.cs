﻿using System;
namespace WaterProject.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumProjects { get; set; }
        public int ProjectsPerPage { get; set; }
        public int CurrentPage { get; set; }

        //Figure out how many pages we need
        //Cast to double and then into to get actual number includig decimal value
        //Use math.ceiling to always round result up
        public int TotalPages => (int) Math.Ceiling((double) TotalNumProjects / ProjectsPerPage);
    }
}
