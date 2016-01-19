using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace HealthObservations.App_Code
{
    /**
     * Provide a less tightly coupled Graphing Object 
     * 1st pass (YAGNI?)
     *
     */
    public class Grapher
    {
        //TODO add the temp file path to config - don't hard code it
        static private string filePath = "~/temp/";
        //TODO Use AutoProperty initialization (C# 6)
        public string FilePath
        {
            get { return filePath; }
        }

        private string filePathName = filePath + Path.GetRandomFileName() + ".png";
        public string FilePathName
        {
            get { return filePathName; }
        }
        //This is wrapping a Web server based chart object
        private Chart chart;
        public int Width { get; set; }
        public int Height { get; set; }

        private System.Collections.IEnumerable dataSetX, dataSetY;
        /// <summary>
        /// Create a graph on the server of a data series
        /// </summary>
        /// <param name="dataSetX">IEnumerable horizontal series</param>
        /// <param name="dataSetY">IEnumberable vertical series</param>
        public Grapher(System.Collections.IEnumerable dataSetX, System.Collections.IEnumerable dataSetY)
        {
            this.dataSetX = dataSetX;
            this.dataSetY = dataSetY;
            if (!File.Exists(System.Web.Hosting.HostingEnvironment.MapPath(filePath)))
            {
                //TODO log any exceptions
                chart = new Chart(width: 600, height: 600);
                chart.AddSeries(chartType: "Line",
                        xValue: dataSetX,
                        yValues: dataSetY);
                chart.Save(filePathName, "png");
                //TODO solve file cleanup problem
            }
        }

    }
}