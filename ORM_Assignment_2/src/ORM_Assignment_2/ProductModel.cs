using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_Assignment_2
{
    public class ProductModel
    {
        [Key]
        public int Pid { get; set; }


        [MaxLength(50)]
        public string Pname { get; set; }



        [MaxLength(50)]
        public string Pdescription { get; set; }




        [MaxLength(50)]
        [Url]
        public string HomePageUrl { get; set; }

        [MaxLength(100)]
        public List<UpdateModel> Updates { get; set; }



    }
}
