namespace STmanager
{
    public class PermissionBase
    {
        public string Name { get; set; }
        public bool AllowProductAddEditDelete { get; set; }
        public bool AllowBranchManagement { get; set; }
        public bool AllowAcceptProductShipment { get; set; }
    }

    class AdministratorPermission : PermissionBase
    {
        public AdministratorPermission()
        {
            Name = "Administrator";
            AllowBranchManagement = true;
            AllowProductAddEditDelete = true;
            AllowAcceptProductShipment = true;
        }
    }

    class ManagerPermission : PermissionBase
    {
        public ManagerPermission()
        {
            Name = "Manager";
            AllowBranchManagement = false;
            AllowProductAddEditDelete = false;
            AllowAcceptProductShipment = true;
        }
    }

    class SalepersonPermission : PermissionBase
    {
        public SalepersonPermission()
        {
            Name = "Saleperson";
            AllowBranchManagement = false;
            AllowProductAddEditDelete = false;
            AllowAcceptProductShipment = false;
        }
    }

}