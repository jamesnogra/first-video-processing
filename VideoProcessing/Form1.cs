using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;
using ImageProcess2;
using System.Drawing.Imaging;

namespace VideoProcessing
{
    public partial class Form1 : Form
    {
        Device[] allDevices;
        Bitmap source, staticLiveImage, bgImage;
        byte edgeDetectType;
        bool startBroadcast = false;
        int width = 640, height = 480;

        public Form1()
        {
            InitializeComponent();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allDevices = DeviceManager.GetAllDevices();
            allDevices[0].ShowWindow(pictureBox1);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //try searching tagVideoProcAmpProperty
            // this code captures snapshots
            IDataObject data;
            Image bmap;
            //int edgeDetectThreshold;
            allDevices[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            source = new Bitmap(bmap);
            //BitmapFilter.Resize(source, width, height, true);

            if (startBroadcast)
            {
                this.CustomSubtract(source, staticLiveImage, bgImage, (byte)thresholdBar.Value);
            }


            //grayscale the image for easier image processing
            /*BitmapFilter.GrayScale(source);

            if (edgeDetectType != 0)
            {
                edgeDetectThreshold = thresholdBar.Value;
                BitmapFilter.EdgeDetectConvolution(source, edgeDetectType, (byte)edgeDetectThreshold);
            }*/

            pictureBox2.Image = source;
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edgeDetectType = 3;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edgeDetectType = 0;
        }

        private void kirshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edgeDetectType = 1;
        }

        private void prewittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edgeDetectType = 2;
        }

        private void startBroadcastingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startBroadcast = true;
        }

        private void openBackgroundImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browseBGImageDialog.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap newBg = new Bitmap(browseBGImageDialog.FileName);
            bgImage = new Bitmap(width, height);
            //BitmapFilter.Resize(bgImage, 640, 480, true);
            this.CustomResize(ref newBg, ref bgImage, width, height);
            //MessageBox.Show("Resized to " + bgImage.Width + "x" + bgImage.Height);
            backgroundImage.Image = bgImage;
        }

        private void setStaticImageFromLiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            allDevices[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            staticLiveImage = new Bitmap(bmap);
            //BitmapFilter.Resize(staticLiveImage, width, height, false);
            staticImageFromLive.Image = staticLiveImage;
            //MessageBox.Show("Resized to " + staticLiveImage.Width + "x" + staticLiveImage.Height);
        }

        public bool CustomSubtract(Bitmap source, Bitmap staticImg, Bitmap bg, byte threshold)
        {
            // GDI+ still lies to us - the return format is BGR, NOT RGB.
            BitmapData sourceLive = source.LockBits(new Rectangle(0, 0, source.Width, source.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData staticFromLive = staticImg.LockBits(new Rectangle(0, 0, staticImg.Width, staticImg.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bgForLive = bg.LockBits(new Rectangle(0, 0, bg.Width, bg.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            //live video feed
            int strideLiveVideo = sourceLive.Stride;
            System.IntPtr sourceLiveStartPointer = sourceLive.Scan0;

            //static Img
            int strideStaticImage = staticFromLive.Stride;
            System.IntPtr staticImgStartPointer = staticFromLive.Scan0;

            //Background
            int strideBg = bgForLive.Stride;
            System.IntPtr bgStartPointer = bgForLive.Scan0;

            unsafe
            {
                byte* sourceLiveMovingPointer = (byte*)(void*)sourceLiveStartPointer;
                byte* staticImgMovingPointer = (byte*)(void*)staticImgStartPointer;
                byte* bgMovingPointer = (byte*)(void*)bgStartPointer;
                int liveVideoOffset = strideLiveVideo - source.Width * 3;
                int staticImageOffset = strideStaticImage - staticImg.Width * 3;
                int bgOffset = strideBg - bg.Width * 3;
                int nWidth = source.Width * 3;
                Color tempLive, tempStatic;

                for (int y = 0; y < source.Height; ++y)
                {
                    for (int x = 0; x < source.Width; ++x)
                    {
                        
                        tempLive = Color.FromArgb(sourceLiveMovingPointer[2], sourceLiveMovingPointer[1], sourceLiveMovingPointer[0]);
                        tempStatic = Color.FromArgb(staticImgMovingPointer[2], staticImgMovingPointer[1], staticImgMovingPointer[0]);
                        //if (Math.Abs(p[0]-c[0])<threshold && Math.Abs(p[1]-c[1])<threshold && Math.Abs(p[2]-c[2])<threshold)
                        if (Math.Abs(sourceLiveMovingPointer[0] - staticImgMovingPointer[0]) < threshold &&
                            Math.Abs(sourceLiveMovingPointer[1] - staticImgMovingPointer[1]) < threshold &&
                            Math.Abs(sourceLiveMovingPointer[2] - staticImgMovingPointer[2]) < threshold)
                        //if (Math.Abs(tempLive.GetHue()-tempStatic.GetHue())<threshold && Math.Abs(tempLive.GetSaturation()-tempStatic.GetSaturation())<threshold)
                        {
                            sourceLiveMovingPointer[0] = bgMovingPointer[0];
                            sourceLiveMovingPointer[1] = bgMovingPointer[1];
                            sourceLiveMovingPointer[2] = bgMovingPointer[2];
                        }
                        sourceLiveMovingPointer += 3;
                        staticImgMovingPointer += 3;
                        bgMovingPointer += 3;
                    }
                    sourceLiveMovingPointer += staticImageOffset;
                    staticImgMovingPointer += staticImageOffset;
                    bgMovingPointer += bgOffset;
                }
            }
            source.UnlockBits(sourceLive);
            bg.UnlockBits(bgForLive);
            staticImg.UnlockBits(staticFromLive);
            return true;
        }

        public void CustomResize(ref Bitmap source, ref Bitmap result, int width, int height)
        {
            result = new Bitmap(width, height); //initalize the image
            Color pixel;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    pixel = source.GetPixel(x * source.Width / width, y * source.Height / height);
                    result.SetPixel(x, y, pixel);
                }
            }
        }
    }
}
