﻿using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class CourseCatagoryViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public CourseCatagoryViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<CourseDetail> courseDetails = await _context.CourseDetails.Take(take).ToListAsync();
            return (await Task.FromResult(View(courseDetails)));
        }
    }
}