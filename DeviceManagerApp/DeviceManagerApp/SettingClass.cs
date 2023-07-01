using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DeviceManagerApp
{
    public static class SettingClass
    {
        public static string path_Folder_Resource= Path.GetFullPath("../../../resources/");
        public static string path_Folder_QR_Image = Path.GetFullPath("../../../resources/QR/");
        public static string path_Folder_Default_Image = Path.GetFullPath("../../../resources/DefaultImage/");
        public static string path_Folder_Image_Device = Path.GetFullPath("../../../resources/ImageDevice/");
        public static string path_Image_Device_Default = Path.GetFullPath("../../../resources/DefaultImage/pc.jpg");
        public static string path_NoImage_Default = Path.GetFullPath("../../../resources/DefaultImage/no_image1.png");
        public static string path_ErrorFile_Default = Path.GetFullPath("../../../resources/DefaultImage/file_error.jpg");
    }
}
