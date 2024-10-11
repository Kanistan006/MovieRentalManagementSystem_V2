using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V2
{
    public class Movie
    {
        public string movieId { get; set; }
        public string title { get; set; }
        public string director { get; set; }
        public decimal rentalPrice { get; set; }

    




        public Movie(string movieId, string title, string director, decimal rentalPrice)
        {
            this.movieId = movieId;
            this.title = title;
            this.director = director;
            this.rentalPrice = rentalPrice;
      
        }

        public Movie()
        {

        }



      
    }

}
