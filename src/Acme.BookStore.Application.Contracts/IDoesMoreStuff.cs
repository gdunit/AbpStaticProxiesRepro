using System.Threading.Tasks;

namespace Acme.BookStore;

public interface IDoesMoreStuff<TDto>
{
    Task<TDto> DoMoreStuffAsync();
}