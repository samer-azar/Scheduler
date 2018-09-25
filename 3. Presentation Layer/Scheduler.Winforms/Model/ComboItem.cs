using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Model
{
    /// Model used for combo box items
    public class ComboItem
    {
        /// Default constructor
        public ComboItem() { }
        /// Parameterized constructor
        public ComboItem(int id, string value)
        {
            this.Id = id;
            this.Value = value;
        }

        ///
        public int Id { get; set; }
        ///
        public string Value{ get; set; }

    }
}
