using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms.Models;

public class DVD : Item
{
    public string Duration { get; set; }
    public List<string> Contents { get; set; }

    
}
