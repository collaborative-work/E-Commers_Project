﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.NpgSql
{
    public class NSColorDal : NSRepositoryBase<Color>, IColorDal
    {
    }
}
