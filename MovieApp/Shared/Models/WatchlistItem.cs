﻿using System;
using System.Collections.Generic;

namespace MovieApp.Shared.Models
{
    public partial class WatchlistItem
    {
        public int WatchlistItemId { get; set; }
        public string WatchlistId { get; set; } = null!;
        public int MovieId { get; set; }
    }
}
