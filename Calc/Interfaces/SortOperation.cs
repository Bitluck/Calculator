using System.Collections.Generic;

namespace Calc
{
    public interface ISortOperation
    {
        List<int> Calculate(List<int> argument);
    }
}
