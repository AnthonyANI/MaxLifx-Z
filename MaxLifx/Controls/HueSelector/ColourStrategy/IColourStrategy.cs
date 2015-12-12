﻿using System.Collections.Generic;

namespace MaxLifx.Controls.ColourStrategy
{
    public interface IColourStrategy
    {
        void ProcessHandles(List<HueSelectorHandle> handles, int fromHandleNumber, double previousHue,
            double previousSaturation);
    }
}