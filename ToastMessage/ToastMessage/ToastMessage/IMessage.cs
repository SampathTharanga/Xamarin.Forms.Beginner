using System;
using System.Collections.Generic;
using System.Text;

namespace ToastMessage
{
    public interface IMessage
    {
        void LongTime(string message);
        void ShortTime(string message);
    }
}
