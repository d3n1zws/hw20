using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18.Exceptions;

public class ConflictException: Exception
{
    public ConflictException(string Message): base(Message)
    {
        
    }
}
