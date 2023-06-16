namespace Factory.Entities.Creators.Abstract;

/// <summary>
/// The 'Creator' abstract class
/// </summary>
abstract class AccessRole
{
    // Menu Items that this Role can access. By default empty.
    private List<MenuItem> _menuItems = new List<MenuItem>();
    
    // Constructor calls abstract Factory method
    public AccessRole()
    {
        this.CreateMenuItems();
        Console.WriteLine("\n" + this.GetType().Name + ":");
        foreach (MenuItem menuItem in this.MenuItems)
        {
            Console.WriteLine("    " + menuItem.GetType().Name);
        }
    }
    
    public List<MenuItem> MenuItems
    {
        get { return _menuItems; }
    }
    
    // Factory Method that needs to be overriden in Concrete Creators
    public abstract void CreateMenuItems();
}
