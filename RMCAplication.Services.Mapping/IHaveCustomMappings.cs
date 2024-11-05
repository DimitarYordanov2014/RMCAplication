using AutoMapper;

namespace RMCAplication.Services.Mapping
{
    public interface IHaveCustomMappings
    {
        void CreateMapping(IProfileExpression configuration);
    }
}
