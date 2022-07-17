using PetRegisterAPI.Models;

namespace PetRegisterAPI.Repositories
{
    public interface IRepository
    {
        public Task<List<Pet>> GetPetList();
        public Task<Pet?> GetPetData(int id);
       /* public Task<bool> EditPetData(PetDTO pet);
        public Task<bool> CreatePetData(PetDTO pet);
        public Task<bool> DeletePetData(int id);*/

        /*public Task<List<Owner>> GetOwnersList();
        public Task<Owner> GetOwnerData(int id);
        ublic Task<bool> EditOwnerData(OwnerDTO owner);
        public Task<bool> CreateOwnerData(OwnerDTO owner);
        public Task<bool> DeleteOwnerData(int id);*/

        /*public Task<List<Category>> GetCategoryList();
        public Task<Category> GetCategoryData(int id);
        public Task<bool> EditCategoryData(CategoryDTO category);
        public Task<bool> CreateCategoryData(CategoryDTO category);
        public Task<bool> DeleteCategoryData(int id);*/
    }
}
