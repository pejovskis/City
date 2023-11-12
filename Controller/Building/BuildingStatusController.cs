using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City.Model.Building;

namespace City.Controller.BuildingController
{

    // Workers Employed change
    public class BuildingStatusController
    {
        public static void WorkersEmployedChange(Building Building, NumericUpDown inWorkersEmployed)
        {
            int InputWorkers = Convert.ToInt32(inWorkersEmployed.Value);

            if (InputWorkers <= Building.WorkerCapacity && InputWorkers >= 0)
            {
                Building.WorkersEmployed = InputWorkers;
            }

        }

        public static void SalaryMonthlyChange(Building Building, NumericUpDown inSalaryMonthly)
        {
            int InputSalary = Convert.ToInt32(inSalaryMonthly.Value);

            if (InputSalary > 0)
            {
                Building.SalaryMonhtly = InputSalary;
            }

        }

    }


}
