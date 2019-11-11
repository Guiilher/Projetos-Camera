using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keyence.IV.Sdk;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace KeyenceSensor
{
    public partial class ImagemSensor : UserControl
    {
        private static readonly Size ImageSize = new Size(320, 240);
        private byte activeToolNo;
        private IVisionSensor sensor;

        public ImagemSensor()
        {
            InitializeComponent();
        }

        public void Initialize(IVisionSensor visionSensor)
        {
            CleanUp();
            sensor = visionSensor;
            sensor.ImageAcquired += SensorImageAcquired;
        }

        public void RefreshState()
        {
            var image = new Bitmap(ImageSize.Width, ImageSize.Height, PixelFormat.Format24bppRgb);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(192, 192, 192)),
                                       new Rectangle(Point.Empty, image.Size));
            }
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
            }
            pictureBox.Image = image;
        }

        public void CleanUp()
        {
            if (sensor != null)
            {
                sensor.ImageAcquired -= SensorImageAcquired;
            }
            pictureBox.Image = null;
            activeToolNo = 0;
        }

        public void ChangeActiveTool(byte toolNo)
        {
            activeToolNo = toolNo;
        }

        private void SensorImageAcquired(object sender, ImageAcquiredEventArgs e)
        {
            var image = new Bitmap(ImageSize.Width, ImageSize.Height, PixelFormat.Format24bppRgb);
            BitmapData lockData = image.LockBits(new Rectangle(Point.Empty, ImageSize), ImageLockMode.WriteOnly,
                                                 PixelFormat.Format24bppRgb);
            Marshal.Copy(e.LiveImage.ByteData, 0, lockData.Scan0, e.LiveImage.ByteData.Length);
            image.UnlockBits(lockData);
            DrawToolWindow(image);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                sensor.DrawWindow(graphics, Color.Green, Color.Red, activeToolNo);
            }
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
            }
            pictureBox.Image = image;
        }
        //Mostrar imagem de Configuração
        private void DrawToolWindow(Bitmap image)
        {
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                for (byte i = 0; i <= 16; i++)
                {
                    if (i == activeToolNo) continue;
                    DrawToolWindow(graphics, i);
                }
                DrawToolWindow(graphics, activeToolNo);
            }
        }

        private void DrawToolWindow(Graphics graphics, byte toolNoi)
        {
            var okColor = toolNoi == activeToolNo ? Color.Lime : Color.Green;
            var ngColor = toolNoi == activeToolNo ? Color.Magenta : Color.Red;
            ToolSettingBase toolSetting = sensor.ActiveProgram[toolNoi];
            if (toolSetting.ToolType == "") return;
            sensor.DrawWindow(graphics, okColor, ngColor, toolNoi);
        }
    }
}
