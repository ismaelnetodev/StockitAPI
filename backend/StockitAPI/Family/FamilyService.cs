using StockitAPI.Data;
using StockitAPI.Exceptions;
using StockitAPI.Family.DTOs;

namespace StockitAPI.Family;

public class FamilyService
{

    private AppDbContext _context;
    
    public FamilyService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Family> CreateFamilyAsync(FamilyCreateDto familyCreateDto)
    {
        // TODO: Verificar o usuário logado
        Family family = new Family(familyCreateDto.Name /*A aqui o construtor da classe ja verifica null ou inválido*/, familyCreateDto.UserId); 
        _context.Families.Add(family);
        await _context.SaveChangesAsync();
        return family;
    }

    public async Task<Family> GetFamilyAsync(Guid id)
    {
       return _context.Families.FindAsync(id).Result ?? throw new EntityNotFoundException("Family not found");
    }

    public async Task<Family> UpdateFamily(Guid id)
    {
        Family family = _context.Families.FindAsync(id).Result ?? throw new EntityNotFoundException("Family not found");
    }
}