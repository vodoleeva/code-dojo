using Factory.Creators.Abstract;
using Factory.Products.Concrete;

namespace Factory.Creators.Concrete;

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
