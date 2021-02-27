using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIRealPerson(gamer)== true)
            {
                Console.WriteLine($"Gamer {gamer} added");
            }
            else
            {
                Console.WriteLine($"Operation failed -> Add");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            if (_gamerCheckService.CheckIRealPerson(gamer) == true)
            {
                Console.WriteLine($"Gamer {gamer} deleted");
            }
            else
            {
                Console.WriteLine($"Operation failed -> Delete");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckService.CheckIRealPerson(gamer) == true)
            {
                Console.WriteLine($"Gamer {gamer} update");
            }
            else
            {
                Console.WriteLine($"Operation failed -> Update");
            }
        }
    }
}
