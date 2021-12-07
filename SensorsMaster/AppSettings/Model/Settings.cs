using SensorsMaster.AppSettings.Model;
using SensorsMaster.Common;
using Newtonsoft.Json;
using System;
using SensorsMaster.Common.Interfaces;
using SensorsMaster.Device.Model;
using SensorsMaster.Device.Model.Collection;

namespace SensorsMaster.AppSettings
{
    public class Settings : ViewModelBase
    {
        #region Singleton
        private static Settings _instance;
        private static readonly object _lock = new object();
        public static Settings GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Settings();
                    }
                }
            }
            return _instance;
        }
        #endregion

        private Settings()
        {
            sensorSettings = SensorSettings.GetInstance();
            sizeSettings = new SizeSettings();
            poiCollection = new POICollection();
            sensorCollection = new SensorCollection();
        }

        private SensorSettings sensorSettings;
        private SizeSettings sizeSettings;
        private POICollection poiCollection;
        private SensorCollection sensorCollection;

        public SensorSettings SensorSettings
        {
            get { return sensorSettings; }
            set
            {
                sensorSettings = value;
                OnPropertyChanged(SensorSettings);
            }
        }
        public SizeSettings SizeSettings
        {
            get { return sizeSettings; }
            set
            {
                sizeSettings = value;
                OnPropertyChanged(sizeSettings);
            }
        }
        public POICollection POICollection
        {
            get { return poiCollection; }
            set
            {
                poiCollection = value;
                OnPropertyChanged(poiCollection);
            }
        }
        public SensorCollection SensorCollection
        {
            get { return sensorCollection; }
            set
            {
                sensorCollection = value;
                OnPropertyChanged(sensorCollection);
            }
        }
    }
}
