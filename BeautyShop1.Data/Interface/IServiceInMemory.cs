﻿using BeautyShop1.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop1.Data.Interface
{
    public interface IServiceInMemory
    {
        List<Service> GetServices();
    }
}
