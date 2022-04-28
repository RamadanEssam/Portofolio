using Core.Entities;
using System.Collections.Generic;

namespace Web.ViewModels
{
    public class HomeViewModel
    {
        // عباره عن كلاس تحتوي علي ما نريد عرضه فقط
        public Owner Owner { get; set; }
        public List<PortfolioItem> portfolioItems { get; set; }


    }
}
