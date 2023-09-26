using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void Create(Command command)
        {
            throw new NotImplementedException();
        }

        public void Delete(Command command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 1,HowTo="Learn C#",Line="Documentation for Microsoft",Platform="Microsoft"},
                new Command{Id = 2,HowTo="Learn .NET",Line="Documentation for Microsoft",Platform="Microsoft"},
                new Command{Id = 3,HowTo="Use Visual Studio",Line="Documentation for Microsoft",Platform="Microsoft"},
                new Command{Id = 4,HowTo="Use Visual Studio Code",Line="Documentation for Microsoft",Platform="Microsoft"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{
                Id = 1,
                HowTo="Learn C#",
                Line="Documentation for Microsoft",
                Platform="Microsoft",
            };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Command command)
        {
            throw new NotImplementedException();
        }
    }
}