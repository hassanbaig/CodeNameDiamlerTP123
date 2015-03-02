using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamlerTP.DAL
{
    public class VehicleDimension
    {
        public long ID { get; set; }

        public string VehicleDescription { get; set; }

        public string Model { get; set; }

        public string VLength { get; set; }

        public string VWidth { get; set; }

        public string VHeight { get; set; }

        public string VWeight { get; set; }

        public string WheelBase { get; set; }

        public string VehicleGroundSpace { get; set; }

        public string SlopeAngle { get; set; }

        public string FoldedMirrorWidth { get; set; }

        public string VPrice { get; set; }
    }
}
