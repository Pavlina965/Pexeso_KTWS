﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pexeso
{
        class FileHelper
        {
            public string GetLocalFilePath(string filename)
            {
                return Path.Combine("", filename);
            }
        }
}
