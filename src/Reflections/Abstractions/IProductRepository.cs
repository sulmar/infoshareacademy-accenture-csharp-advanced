﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Abstractions;

internal interface IProductRepository
{
    Product Get(int id);
    void Add(Product product);
}
