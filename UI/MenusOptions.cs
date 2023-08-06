using System.Collections.Generic;

namespace OOp_Console_Application.UI
{
    class MenusOptions
    {
     
        public static List<string> UserLoginMenu()
        {
            List<string> menuOptions = new List<string> { "Sign Up", "Sign In", "Exit" };
            return menuOptions;
        }
   
        public static List<string> AdminMenu()
        {
            List<string> menuOptions = new List<string>
    {
        "Manage Stock",
        "Manage Customers",
        "Manage Admins",
        "Back to Login Menu"
    };
            return menuOptions;
        }
        public static List<string> ManageStockMenu()
        {
            List<string> menuOptions = new List<string>
            {
        "Add Items",
        "View Stock",
        "Delete Item",
        "Update Item",
        "Search Item",
        "Back To Admin Menu"
            };
            return menuOptions;
        }
        public static List<string> ManageAdminMenu()
        {
            List<string> menuOptions = new List<string>
            {
                 "View Admin",
                 "Add Admin",
                 "Delete Admin",
                 "Back To Admin Menu",
             };
            return menuOptions;
        }
        public static List<string> ManageCustomerMenu()
        {
            List<string> menuOptions = new List<string>
            {
                 "View Customers",
                 "Delete Customers",
                 "Back To Admin Menu",
             };
            return menuOptions;
        }
        public static List<string> EditMenu()
        {
            List<string> menuOptions = new List<string>
    {
        "Edit Name",
        "Edit Price",
        "Edit Quantity",
        "Edit Complete Product",
        "Back to Stock Menu"
    };
            return menuOptions;
        }
        public static List<string> UserMenu()
        {
            List<string> menuOptions = new List<string>
{
    "View Stock",
    "Purchase Items",
    "Search Item",
    "View Bill",
    "View Admins",
    "Get Help",
    "Back to Main Menu"
};
            return menuOptions;
        }
    }
}
