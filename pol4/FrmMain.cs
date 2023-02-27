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
using System.Data.SqlClient;
using CCWin.SkinClass;

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


            // 连接字符串
            //string connectionString = "Data Source=(local);Initial Catalog=Pol;Integrated Security=True";
            string connectionString = "Server=127.0.0.1,1433;Database=Pol;User Id=sa;Password=2047806;";

            // 查询语句
            string query = "SELECT * FROM bj_data WHERE date='2017-01-01 00:00'";

            // 创建连接对象和命令对象
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // 打开连接
                connection.Open();

                // 执行查询并获取结果
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", reader.GetDateTime(0), reader.GetDouble(1), reader.GetDouble(2));
                    }
                }

            }
        }
    }
}
