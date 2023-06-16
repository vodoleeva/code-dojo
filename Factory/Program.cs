using Factory.Entities.Creators.Abstract;
using Factory.Entities.Creators.Concrete;

namespace Factory
{

    class MainApp
    {
        static void Main()
        {
            // List of all Access Roles
            List<AccessRole> accessRoles = new List<AccessRole>
            {
                new User(),
                // ...add more
            };
            
            Console.ReadKey();
        }
    }
}
