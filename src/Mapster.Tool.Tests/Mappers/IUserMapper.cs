using System.Linq.Expressions;

namespace Mapster.Tool.Tests.Mappers;

[Mapper]
public interface IUserMapper
{
    /// <summary>
    /// some doc
    /// </summary>
    Expression<Func<_User, _UserDto>> UserProjection { get; }
    _UserDto MapTo(_User user);
    _UserDto MapTo(_User user, _UserDto userDto);
}