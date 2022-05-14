﻿using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap_Tutorial.Helpers;
using GMap_Tutorial.Models;
using GMap_Tutorial.Settings;
using GMap_Tutorial.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMap_Tutorial
{
    public partial class FormMenu : Form
    {
        //-> Variables
        int indexCount = 0;
        private string[,] totalArray = new string[100, 100];
        private double[,] totalKmArray = new double[100, 100];
        private string[,] globalArray = new string[100, 100];
        List<ModelCoordinate> _coordinateList = new List<ModelCoordinate>();

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
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

            map.MaxZoom = 100;
            map.MinZoom = 1;
            map.Zoom = 10;
        }

        private void CalcCoordinates()
        {
            if (_coordinateList.Count != 0)
            {
                _coordinateList.ToList().ForEach(coordinate =>
                {
                    string lat = (coordinate != null) ? coordinate.Lat : "0";
                    string lng = (coordinate != null) ? coordinate.Lng : "0";

                    Informations.CoordinatesList.Add(lat);
                    Informations.CoordinatesList.Add(lng);
                });

                for (int i = 0; i < Informations.CoordinatesList.Count; i = i + 2)
                {
                    if (Informations.CoordinatesList[i] != null)
                    {
                        Informations.GlobalPoints.Add(new PointLatLng(Convert.ToDouble(Informations.CoordinatesList[i]), Convert.ToDouble(Informations.CoordinatesList[i + 1])));
                    }
                }

                indexCount = Informations.GlobalPoints.Count();
                //kısayol algoritması
                Informations.NumberOfElement = Informations.GlobalPoints.Count - 1;
                int[] arr = new int[Informations.NumberOfElement];

                for (int i = 0; i < Informations.NumberOfElement; i++)
                {
                    arr[i] = i + 1;
                }

                Dijikstra(arr, 200);
                //elemanları belirleme
                for (int i = 0; i < Informations.NumberOfElement; i++)
                {
                    int[] tempArray = new int[arr.Length];
                    for (int j = 0; j < Informations.NumberOfElement; j++)
                    {
                        tempArray[j] = Convert.ToInt32(globalArray[i, j]);

                    }
                    Dijikstra(tempArray, i);
                }
                //en kısa yolu bulma
                for (int i = Informations.NumberOfElement; i < (Informations.NumberOfElement * Informations.NumberOfElement); i++)
                {
                    int[] tempArray = new int[Informations.NumberOfElement];
                    for (int j = 0; j < Informations.NumberOfElement; j++)
                    {
                        tempArray[j] = Convert.ToInt32(globalArray[i, j]);

                    }
                    Dijikstra(tempArray, i);
                }
                //hepsiin başına sıfır ekleme
                for (int i = 0; i < Informations.Count; i++)
                {
                    int[] tempArray = new int[Informations.NumberOfElement];
                    for (int j = 0; j < Informations.NumberOfElement; j++)
                    {
                        tempArray[j] = Convert.ToInt32(globalArray[i, j]);
                    }
                    tempArray = InsertFunction(tempArray, 0);
                    for (int a = 0; a < tempArray.Length; a++)
                    {
                        Informations.TotalArray[i, a] = tempArray[a].ToString();
                    }
                }

                Resulst();
            }
        }
        private void DeplacementFunction(int[] array, int[] valueArray)
        {
            for (int j = 0; j < array.Length; j++)
            {
                int temp = array[array.Length - 1];
                for (int i = array.Length - 1; i > 0; i--)
                {
                    array[i] = array[i - 1];

                }
                array[0] = temp;
                for (int i = valueArray.Length - 1; i >= 0; i--)
                {
                    array = InsertFunction(array, valueArray[i]);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    globalArray[Informations.Count, i] = array[i].ToString();
                }
                Informations.Count += 1;
                for (int i = 0; i < valueArray.Length; i++)
                {
                    array = RemoveElement(array);
                }
            }
        }

        private void DeplacementFunctionForZero(int[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                int temp = array[array.Length - 1];
                for (int i = array.Length - 1; i > 0; i--)
                {
                    array[i] = array[i - 1];

                }
                array[0] = temp;
                for (int i = 0; i < array.Length; i++)
                {
                    globalArray[j, i] = array[i].ToString();

                }
                Informations.Count += 1;
            }
        }

        private int[] InsertFunction(int[] array, int value)
        {
            int[] tempArray = new int[array.Length + 1];
            int pos = 1;

            for (int i = 0; i < array.Length + 1; i++)
            {
                if (i < pos - 1)
                    tempArray[i] = array[i];
                else if (i == pos - 1)
                    tempArray[i] = value;
                else
                    tempArray[i] = array[i - 1];
            }

            return tempArray;
        }

        private int[] RemoveElement(int[] tempArray)
        {
            tempArray = tempArray.Where((source, index) => index != 0).ToArray();
            return tempArray;
        }

        private void Dijikstra(int[] array, int index)
        {
            if (index != 200)
            {
                if (index < array.Length)
                {
                    int[] valueArray = new int[1];
                    for (int i = 0; i < valueArray.Length; i++)
                    {
                        valueArray[i] = array[i];
                    }
                    for (int i = 0; i < valueArray.Length; i++)
                    {
                        array = RemoveElement(array);
                    }
                    DeplacementFunction(array, valueArray);
                }
                else if (array.Length <= index && index < (array.Length * array.Length))
                {
                    int[] valueArray = new int[2];
                    for (int i = 0; i < valueArray.Length; i++)
                    {
                        valueArray[i] = array[i];
                    }
                    for (int i = 0; i < valueArray.Length; i++)
                    {
                        array = RemoveElement(array);
                    }
                    DeplacementFunction(array, valueArray);
                }

            }
            else if (index == 200)
            {
                DeplacementFunctionForZero(array);
            }
        }

        private void Resulst()
        {
            totalArray = Informations.TotalArray;
            for (int i = 0; i < Informations.Count; i++)
            {
                double km = 0;
                for (int j = 0; j < Informations.NumberOfElement + 1; j++)
                {
                    km = km + CalcDistance(Informations.GlobalPoints[Convert.ToInt32(totalArray[i, j])], Informations.GlobalPoints[Convert.ToInt32(totalArray[i, j + 1])]);
                }
                totalKmArray[i, 0] = km;
                totalKmArray[i, 1] = i;
            }
            double shortest = totalKmArray[0, 0];
            for (int i = 1; i < Informations.Count; i++)
            {
                if (totalKmArray[i, 0] < shortest)
                {
                    shortest = totalKmArray[i, 0];
                    Informations.Index = Convert.ToInt32(totalKmArray[i, 1]);
                }
            }
            for (int i = 0; i < Informations.NumberOfElement + 1; i++)
            {
                Console.WriteLine(totalArray[Informations.Index, i]);
            }

            textState.Text = "Toplam yol =>" + " " + shortest + "km";

        }

        private int CalcDistance(PointLatLng point1, PointLatLng point2)
        {

            var route = GoogleMapProvider.Instance.GetRoute(point1, point2, false, false, 14);
            var r = new GMapRoute(route.Points, "My Route");
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);

            return Convert.ToInt32(route.Distance);
        }

        //-> Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPointAdd_Click(object sender, EventArgs e)
        {
            UpdateMap();
            _coordinateList.Add(new ModelCoordinate { Lat = txtLat.Text, Lng = txtLng.Text });
            FormControlHelpers.ClearInputs(panelInputs);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Informations.CoordinatesList.Clear();
            Informations.Count = 0;
            Informations.GlobalPoints.Clear();
            Informations.Index = 0;
            Informations.NumberOfElement = 0;
            Array.Clear(Informations.TotalArray, 0, Informations.TotalArray.Length);
            Array.Clear(totalArray, 0, totalArray.Length);
            Array.Clear(totalKmArray, 0, totalKmArray.Length);
            Array.Clear(globalArray, 0, globalArray.Length);

            CalcCoordinates();
            RouteMap();
        }

        private void RouteMap()
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
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                //to create a overly
                GMapOverlay markers = new GMapOverlay("markers");
                //to add all markers to the overly
                markers.Markers.Add(marker);
                //to show on google maps
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

            }
        }

    }
}