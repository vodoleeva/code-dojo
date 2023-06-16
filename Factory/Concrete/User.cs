using Factory.Entities.Creators.Abstract;
using Factory.Entities.MenuItems;

namespace Factory.Entities.Creators.Concrete;

/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
class User : AccessRole
{
    // Factory Method implementation
    public override void CreateMenuItems()
    {
        MenuItems.Add(new IngoingTransports());
    }
}
