using BlazorShop.Server.Primitives;
using BlazorShop.Shared.Dtos;
using BlazorShop.Shared.Pagination.Parameters;

namespace BlazorShop.Server.Services.UserService;

public interface IUserService
{
    Task<PagedList<UserDto>> GetUsersByParametersAsync(BaseParameters parameters);
    Task<UserDto?> GetUserByIdAsync(Guid id);
    Task<UserDto?> GetUserByUsernameAsync(string username);
    Task DeleteUserAsync(Guid id);
}