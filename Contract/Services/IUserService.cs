﻿using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Services
{
  public interface IUserService
  {
    User CurretUser { get; set; }
  }
}
