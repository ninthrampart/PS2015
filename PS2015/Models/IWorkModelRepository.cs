﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models
{
    interface IWorkModelRepository
    {
        List<WorkModel> GetForPassport(int psid);
    }
}
