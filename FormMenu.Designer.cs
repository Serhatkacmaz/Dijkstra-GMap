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
            this.label3 = new System.Windows.Forms.Label();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.panelInputs.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitterMap.Size = new System.Drawing.Size(1255, 587);
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
            this.map.Size = new System.Drawing.Size(1231, 571);
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
            this.txtLat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLat_KeyPress);
            // 
            // txtLng
            // 
            this.txtLng.Font = new System.Drawing.Font("Lucida Fax", 15.75F);
            this.txtLng.Location = new System.Drawing.Point(136, 69);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(263, 32);
            this.txtLng.TabIndex = 7;
            this.txtLng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLng_KeyPress);
            // 
            // btnPointAdd
            // 
            this.btnPointAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPointAdd.Font = new System.Drawing.Font("Lucida Fax", 15.75F);
            this.btnPointAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPointAdd.Location = new System.Drawing.Point(136, 128);
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
            this.btnStart.Location = new System.Drawing.Point(15, 133);
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
            this.btnClearMap.Location = new System.Drawing.Point(520, 133);
            this.btnClearMap.Name = "btnClearMap";
            this.btnClearMap.Size = new System.Drawing.Size(263, 40);
            this.btnClearMap.TabIndex = 10;
            this.btnClearMap.Text = "Temizle";
            this.btnClearMap.UseVisualStyleBackColor = false;
            this.btnClearMap.Click += new System.EventHandler(this.btnClearMap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Toplam Yol => ";
            // 
            // panelInputs
            // 
            this.panelInputs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelInputs.Controls.Add(this.txtLat);
            this.panelInputs.Controls.Add(this.label1);
            this.panelInputs.Controls.Add(this.label2);
            this.panelInputs.Controls.Add(this.txtLng);
            this.panelInputs.Controls.Add(this.btnPointAdd);
            this.panelInputs.Location = new System.Drawing.Point(7, 11);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(419, 189);
            this.panelInputs.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.50199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.49801F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelInputs, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 603);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1255, 211);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRoute);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTotalPath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnClearMap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(450, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 205);
            this.panel1.TabIndex = 15;
            // 
            // lblTotalPath
            // 
            this.lblTotalPath.AutoSize = true;
            this.lblTotalPath.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPath.Location = new System.Drawing.Point(199, 85);
            this.lblTotalPath.Name = "lblTotalPath";
            this.lblTotalPath.Size = new System.Drawing.Size(17, 24);
            this.lblTotalPath.TabIndex = 13;
            this.lblTotalPath.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rota =>";
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoute.Location = new System.Drawing.Point(121, 33);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(17, 24);
            this.lblRoute.TabIndex = 15;
            this.lblRoute.Text = "-";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1255, 814);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitterMap);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPath;
    }
}