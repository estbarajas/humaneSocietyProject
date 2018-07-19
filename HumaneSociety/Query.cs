using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query
    {
        internal static void RunEmployeeQueries(Employee employee, string v)
        {
            throw new NotImplementedException();
        }

        public static Client GetClient(string userName, string password)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from clients in db.Clients
                         where (clients.UserName == userName) && (clients.Password == password)
                         select clients).First();
            return result;
        }

        public static IQueryable<Adoption> GetUserAdoptionStatus(Client person)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = from adoption in db.Adoptions
                         select adoption;
            return result;
        }

        public static IQueryable<Animal> GetAnimalByID(int iD)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = from animal in db.Animals
                         where animal.AnimalId == iD
                         select animal;
            return result;
        }

        internal static void Adopt(object animal, Client client)
        {
            throw new NotImplementedException();
        }

        public static IQueryable<Client> RetrieveClients()
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = from clients in db.Clients
                         select clients;
            return result;
        }

        public static IQueryable<USState> GetStates()
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = from states in db.USStates
                         select states;
            return result;
        }

        internal static void updateClient(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateUsername(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateEmail(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateAddress(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateFirstName(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            throw new NotImplementedException();
        }

        public static IQueryable<Adoption> GetPendingAdoptions()
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from pending in db.Adoptions
                         where pending.ApprovalStatus == "Pending"
                         select pending);
            return result;
        }

        internal static void UpdateLastName(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateAdoption(bool v, Adoption adoption)
        {
            throw new NotImplementedException();
        }

        public static IQueryable<AnimalShot> GetShots(Animal animal)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = from shots in db.AnimalShots
                         where shots.AnimalId == animal.AnimalId
                         select shots;
            return result;      
        }

        internal static void UpdateShot(string v, Animal animal)
        {
            throw new NotImplementedException();
        }

        public static IQueryable<Species> GetSpecies(string speciesName) //NEED TO ADD AND IF TO COVER IF SPECIES DOES NOT EXIST
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();

            var result = from species in db.Species
                         where species.Name == speciesName
                         select species;
            return result;
        }

        public static DietPlan GetDietPlan()
        {
            throw new NotImplementedException();
            //HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            //var result = from plans in db.DietPlans
            //             select plans;
            //return result
        }

        internal static void AddAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static Employee EmployeeLogin(string userName, string password)
        {
            throw new NotImplementedException();
        }

        internal static void AddUsernameAndPassword(Employee employee)
        {
            throw new NotImplementedException();
        }

        internal static Employee RetrieveEmployeeUser(string email, int employeeNumber)
        {
            throw new NotImplementedException();
        }

        internal static bool CheckEmployeeUserNameExist(string username)
        {
            throw new NotImplementedException();
        }

        internal static void EnterUpdate(Animal animal, Dictionary<int, string> updates)
        {
            throw new NotImplementedException();
        }

        internal static void RemoveAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        public static Room GetRoom(int animalId)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from room in db.Rooms
                         where room.AnimalId == animalId
                         select room).First();
            return result;
        }
    }
}
