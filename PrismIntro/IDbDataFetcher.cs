using System;
using System.Collections.Generic;

namespace PrismIntro
{
    public interface IDbDataFetcher
    {
        String GetData(string command);    
    }
}
