using System.Collections.Generic;
using Catalog.BLL.DTO;

namespace Catalog.BLL.Services.Interfaces
{
    public interface ISweetService
    {
        IEnumerable<SweetDTO> GetSweets(int page);
    }
}