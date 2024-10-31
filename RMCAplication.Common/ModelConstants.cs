using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Common
{
    public class ModelConstants
    {
        public const int WarehouseNameMaximumLenght = 25;
        public const int WarehouseNameMinimumLenght = 2;

        public const int ToolNameMaximumLenght = 50;
        public const int ToolNameMinimumLenght = 3;

        public const int SparePartNameMaximumLenght = 50;
        public const int SparePartMinimumLenght = 3;

        public const int PersonNameMaximumLenght = 100;
        public const int PersonNameMinimumLenght = 3;

        public const int ConsumableNameMaximumLenght = 100;
        public const int ConsumableNameMinimumLenght = 3;

        public const int MechanizationNameMaximumLenght = 100;
        public const int MechanizationNameMinimumLenght = 3;

        public const int DescriptionMaximumLenght = 250;
        public const int DescriptionMinimumLenght = 10;


        //public const string RequireErrorMessage = "The field {0} is required";
        //public const string StringLengthErrorMessage = "The field {0} must be between {2} and {1} characters long";

        public const string AddedOnTimeFormat = "dd-MM-yyyy";
    }
}
