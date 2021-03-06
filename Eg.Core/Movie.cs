﻿using System.Collections.Generic;

namespace Eg.Core
{
    public class Movie : Product
    {
        public virtual string Director { get; set; }
        public virtual IList<ActorRole> Actors { get; set; }
    }
}