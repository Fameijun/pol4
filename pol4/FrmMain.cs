using CCWin;
using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pol4
{
    public partial class FrmMain : CCSkinMain
    {
        public FrmMain()
        {
            InitializeComponent();

            // 初始化 GMapControl1
            gMapControl1.MapProvider = GMapProvidersExt.AMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            GMapProvider.Language = LanguageType.ChineseSimplified;

            gMapControl1.Position = new PointLatLng(30.242277, 120.1);//设置地图的当前中心位置  (30.242277, 120.1)
            gMapControl1.MaxZoom = 24;//最大的缩放比例  
            gMapControl1.MinZoom = 3;//最小的缩放比例 
            gMapControl1.Zoom = 12;//当前的缩放比例 
            gMapControl1.ShowCenter = false;
            gMapControl1.DragButton = MouseButtons.Left;//左键拖动地图
            //this.gMapControl1.Overlays.Add(overlay_Wind_1);//将图层添加到地图
            GMapProvider.TimeoutMs = 1000;//设置超时时间
        }
    }
}
