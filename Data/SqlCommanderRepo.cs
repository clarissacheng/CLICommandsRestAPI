using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data{ //Implemented SQL Commander concrete class that implements interface/DB context
    public class SqlCommanderRepo : ICommanderRepo{
        
        private readonly CommanderContext _context;
        public SqlCommanderRepo(CommanderContext context){ //Instance of dependency injection of DB context class
            _context = context;
        }

        public void CreateCommand(Command cmd){
            if(cmd == null){
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Add(cmd);
        }

        public void DeleteCommand(Command cmd){
            if(cmd == null){
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Commands.Remove(cmd);
        }
        
        public IEnumerable<Command> GetAllCommands(){
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id){
            return _context.Commands.FirstOrDefault(p => p.Id  == id);
        }

        public bool SaveChanges(){ //Saves changes to the database via the Db context
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd){
            //Nothing
        }
    }
}