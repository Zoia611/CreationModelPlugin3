using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationModelPlugin3
{
    public class CreationModel
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
           
            List<Wall> walls = CreateModel.CreateWalls(commandData);

            Level level1 = CreateModel.GetLevels(commandData).Where(x => x.Name.Equals("Уровень 1")) as Level;

            Level level2 = CreateModel.GetLevels(commandData).Where(x => x.Name.Equals("Уровень 2")) as Level;

            CreateModel.AddDoor(commandData, level1, walls[0]);

            CreateModel.AddWindows(commandData, level1, walls.GetRange(1, 3));

            CreateModel.AddRoof2(commandData, walls);

            return Result.Succeeded;
        }
    }
}
