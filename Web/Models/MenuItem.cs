
namespace Zee.AspNetCore.AdminLTE3.Web.Models
{
    public class MenuItem
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Controller { get; set; }
        public string DefaultAction { get; set; }
        public int Sort { get; set; }
        #endregion
    }
}