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
        public string Value { get; set; }

    }

    /// Model used for hour list box items
    public class HourListBoxItem : ComboItem
    {
        /// Default constructor
        public HourListBoxItem() { }
        /// Parameterized constructor
        public HourListBoxItem(int id, string value, DateTime hour)
        {
            this.Id = id;
            this.Value = value;
            this.Hour = hour;
        }

        /// 
        public DateTime Hour { get; set; }
    }

}
