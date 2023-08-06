using OOp_Console_Application.DL;
using System.Text.RegularExpressions;
using static System.Console;


namespace OOp_Console_Application.UI
{
    class Validtions
    {
       public static bool validate(string input)
        {
            string pattern = @"^\w{4,8}$";
            return Regex.IsMatch(input, pattern);
        }

        public static bool ValidateProduct(string match)
        {
            string pattern = @"^[\w ]{4,15}$";
            return Regex.IsMatch(match, pattern);
        }
        public static string ProductName()
        {
            while (true)
            {
                string name = InPuts.Messege("Product Name");
                bool validate = ValidateProduct(name);
                if (validate)
                {
                    bool Exist = ProductsDL.CheckProductExist(name);
                    if (Exist)
                    {
                        Instructions.AlreadyPresent("Product");
                    }
                    else
                    {
                        return name;
                    }
                }
                else
                {
                    Instructions.Reenter("Wrong Format.......Enter Minumum 4 or Maximum 15  Characters Do not Incluede Special Symbols: ");
                }
            }
        }
        public static float ProductPrice()
        {
            float price;
            while (true)
            {
                Write("Enter Product Price:");
                bool valid = float.TryParse(ReadLine(), out price);
                if (valid&&price>0)
                {
                    return price;
                }
                else
                {
                    Instructions.Reenter("Invalid input. Please enter a valid float number.");
                }

            }
        }
        public static int ProductQuantity()
        {
            int quantity;
            while (true)
            {
                Write("Enter Product Quantity:");
                bool valid = int.TryParse(ReadLine(), out quantity);
                if (valid&&quantity>0)
                {
                    return quantity;
                }
                else
                {
                    Instructions.Reenter("Invalid input. Please enter a valid int number.");
                }

            }
        }
        public static string UserName()
        {
            while (true)
            {
               string name = InPuts.Messege("Name");
                if (validate(name))
                {
                    return name;
                }
                else
                {
                    Instructions.Reenter("Wrong Format.......Enter Minumum 4 or Maximum 8 Characters Do not Incluede Special Symbols:");
                }
            }
        }
        public static string UserPassword()
        {
            while (true)
            {
               string password = InPuts.Messege("Password");
                if (validate(password))
                {
                    return password;
                }
                else
                {
                    Instructions.Reenter("Wrong Format.......Enter Minumum 4 or Maximum 8 Characters Do not Incluede Special Symbols:");
                }
            }
        }
        public static string Role(string field2)
        {
            while (true)
            {
               string role = InPuts.Messege($"Role  ({field2})");
                if (role==field2)
                {
                    return role;
                }
                else
                {
                    Instructions.Reenter("Wrong Role.......Enter Given Role Only (Case sensitive):");
                }
            }
        }

}
}
