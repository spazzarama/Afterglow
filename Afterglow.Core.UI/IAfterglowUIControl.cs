﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Afterglow.Core.UI
{
    public interface IAfterglowUIControl
    {
        event PluginsChangedEventHandler PluginsChanged;
    }
}
