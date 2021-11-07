﻿using SensorsMaster.AppSettings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace SensorsMaster.Device.Model
{
    [XmlRoot(nameof(BoardElement), IsNullable = false)]
    public abstract class BoardElement
    {
        [XmlIgnore]
        public Settings Settings => Settings.GetInstance();

        [XmlIgnore]
        public static int Count { get; private set; }
        /// <summary>
        /// Autogenerated. Starts at 0.
        /// </summary>
        [XmlAttribute]
        public int Id { get; set; }
        [XmlElement]
        public Coordinates Coordinates { get; set; }

        public BoardElement()
        {
            Id = Count++;
            Coordinates = new Coordinates(0, 0);
        }
        public BoardElement(Coordinates coordinates) : this()
        {
            Coordinates = coordinates;
        }
        public BoardElement(double x, double y) : this( new Coordinates(x,y))
        { }


        public double Distance(BoardElement element)
        {
            return this.Coordinates.Distance(element.Coordinates);
        }
    }
}
