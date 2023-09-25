using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yolov5Net.Scorer;
using Yolov5Net.Scorer.Models;

namespace Yolo_Cshape
{
    public partial class DetectVehicle : Form
    {
        private YoloScorer<YoloCocoP5Model> scorer = new YoloScorer<YoloCocoP5Model>("Assets/Weights/yolovehicle.onnx");
        public DetectVehicle()
        {
            InitializeComponent();
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            Image image =pBoxImage.Image;
            List<YoloPrediction> predictions = scorer.Predict(image);
            using var graphics = Graphics.FromImage(image);

            foreach (var prediction in predictions) // iterate predictions to draw results
            {
                double score = Math.Round(prediction.Score, 2);

                graphics.DrawRectangles(new Pen(prediction.Label.Color, 3),
                    new[] { prediction.Rectangle });
                if(prediction.Label.Name != "number")
                {
                    var (x, y) = (prediction.Rectangle.X - 3, prediction.Rectangle.Y - 23);

                    graphics.DrawString($"{prediction.Label.Name} ({score})",
                        new Font("Consolas", 16, GraphicsUnit.Pixel), new SolidBrush(prediction.Label.Color),
                        new PointF(x, y));
                }

            }

            pBoxResult.Image = image;
        }
    }
}
