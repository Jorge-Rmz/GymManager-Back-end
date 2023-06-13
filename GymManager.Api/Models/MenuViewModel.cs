﻿using GymManager.Core.Navigation;
using System.Collections.Generic;

namespace GymManager.Api.Models
{
    public class MenuViewModel
    {
        public string CurrentPageName { get; set; }

        public List<UserMenuItem> Menu { get; set; }
    }
}
