using System;
using System.Collections.Generic;
namespace conproj
{
    public interface IFileSystem<T> where T:class
    {

        List<T> Import(string srcFilePath);
        void Export(string destfile,List<T> ts);

    }
}
