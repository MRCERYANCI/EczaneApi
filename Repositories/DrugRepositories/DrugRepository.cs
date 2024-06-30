using Dapper;
using EczaneApi.Dtos.DrugDtos;
using EczaneApi.Models.DapperContext;

namespace EczaneApi.Repositories.DrugRepositories
{
    public class DrugRepository : IDrugRepository
    {
        private readonly Context _context;

        public DrugRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultDrugDto>> GetAllResultDrugAsync()
        {
            string query = "Select * From DRUG";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultDrugDto>(query);
                return values.ToList();
            }
        }

        public async Task<ResultDrugDto> GetResultDrugAsync(decimal barcode)
        {
            string query = "Select * From DRUG Where BARCODE=@barcode";
            var parameters = new DynamicParameters();
            parameters.Add("@barcode", barcode);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<ResultDrugDto>(query, parameters);
                return values;
            }
        }
    }
}
