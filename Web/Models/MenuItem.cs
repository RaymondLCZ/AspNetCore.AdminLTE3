using System;
using System.Collections;
using System.Collections.Generic;

namespace Zee.AspNetCore.AdminLTE3.Web.Models
{
    public class MenuItem
    {
        #region fields
        private ICollection<MenuItem> _items;

        #endregion

        #region properties
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Controller { get; set; }
        public string DefaultAction { get; set; }
        public string CssClass { get; set; }
        public int Sort { get; set; }
        #endregion

        #region navigation properties
        public MenuItem ParentMenuItem { get; set; }

        public ICollection<MenuItem> SubItems
        {
            get { return _items ?? (_items = new List<MenuItem>()); }
            private set { _items = value; }
        }
        #endregion
    }
}