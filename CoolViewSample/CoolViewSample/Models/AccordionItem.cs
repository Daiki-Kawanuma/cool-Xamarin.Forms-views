using CoolViewSample.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolViewSample.Models
{
    public class AccordionItem : ISelectable
    {
        public bool IsVisible { get; set; }
        public bool IsSelected { get => _isSelected; set => _isSelected = value; }
        private bool _isSelected;
    }
}
