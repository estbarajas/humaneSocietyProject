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

        public static void Adopt(object animal, Client client)
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

        public static void updateClient(Client client)
        {
            UpdateFirstName(client);
            UpdateLastName(client);
            UpdatePassword(client);
            UpdateAddress(client);
            UpdateEmail(client);
            UpdateIncome(client);
            UpdateNumberOfKids(client);
            UpdateHomeSqFt(client);
        }

        public static void UpdateUsername(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from username in db.Clients
                         where username.ClientId == client.ClientId
                         select username).First();
            
            result.UserName = client.UserName;
            db.SubmitChanges();
        }

        public static void UpdatePassword(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from username in db.Clients
                          where username.ClientId == client.ClientId
                          select username).First();
            result.Password = client.Password;
            db.SubmitChanges();
        }

        public static void UpdateEmail(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from username in db.Clients
                          where username.ClientId == client.ClientId
                          select username).First();
            result.Email = client.Email;
            db.SubmitChanges();
        }

        public static void UpdateAddress(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from username in db.Clients
                          where username.ClientId == client.ClientId
                          select username).First();
            result.Address = client.Address;
            db.SubmitChanges();
        }

        public static void UpdateFirstName(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from username in db.Clients
                          where username.ClientId == client.ClientId
                          select username).First();
            result.FirstName = client.FirstName;
            db.SubmitChanges();
        }

        public static void UpdateLastName(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from username in db.Clients
                          where username.ClientId == client.ClientId
                          select username).First();
            result.LastName = client.LastName;
            db.SubmitChanges();
        }

        public static void UpdateIncome(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from username in db.Clients
                          where username.ClientId == client.ClientId
                          select username).First();
            result.Income = client.Income;
            db.SubmitChanges();
        }

        public static void UpdateNumberOfKids(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from username in db.Clients
                          where username.ClientId == client.ClientId
                          select username).First();
            result.NumberOfKids = client.NumberOfKids;
            db.SubmitChanges();
        }

        public static void UpdateHomeSqFt(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from username in db.Clients
                          where username.ClientId == client.ClientId
                          select username).First();
            result.HomeSquareFootage = client.HomeSquareFootage;
            db.SubmitChanges();
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

        public static void UpdateAdoption(bool v, Adoption adoption)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from adoptions in db.Adoptions
                         where adoptions.AdoptionId == adoption.AdoptionId
                         select adoptions).First();
            if(v == true)
            {
                result.ApprovalStatus = "Accepted";
            }
            db.SubmitChanges();
        }

        public static IQueryable<AnimalShot> GetShots(Animal animal)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = from shots in db.AnimalShots
                         where shots.AnimalId == animal.AnimalId
                         select shots;
            return result;      
        }

        public static void UpdateShot(string v, Animal animal)
        {
            throw new NotImplementedException();
            //HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            //var result = db.animalshotjunction
            //var result = (from shots in db.Shots
            //             where shots.AnimalId == animal.AnimalId
            //             select shots).First();
            //result.ShotId = v;
        }

        public static IQueryable<Species> GetSpecies(string speciesName) //NEED TO ADD AND IF TO COVER IF SPECIES DOES NOT EXIST
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();

            var result = from species in db.Species
                         where species.Name == speciesName
                         select species;
            return result;
        }

        public static DietPlan GetDietPlan(string dietPlan)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from plans in db.DietPlans
                         where plans.Name == dietPlan
                         select plans).First();
            return result;
        }

        public static void AddAnimal(Animal animal)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            db.Animals.InsertOnSubmit(animal);
            db.SubmitChanges();
        }

        public static Employee EmployeeLogin(string userName, string password)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from employees in db.Employees
                         where employees.UserName == userName && employees.Password == password
                         select employees).First();
            return result;
        }

        public static void AddUsernameAndPassword(Employee employee)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from employees in db.Employees
                         where employees.EmployeeId == employee.EmployeeId 
                         select employees).First();

            result.UserName = employee.UserName;
            result.Password = employee.Password;
            db.SubmitChanges();
        }

        public static Employee RetrieveEmployeeUser(string email, int employeeNumber)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var result = (from employee in db.Employees
                         where employee.Email == email || employee.EmployeeNumber == employeeNumber
                         select employee).First();
            return result;
        }

        public static bool CheckEmployeeUserNameExist(string username)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();

            var result = from employees in db.Employees
                         where employees.UserName == username
                         select employees;
            if (result != null)
            {
                Console.WriteLine("Found.");
                return true;
            }
            else {
                Console.WriteLine("Not found.");
                return false;
            }                         
        }

        internal static void EnterUpdate(Animal animal, Dictionary<int, string> updates)
        {
            throw new NotImplementedException();
        }

        public static void RemoveAnimal(Animal theAnimal)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();

            var result = (from animal in db.Animals
                         where animal.AnimalId == theAnimal.AnimalId
                         select animal).First();

            db.Animals.DeleteOnSubmit(result);
            db.SubmitChanges();
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
