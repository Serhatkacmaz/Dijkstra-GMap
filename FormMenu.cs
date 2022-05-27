using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap_Tutorial.Helpers;
using GMap_Tutorial.Settings;
using GMap_Tutorial.Transactions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GMap_Tutorial
{
    public partial class FormMenu : Form
    {
        //-> Variables
        int _indexCount = default(int);
        private double _shortest = default(double);
        private string[,] _totalArray = new string[100, 100];
        private double[,] _totalKmArray = new double[100, 100];
        private string[,] _globalArray = new string[100, 100];

        //-> Constructor
        public FormMenu()
        {
            InitializeComponent();
            LoadMap();
        }

        //-> Methods
        private void LoadMap()
        {
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.SetPositionByKeywords("Türkiye, izmit");
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 12;
        }

        private void UpdateMap()
        {
            GMapProviders.GoogleMap.ApiKey = ServiceSettings.ApiKey;
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;

            double lat = Convert.ToDouble(txtLat.Text);
            double lng = Convert.ToDouble(txtLng.Text);
            map.Position = new PointLatLng(lat, lng);

            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = Informations.GlobalPoints.Count == 1 ? new GMarkerGoogle(point, GMarkerGoogleType.blue_pushpin) : new GMarkerGoogle(point, GMarkerGoogleType.orange_dot);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

            map.MaxZoom = 100;
            map.MinZoom = 1;
            map.Zoom = 10;
        }

        #region Dijkstra
        private void CalcCoordinates()
        {
            _indexCount = Informations.GlobalPoints.Count();

            Informations.NumberOfElement = Informations.GlobalPoints.Count - 1;
            int[] lst = new int[Informations.NumberOfElement];

            for (int i = 0; i < Informations.NumberOfElement; i++)
            {
                lst[i] = i + 1;
            }

            ShortestAlgorithmByDijsktra(lst, 200);

            for (int i = 0; i < Informations.NumberOfElement; i++)
            {
                int[] tempList = new int[lst.Length];
                for (int j = 0; j < Informations.NumberOfElement; j++)
                {
                    tempList[j] = Convert.ToInt32(_globalArray[i, j]);

                }
                ShortestAlgorithmByDijsktra(tempList, i);
            }

            for (int i = Informations.NumberOfElement; i < (Informations.NumberOfElement * Informations.NumberOfElement); i++)
            {
                int[] tempList = new int[Informations.NumberOfElement];
                for (int j = 0; j < Informations.NumberOfElement; j++)
                {
                    tempList[j] = Convert.ToInt32(_globalArray[i, j]);

                }
                ShortestAlgorithmByDijsktra(tempList, i);
            }

            for (int i = 0; i < Informations.Count; i++)
            {
                int[] tempList = new int[Informations.NumberOfElement];
                for (int j = 0; j < Informations.NumberOfElement; j++)
                {
                    tempList[j] = Convert.ToInt32(_globalArray[i, j]);
                }
                tempList = AddFunction(tempList, 0);
                for (int a = 0; a < tempList.Length; a++)
                {
                    Informations.TotalArray[i, a] = tempList[a].ToString();
                }
            }

            Results();
        }
        private void PopFunction(int[] list, int[] valueList)
        {
            for (int j = 0; j < list.Length; j++)
            {
                int temp = list[list.Length - 1];
                for (int i = list.Length - 1; i > 0; i--)
                {
                    list[i] = list[i - 1];

                }
                list[0] = temp;
                for (int i = valueList.Length - 1; i >= 0; i--)
                {
                    list = AddFunction(list, valueList[i]);
                }
                for (int i = 0; i < list.Length; i++)
                {
                    _globalArray[Informations.Count, i] = list[i].ToString();
                }
                Informations.Count += 1;
                for (int i = 0; i < valueList.Length; i++)
                {
                    list = PopElement(list);
                }
            }
        }

        private void PopFunctionForZero(int[] list)
        {
            for (int j = 0; j < list.Length; j++)
            {
                int temp = list[list.Length - 1];
                for (int i = list.Length - 1; i > 0; i--)
                {
                    list[i] = list[i - 1];

                }
                list[0] = temp;
                for (int i = 0; i < list.Length; i++)
                {
                    _globalArray[j, i] = list[i].ToString();

                }
                Informations.Count += 1;
            }
        }

        private int[] AddFunction(int[] list, int value)
        {
            int[] tempList = new int[list.Length + 1];
            int x = 1;

            for (int i = 0; i < list.Length + 1; i++)
            {
                if (i < x - 1)
                    tempList[i] = list[i];
                else if (i == x - 1)
                    tempList[i] = value;
                else
                    tempList[i] = list[i - 1];
            }

            return tempList;
        }

        private int[] PopElement(int[] tempList)
        {
            tempList = tempList.Where((source, index) => index != 0).ToArray();
            return tempList;
        }

        private void ShortestAlgorithmByDijsktra(int[] list, int id)
        {
            if (id != 200)
            {
                if (id < list.Length)
                {
                    int[] valueList = new int[1];
                    for (int i = 0; i < valueList.Length; i++)
                    {
                        valueList[i] = list[i];
                    }
                    for (int i = 0; i < valueList.Length; i++)
                    {
                        list = PopElement(list);
                    }
                    PopFunction(list, valueList);
                }
                else if (list.Length <= id && id < (list.Length * list.Length))
                {
                    int[] valueList = new int[2];
                    for (int i = 0; i < valueList.Length; i++)
                    {
                        valueList[i] = list[i];
                    }
                    for (int i = 0; i < valueList.Length; i++)
                    {
                        list = PopElement(list);
                    }
                    PopFunction(list, valueList);
                }

            }
            else if (id == 200)
            {
                PopFunctionForZero(list);
            }
        }

        private void Results()
        {
            _totalArray = Informations.TotalArray;
            for (int i = 0; i < Informations.Count; i++)
            {
                double km = 0;
                for (int j = 0; j < Informations.NumberOfElement + 1; j++)
                {
                    km = km + DistanceBetweenTwoPoints(Informations.GlobalPoints[Convert.ToInt32(_totalArray[i, j])], Informations.GlobalPoints[Convert.ToInt32(_totalArray[i, j + 1])]);
                }
                _totalKmArray[i, 0] = km;
                _totalKmArray[i, 1] = i;
            }
            double shortest = _totalKmArray[0, 0];
            for (int i = 1; i < Informations.Count; i++)
            {
                if (_totalKmArray[i, 0] < shortest)
                {
                    shortest = _totalKmArray[i, 0];
                    Informations.Index = Convert.ToInt32(_totalKmArray[i, 1]);
                }
            }

            var path = string.Empty;
            for (int i = 0; i < Informations.NumberOfElement + 1; i++)
            {
                if (_totalArray[Informations.Index, i] != null)
                {
                    path += _totalArray[Informations.Index, i].ToString();
                    path += " -> ";
                }

            }
            if (Informations.GlobalPoints.Count > 2)
            {
                path += "0";
            }
            else
            {
                path = path.Trim().Trim('>').Trim('-');
            }

            lblRoute.Text = string.IsNullOrEmpty(path) ? "-" : path;
            _shortest = shortest;
        }

        private int DistanceBetweenTwoPoints(PointLatLng startPoint, PointLatLng endPoint)
        {
            var route = GoogleMapProvider.Instance.GetRoute(startPoint, endPoint, false, false, 14);
            var r = new GMapRoute(route.Points, "My Route");
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);

            return Convert.ToInt32(route.Distance);
        }
        #endregion

        private void DrawMap()
        {
            GMapProviders.GoogleMap.ApiKey = ServiceSettings.ApiKey;
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.MaxZoom = 100;
            map.MinZoom = 1;
            map.Zoom = 10;

            for (int i = 0; i < Informations.GlobalPoints.Count; i++)
            {
                double lat = Convert.ToDouble(Informations.GlobalPoints[Convert.ToInt32(Informations.TotalArray[Informations.Index, i])].Lat);
                double lng = Convert.ToDouble(Informations.GlobalPoints[Convert.ToInt32(Informations.TotalArray[Informations.Index, i])].Lng);
                map.Position = new PointLatLng(lat, lng);
                PointLatLng point = new PointLatLng(lat, lng);
                GMapMarker marker = i == 0 ? new GMarkerGoogle(point, GMarkerGoogleType.blue_pushpin) : new GMarkerGoogle(point, GMarkerGoogleType.orange_dot);
                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);
                if (i + 1 < Informations.GlobalPoints.Count)
                {
                    Console.WriteLine(Convert.ToInt32(Informations.TotalArray[Informations.Index, i]).ToString() + Convert.ToInt32(Informations.TotalArray[Informations.Index, i + 1]).ToString());
                    var route = GoogleMapProvider.Instance.GetRoute(Informations.GlobalPoints[Convert.ToInt32(Informations.TotalArray[Informations.Index, i])], Informations.GlobalPoints[Convert.ToInt32(Informations.TotalArray[Informations.Index, i + 1])], false, false, 14);
                    var r = new GMapRoute(route.Points, "My Route")
                    {
                        Stroke = new Pen(Color.Red, 5)
                    };
                    var routes = new GMapOverlay("routes");
                    routes.Routes.Add(r);
                    map.Overlays.Add(routes);
                }

                Thread.Sleep(2000);
            }

            if (Informations.GlobalPoints.Count >= 2)
            {
                //end -> start
                var endNode = Informations.TotalArray[Informations.Index, Informations.NumberOfElement];
                var route2 = GoogleMapProvider.Instance.GetRoute(Informations.GlobalPoints[int.Parse(endNode)], Informations.GlobalPoints[0], false, false, 14);
                var r2 = new GMapRoute(route2.Points, "My Route")
                {
                    Stroke = new Pen(Color.Green, 3)
                };

                var km = DistanceBetweenTwoPoints(Informations.GlobalPoints[int.Parse(endNode)], Informations.GlobalPoints[0]);

                var routes2 = new GMapOverlay("routes");
                routes2.Routes.Add(r2);
                map.Overlays.Add(routes2);

                lblTotalPath.Text = (_shortest + km) + "km";
            }
            else
            {
                lblTotalPath.Text = _shortest + "km";
            }

            if (Informations.GlobalPoints.Count == 2)
            {
                lblRoute.Text += " -> 0";
            }
        }

        //-> Events
        private void btnClearMap_Click(object sender, EventArgs e)
        {
            map.Overlays.Clear();
            lblRoute.Text = "-";
            lblTotalPath.Text = "-";
            Informations.GlobalPoints = new List<PointLatLng>();
            LoadMap();
        }

        private void btnPointAdd_Click(object sender, EventArgs e)
        {
            if (!FormControlHelpers.IsNullOrEmptyInputs(panelInputs))
            {
                Informations.GlobalPoints.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text)));
                UpdateMap();
                FormControlHelpers.ClearInputs(panelInputs);
            }
            else
            {
                MessageBox.Show("Konum Bilgisi Girilmedi...", "App", MessageBoxButtons.OK);
            }

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Informations.GlobalPoints.Count > 0)
            {
                //2 satır silinebilir
                map.Overlays.Clear();
                LoadMap();

                lblRoute.Text = "-";
                lblTotalPath.Text = "-";

                Informations.Count = 0;
                Informations.Index = 0;
                Informations.NumberOfElement = 0;
                Array.Clear(Informations.TotalArray, 0, Informations.TotalArray.Length);
                Array.Clear(_totalArray, 0, _totalArray.Length);
                Array.Clear(_totalKmArray, 0, _totalKmArray.Length);
                Array.Clear(_globalArray, 0, _globalArray.Length);

                CalcCoordinates();
                DrawMap();
            }
        }

        private void txtLat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
