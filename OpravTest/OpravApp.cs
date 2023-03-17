using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpravTest
{
    public class OpravApp
    {
        public void Run()
        {

        }
        public void Create(int id, string name, int idname, string race, string clas)
        {
            //aplikace umí vytvořit postavu
            using var dbContext = new AppDbContext();

            dbContext.Characters.Add(new Character
            {
                Id = id,
                IdName = idname,
                Name = name,
                Race = race,
                Clas = clas,
                Modified = DateTime.UtcNow
            });
            dbContext.SaveChanges();
        }
        public Character? GetById(int id)
        {
            //aplikace umí vybrat a zobrazit jeden záznam podle id

            using var dbContext = new AppDbContext();

            var character = dbContext.Characters.SingleOrDefault(x => x.Id == id);

            if (character == null)
            {
                return null;
            }
            else
            {
                return character;
            }
        }
        public void Print(Character[] characters)
        {
            //aplikace umí vybrat a zobrazit seznam záznamů

            foreach (var character in characters)
            {
                Console.WriteLine(character.Name);
            }
        }
        public void Edit(int id, string newName)
        {
            //aplikace umí upravit záznamu název/třídu podle id (změní upraveno)

            using var dbContext = new AppDbContext();

            var character = dbContext.Characters.SingleOrDefault(x => x.Id == id);

            if (character == null)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                character.Modified = DateTime.UtcNow;
                character.Name = newName;
                dbContext.Characters.Update(character);
                dbContext.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            //aplikace umí smazat záznam podle id

            using var dbContext = new AppDbContext();

            var character = dbContext.Characters.SingleOrDefault(x => x.Id == id);

            if (character == null)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                dbContext.Characters.Remove(character);
                dbContext.SaveChanges();
            }
        }
    }
}
