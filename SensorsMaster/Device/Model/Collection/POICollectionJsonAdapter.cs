using SensorsMaster.AppSettings;
using SensorsMaster.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Device.Model.Collection
{
    public class POICollectionJsonAdapter : IJsonAdapter<POICollection>
    {
        public POICollectionJsonAdapter() 
        {
            POIs = new List<POIJsonAdapter>();
        }
        public POICollectionJsonAdapter(POICollection poiCollection)
        {
            this.width = poiCollection.Settings.SizeSettings.Width;
            this.height = poiCollection.Settings.SizeSettings.Height;
            POIs = new List<POIJsonAdapter>();
            foreach (var poi in poiCollection)
                this.POIs.Add(new POIJsonAdapter(poi));
        }

        public double width { get; set; }
        public double height { get; set; }
        public List<POIJsonAdapter> POIs { get; set; }

        public POICollection Convert()
        {
            var sizeSettings = Settings.GetInstance().SizeSettings;
            sizeSettings.Width = width;
            sizeSettings.Height = height;
            sizeSettings.Scale = 600 / Math.Min(width, height);
            var collection = new POICollection();
            foreach(var poiAdapter in POIs)
            {
                collection.Add(poiAdapter.Convert());
            }
            return collection;
        }
    }

    public class POIJsonAdapter : IJsonAdapter<POI>
    {
        public POIJsonAdapter()
        {

        }
        public POIJsonAdapter(POI poi)
        {
            this.x = poi.Point.X;
            this.y = poi.Point.Y;
        }
        public double x { get; set; }
        public double y { get; set; }

        public POI Convert()
        {
            return new POI(x,y);
        }
    }
}
