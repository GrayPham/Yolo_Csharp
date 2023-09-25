
namespace Yolo_Cshape
{
    partial class DetectVehicle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBoxImage = new System.Windows.Forms.PictureBox();
            this.pBoxResult = new System.Windows.Forms.PictureBox();
            this.btnDetect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxImage
            // 
            this.pBoxImage.Image = global::Yolo_Cshape.Properties.Resources.CarLongPlate497_jpg_rf_49601ac616403a6087ac15b5a7020911;
            this.pBoxImage.Location = new System.Drawing.Point(27, 12);
            this.pBoxImage.Name = "pBoxImage";
            this.pBoxImage.Size = new System.Drawing.Size(507, 528);
            this.pBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxImage.TabIndex = 0;
            this.pBoxImage.TabStop = false;
            // 
            // pBoxResult
            // 
            this.pBoxResult.Image = global::Yolo_Cshape.Properties.Resources.CarLongPlate497_jpg_rf_49601ac616403a6087ac15b5a7020911;
            this.pBoxResult.Location = new System.Drawing.Point(649, 12);
            this.pBoxResult.Name = "pBoxResult";
            this.pBoxResult.Size = new System.Drawing.Size(507, 528);
            this.pBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxResult.TabIndex = 1;
            this.pBoxResult.TabStop = false;
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(540, 265);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(103, 41);
            this.btnDetect.TabIndex = 2;
            this.btnDetect.Text = "Detect";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // DetectVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 548);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.pBoxResult);
            this.Controls.Add(this.pBoxImage);
            this.Name = "DetectVehicle";
            this.Text = "Detect Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxImage;
        private System.Windows.Forms.PictureBox pBoxResult;
        private System.Windows.Forms.Button btnDetect;
    }
}

