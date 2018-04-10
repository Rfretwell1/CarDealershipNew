using System.Collections.Generic;

namespace CarClassLibrary
{
    public class clsMaintenanceCollection
    {
        public int count { get; set; }
        public List<clsMaintenance> MaintenanceList { get; set; }
        public clsMaintenance ThisMaintenance { get; set; }
    }
}