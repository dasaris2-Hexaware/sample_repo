using System.Collections.Generic;

namespace DotnetwithMogoDB.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
