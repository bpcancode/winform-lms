using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms.Models;

enum ItemType
{
    Book,
    DVD,
    CD
}
public class Item
{
    public string ItemName { get; set; }
    public string ItemDescription { get; set; }
}
