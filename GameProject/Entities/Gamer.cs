using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Gamer : IGamer
    {
        public string Id { get ; set; }
        public string FirstName { get ;set; }
        public string NationalityId { get; set ; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get ; set ; }
    }
}
