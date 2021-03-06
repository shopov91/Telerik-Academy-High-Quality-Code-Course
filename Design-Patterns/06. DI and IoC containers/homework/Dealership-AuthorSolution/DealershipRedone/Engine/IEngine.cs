﻿using Dealership.Factories;

namespace Dealership.Engine
{
    public interface IEngine
    {
        void Start();

        void Reset(IDealershipFactory factory);
    }
}
