﻿using System.Threading.Tasks;

namespace Lykke.Service.Dynamic.Sign.Core.Services
{
    public interface IShutdownManager
    {
        Task StopAsync();
    }
}