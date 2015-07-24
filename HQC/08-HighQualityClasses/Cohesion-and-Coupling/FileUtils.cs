namespace CohesionAndCoupling
{
    using System;

    public static class FileUtils
    {
        public static string GetFileExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("No file specified.");
            }

            int lastDotIndex = fileName.LastIndexOf(".");
            if (lastDotIndex == -1)
            {
                return string.Empty;
            }

            string fileExtension = fileName.Substring(lastDotIndex + 1);
            return fileExtension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("No path specified.");
            }

            int lastDotIndex = fileName.LastIndexOf(".");
            if (lastDotIndex == -1)
            {
                return fileName;
            }

            string fileNameWithoutExtension = fileName.Substring(0, lastDotIndex);
            return fileNameWithoutExtension;
        }
    }
}