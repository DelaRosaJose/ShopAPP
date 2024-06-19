using ShopAPP.DAL.Models.Customers;

namespace ShopAPP.DAL.Interfaces
{
    public interface ICustomersDb
    {
        List<CustomersModel> GetCategories();
        CustomersModel GetCategoriesById(int id);
        void SaveCategories(CustomersAddModel categoriesAdd);
        void UpdateCategories(CustomersUpdateModel categoriesMod);
        void RemoveCategories(CustomersRemoveModel categoriesRem);
    }
}
