using Microsoft.EntityFrameworkCore;
using PetRegisterAPI.Models;


namespace PetRegisterAPI.Repositories
{
    public class DataBaseRepository : IRepository
    {
        private readonly PetRegisterContext context;

        public DataBaseRepository(PetRegisterContext dbContext)
        {
            context = dbContext;
        }

        public async Task<List<Pet>>GetPetList() {
            var petList = await context.Pets.ToListAsync();
            return petList;
        }

        public async Task<Pet?> GetPetData(int id)
        {
            var petData = await context.Pets.FirstOrDefaultAsync(x => x.Id == id);
            return petData;
        }
        
        public async Task<List<Owner>> GetOwnerList() {
            var ownerList = await context.Owners.ToListAsync();
            return ownerList;
        }

        public async Task<Owner?> GetOwnerData(int id)
        {
            var ownertData = await context.Owners.FirstOrDefaultAsync(x => x.Id == id);
            return ownertData;
        }

        public async Task<List<Category>> GetCategoryList()
        {
            var categoryList = await context.Categories.ToListAsync();
            return categoryList;
        }

        public async Task<Category?> GetCategoryData(int id)
        {
            var categoryData = await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            return categoryData;
        }


    }
}
