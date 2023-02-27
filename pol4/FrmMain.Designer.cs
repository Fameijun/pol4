namespace pol4
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage4 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage5 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage6 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage7 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage8 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage9 = new CCWin.SkinControl.SkinTabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.skinTabControl1.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.Controls.Add(this.skinTabPage3);
            this.skinTabControl1.Controls.Add(this.skinTabPage4);
            this.skinTabControl1.Controls.Add(this.skinTabPage5);
            this.skinTabControl1.Controls.Add(this.skinTabPage6);
            this.skinTabControl1.Controls.Add(this.skinTabPage7);
            this.skinTabControl1.Controls.Add(this.skinTabPage8);
            this.skinTabControl1.Controls.Add(this.skinTabPage9);
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImageList = this.imageList;
            this.skinTabControl1.ImgSize = new System.Drawing.Size(50, 50);
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ImgTxtSpace = 0;
            this.skinTabControl1.ItemSize = new System.Drawing.Size(120, 80);
            this.skinTabControl1.Location = new System.Drawing.Point(0, 40);
            this.skinTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Top;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.PageTextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.skinTabControl1.SelectedIndex = 2;
            this.skinTabControl1.Size = new System.Drawing.Size(1100, 700);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.White;
            this.skinTabPage1.Controls.Add(this.gMapControl1);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.ImageIndex = 0;
            this.skinTabPage1.Location = new System.Drawing.Point(0, 80);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(1100, 620);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "实时监听";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(750, 580);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.White;
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.ImageIndex = 1;
            this.skinTabPage2.Location = new System.Drawing.Point(0, 80);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(1100, 620);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "污染分布";
            // 
            // skinTabPage3
            // 
            this.skinTabPage3.BackColor = System.Drawing.Color.White;
            this.skinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage3.ImageIndex = 2;
            this.skinTabPage3.Location = new System.Drawing.Point(0, 80);
            this.skinTabPage3.Name = "skinTabPage3";
            this.skinTabPage3.Size = new System.Drawing.Size(1100, 620);
            this.skinTabPage3.TabIndex = 2;
            this.skinTabPage3.TabItemImage = null;
            this.skinTabPage3.Text = "污染溯源";
            // 
            // skinTabPage4
            // 
            this.skinTabPage4.BackColor = System.Drawing.Color.White;
            this.skinTabPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage4.ImageIndex = 3;
            this.skinTabPage4.Location = new System.Drawing.Point(0, 80);
            this.skinTabPage4.Name = "skinTabPage4";
            this.skinTabPage4.Size = new System.Drawing.Size(1100, 620);
            this.skinTabPage4.TabIndex = 3;
            this.skinTabPage4.TabItemImage = null;
            this.skinTabPage4.Text = "污染预测";
            // 
            // skinTabPage5
            // 
            this.skinTabPage5.BackColor = System.Drawing.Color.White;
            this.skinTabPage5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage5.ImageIndex = 4;
            this.skinTabPage5.Location = new System.Drawing.Point(0, 80);
            this.skinTabPage5.Name = "skinTabPage5";
            this.skinTabPage5.Size = new System.Drawing.Size(1100, 620);
            this.skinTabPage5.TabIndex = 4;
            this.skinTabPage5.TabItemImage = null;
            this.skinTabPage5.Text = "数据查询";
            // 
            // skinTabPage6
            // 
            this.skinTabPage6.BackColor = System.Drawing.Color.White;
            this.skinTabPage6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage6.ImageIndex = 5;
            this.skinTabPage6.Location = new System.Drawing.Point(0, 80);
            this.skinTabPage6.Name = "skinTabPage6";
            this.skinTabPage6.Size = new System.Drawing.Size(1100, 620);
            this.skinTabPage6.TabIndex = 5;
            this.skinTabPage6.TabItemImage = null;
            this.skinTabPage6.Text = "系统设置";
            // 
            // skinTabPage7
            // 
            this.skinTabPage7.BackColor = System.Drawing.Color.White;
            this.skinTabPage7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage7.ImageIndex = 6;
            this.skinTabPage7.Location = new System.Drawing.Point(0, 80);
            this.skinTabPage7.Name = "skinTabPage7";
            this.skinTabPage7.Size = new System.Drawing.Size(1100, 620);
            this.skinTabPage7.TabIndex = 6;
            this.skinTabPage7.TabItemImage = null;
            this.skinTabPage7.Text = "时间切片";
            // 
            // skinTabPage8
            // 
            this.skinTabPage8.BackColor = System.Drawing.Color.White;
            this.skinTabPage8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage8.ImageIndex = 7;
            this.skinTabPage8.Location = new System.Drawing.Point(0, 80);
            this.skinTabPage8.Name = "skinTabPage8";
            this.skinTabPage8.Size = new System.Drawing.Size(1100, 620);
            this.skinTabPage8.TabIndex = 7;
            this.skinTabPage8.TabItemImage = null;
            this.skinTabPage8.Text = "城市应用";
            // 
            // skinTabPage9
            // 
            this.skinTabPage9.BackColor = System.Drawing.Color.White;
            this.skinTabPage9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage9.ImageIndex = 8;
            this.skinTabPage9.Location = new System.Drawing.Point(0, 80);
            this.skinTabPage9.Name = "skinTabPage9";
            this.skinTabPage9.Size = new System.Drawing.Size(1100, 620);
            this.skinTabPage9.TabIndex = 8;
            this.skinTabPage9.TabItemImage = null;
            this.skinTabPage9.Text = "亚运托管";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "shishijianting.png");
            this.imageList.Images.SetKeyName(1, "wuranfenbu.png");
            this.imageList.Images.SetKeyName(2, "wuransuyuan.png");
            this.imageList.Images.SetKeyName(3, "wuranyuce.png");
            this.imageList.Images.SetKeyName(4, "shujuchaxun.png");
            this.imageList.Images.SetKeyName(5, "xitongshezhi.png");
            this.imageList.Images.SetKeyName(6, "shijianqiepian.png");
            this.imageList.Images.SetKeyName(7, "chengshiyingyong.png");
            this.imageList.Images.SetKeyName(8, "yayuntuoguan.png");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.CloseBoxSize = new System.Drawing.Size(32, 27);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.skinTabControl1);
            this.EffectBack = System.Drawing.Color.Black;
            this.EffectWidth = 0;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaxDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxDownBack")));
            this.MaxMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxMouseBack")));
            this.MaxNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxNormlBack")));
            this.MaxSize = new System.Drawing.Size(32, 27);
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(32, 27);
            this.Name = "FrmMain";
            this.RestoreDownBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreDownBack")));
            this.RestoreMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreMouseBack")));
            this.RestoreNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreNormlBack")));
            this.Text = "城市大气污染精准监测网络与综合诊断分析系统  4.0.1";
            this.skinTabControl1.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private CCWin.SkinControl.SkinTabPage skinTabPage3;
        private CCWin.SkinControl.SkinTabPage skinTabPage4;
        private CCWin.SkinControl.SkinTabPage skinTabPage5;
        private CCWin.SkinControl.SkinTabPage skinTabPage6;
        private CCWin.SkinControl.SkinTabPage skinTabPage7;
        private CCWin.SkinControl.SkinTabPage skinTabPage8;
        private CCWin.SkinControl.SkinTabPage skinTabPage9;
        private System.Windows.Forms.ImageList imageList;
    }
}

