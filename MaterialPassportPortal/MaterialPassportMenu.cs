using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MaterialPassportPortal
{
    public class MaterialPassportMenu : Autodesk.Revit.UI.IExternalApplication
    {
        static string MyAssemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        static string MyAssemblyDir = Path.GetDirectoryName(MyAssemblyPath);

        public Result OnStartup(UIControlledApplication application)
        {
            //Create  A button
            RibbonPanel MaterialPanel = application.CreateRibbonPanel("Material Passport");

            //Info
            string HelpURL = "https://github.com/DavidVeld/";
            ContextualHelp contextualHelp = new ContextualHelp(ContextualHelpType.Url, HelpURL);

            //Create  A button
            PushButton pB_passportParams = MaterialPanel.AddItem(new PushButtonData("SetParameters", "SetParameters", MyAssemblyPath, "MaterialPassportPortal.SetParameters")) as PushButton;
            //LImage
            Uri img_PassportParams = new Uri(MyAssemblyDir + @"\img\ico_Passport32.png");
            BitmapImage limg_PassportParams = new BitmapImage(img_PassportParams);
            //SImahe
            Uri imgsmll_PassportParams = new Uri(MyAssemblyDir + @"\img\ico_Passport16.png");
            BitmapImage smllimg_PassportParams = new BitmapImage(imgsmll_PassportParams);

            pB_passportParams.LargeImage = limg_PassportParams;
            pB_passportParams.Image = smllimg_PassportParams;
            pB_passportParams.SetContextualHelp(contextualHelp);
            pB_passportParams.ToolTip = "Setup The Parameters";

            return Result.Succeeded;
        }
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

    }
}
