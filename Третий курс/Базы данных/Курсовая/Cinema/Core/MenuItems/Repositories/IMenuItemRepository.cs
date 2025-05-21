namespace Core.MenuItems.Repositories;

public interface IMenuItemRepository
{
    Result Add(MenuItem menuItem);

    IEnumerable<MenuItem> GetMenuItems();

    Result Update(string oldName, MenuItem menuItem);

    Result Delete(string name);
}