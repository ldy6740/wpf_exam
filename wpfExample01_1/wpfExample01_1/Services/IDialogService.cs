﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfExample01_1.Services
{
    public interface  IDialogService
    {
        string OpenFile(string filter);
        void ShowMessageBox(string message);
    }
}
