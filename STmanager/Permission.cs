namespace STmanager
{
    public class PermissionBase
    {
        public string Name { get; set; }
        public bool AllowProductAddEditDelete { get; set; }
        public bool AllowBranchManagement { get; set; }
    }

    class AdministratorPermission : PermissionBase
    {
        public AdministratorPermission()
        {
            Name = "Administrator";
            AllowBranchManagement = true;
            AllowProductAddEditDelete = true;
        }
    }

}