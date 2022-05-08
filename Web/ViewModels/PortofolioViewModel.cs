using Microsoft.AspNetCore.Http;
using System;

namespace Web.ViewModels
{
    public class PortofolioViewModel
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile MyProperty { get; set; }
    }
}
