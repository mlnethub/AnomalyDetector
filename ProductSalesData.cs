using AnomalyDetector.Utilities.Interfaces;
using Microsoft.ML.Data;

namespace AnomalyDetector.CLI
{
    public class ProductSalesData
    {
        [LoadColumn(0)]
        public string Month;
        [LoadColumn(1)]
        public float numSales;
    }

    public class ProductSalesPrediction : IAnomalyDetectionOutput
    {
        [VectorType(3)]
        public double[] Prediction { get; set; }
    }
}