using System;
using System.ComponentModel.DataAnnotations;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTask.Models
{
    public class Book
    {
        private int _id;
        private string _name;
        private int _publicationYear;
        private string _genre;


        [Key]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        [Column(TypeName = "nvarchar(50)")]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        [Column(TypeName = "nvarchar(50)")]
        public int PublicationYear
        {
            get
            {
                return _publicationYear;
            }
            set
            {
                _publicationYear = value;
            }
        }

        [Column(TypeName = "nvarchar(50)")]
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
            }
        }



        public Book()
        {
        }
    }
}