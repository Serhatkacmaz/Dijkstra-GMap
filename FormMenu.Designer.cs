namespace GMap_Tutorial
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.splitterMap = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.btnPointAdd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClearMap = new System.Windows.Forms.Button();
            this.textState = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.panelInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Silver;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1255, 10);
            this.panelTop.TabIndex = 0;
            // 
            // splitterMap
            // 
            this.splitterMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterMap.Location = new System.Drawing.Point(0, 10);
            this.splitterMap.Name = "splitterMap";
            this.splitterMap.Size = new System.Drawing.Size(1255, 400);
            this.splitterMap.TabIndex = 2;
            this.splitterMap.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(12, 18);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1231, 382);
            this.map.TabIndex = 3;
            this.map.Zoom = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enlem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Boylam";
            // 
            // txtLat
            // 
            this.txtLat.Font = new System.Drawing.Font("Lucida Fax", 15.75F);
            this.txtLat.Location = new System.Drawing.Point(136, 25);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(263, 32);
            this.txtLat.TabIndex = 6;
            // 
            // txtLng
            // 
            this.txtLng.Font = new System.Drawing.Font("Lucida Fax", 15.75F);
            this.txtLng.Location = new System.Drawing.Point(136, 69);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(263, 32);
            this.txtLng.TabIndex = 7;
            // 
            // btnPointAdd
            // 
            this.btnPointAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPointAdd.Font = new System.Drawing.Font("Lucida Fax", 15.75F);
            this.btnPointAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPointAdd.Location = new System.Drawing.Point(136, 140);
            this.btnPointAdd.Name = "btnPointAdd";
            this.btnPointAdd.Size = new System.Drawing.Size(263, 40);
            this.btnPointAdd.TabIndex = 8;
            this.btnPointAdd.Text = "Konum Ekle";
            this.btnPointAdd.UseVisualStyleBackColor = false;
            this.btnPointAdd.Click += new System.EventHandler(this.btnPointAdd_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Gainsboro;
            this.btnStart.Font = new System.Drawing.Font("Lucida Fax", 15.75F);
            this.btnStart.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnStart.Location = new System.Drawing.Point(547, 573);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(350, 40);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Yolu Bul";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClearMap
            // 
            this.btnClearMap.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClearMap.Font = new System.Drawing.Font("Lucida Fax", 15.75F);
            this.btnClearMap.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearMap.Location = new System.Drawing.Point(964, 573);
            this.btnClearMap.Name = "btnClearMap";
            this.btnClearMap.Size = new System.Drawing.Size(263, 40);
            this.btnClearMap.TabIndex = 10;
            this.btnClearMap.Text = "Temizle";
            this.btnClearMap.UseVisualStyleBackColor = false;
            this.btnClearMap.Click += new System.EventHandler(this.btnClearMap_Click);
            // 
            // textState
            // 
            this.textState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textState.Enabled = false;
            this.textState.Font = new System.Drawing.Font("Lucida Fax", 15.75F);
            this.textState.Location = new System.Drawing.Point(547, 458);
            this.textState.Name = "textState";
            this.textState.ReadOnly = true;
            this.textState.Size = new System.Drawing.Size(680, 96);
            this.textState.TabIndex = 11;
            this.textState.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Durum";
            // 
            // panelInputs
            // 
            this.panelInputs.Controls.Add(this.txtLat);
            this.panelInputs.Controls.Add(this.label1);
            this.panelInputs.Controls.Add(this.label2);
            this.panelInputs.Controls.Add(this.txtLng);
            this.panelInputs.Controls.Add(this.btnPointAdd);
            this.panelInputs.Location = new System.Drawing.Point(12, 433);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(472, 187);
            this.panelInputs.TabIndex = 13;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1255, 625);
            this.Controls.Add(this.panelInputs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.btnClearMap);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitterMap);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Splitter splitterMap;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.Button btnPointAdd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClearMap;
        private System.Windows.Forms.RichTextBox textState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelInputs;
    }
}