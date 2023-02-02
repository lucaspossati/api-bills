using System.ComponentModel;

namespace API.ValueObjects{
    public enum ETypeRole
    {
        [Description("Admin")]
        Admin,
        [Description("UserDefault")]
        UserDefault,
    }
}