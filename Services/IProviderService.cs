﻿using System.Collections.Generic;

namespace VitruviSoft.SamvelAvagyan.Services
{
    public interface IProviderService
    {
        IEnumerable<string> GetProvidersNames(int id);
     }
}