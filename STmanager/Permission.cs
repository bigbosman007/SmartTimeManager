namespace STmanager
{
    public class PermissionBase
    {
        public bool AllowProductAddEditDelete { get; set; }
        public bool AllowBranchManagement { get; set; }
    }

    class AdministratorPermission : PermissionBase
    {
        public AdministratorPermission()
        {
            AllowBranchManagement = true;
            AllowProductAddEditDelete = true;
        }
    }

}