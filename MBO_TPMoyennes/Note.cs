﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MBO_TPMoyennes
{
    class Note
    {
        public int matiere { get; private set; }
        public float note { get; private set; }
        public Note(int m, float n)
        {
            matiere = m; note = n;
        }
    }   
}
