using System;
 
namespace exemploinjdependencia
{
    public interface ITesteA
    {
        Guid IdReferencia { get; }
    }
 
    public interface ITesteB
    {
        Guid IdReferencia { get; }
    }
}
