﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Model
{
    public class BookDetails
    {
        public int Id { get; set; }

        public string BookName { get; set; }

        public int PublicationYear { get; set; }

        public string Language { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }
    }
}


