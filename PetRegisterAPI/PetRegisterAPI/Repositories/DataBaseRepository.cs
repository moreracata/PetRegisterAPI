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


    }
}
