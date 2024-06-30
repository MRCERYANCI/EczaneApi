using EczaneApi.Dtos.DrugDtos;

namespace EczaneApi.Repositories.DrugRepositories
{
    public interface IDrugRepository
    {
        Task<List<ResultDrugDto>> GetAllResultDrugAsync();
        Task<ResultDrugDto> GetResultDrugAsync(decimal barcode);
    }
}
