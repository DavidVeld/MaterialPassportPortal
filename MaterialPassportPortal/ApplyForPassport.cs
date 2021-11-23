using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialPassportPortal
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]

    class ApplyForPassport : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication app = commandData.Application;

            ApplyForPassportDialog ApplyForPassportWindow = new ApplyForPassportDialog();
            ApplyForPassportWindow.ShowDialog();

            return Result.Succeeded;

        }
    }
}
