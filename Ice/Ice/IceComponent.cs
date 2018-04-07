using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace Ice
{
    public class IceComponent : GH_Component
    {
       
        public IceComponent()
          : base("Ice", "Ice",
              "Grows Clathrate Hydrate crystal.",
              "Archipelago", "Growth")
        {
        }
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
           
            pManager.AddPlaneParameter("Plane", "P", "Base plane for spiral", GH_ParamAccess.item, Plane.WorldXY);
            pManager.AddNumberParameter("Inner Radius", "R0", "Inner radius for spiral", GH_ParamAccess.item, 1.0);
            pManager.AddNumberParameter("Outer Radius", "R1", "Outer radius for spiral", GH_ParamAccess.item, 10.0);
            pManager.AddIntegerParameter("Turns", "T", "Number of turns between radii", GH_ParamAccess.item, 10);

        }
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
          
            pManager.AddCurveParameter("Spiral", "S", "Spiral curve", GH_ParamAccess.item);

        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            
            Plane plane = Plane.WorldXY;
            double radius0 = 0.0;
            double radius1 = 0.0;
            int turns = 0;

            if (!DA.GetData(0, ref plane)) return;
            if (!DA.GetData(1, ref radius0)) return;
            if (!DA.GetData(2, ref radius1)) return;
            if (!DA.GetData(3, ref turns)) return;

            DA.SetData(0, null);
        }


        public override GH_Exposure Exposure
        {
            get { return GH_Exposure.primary; }
        }
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return null;
            }
        }
        public override Guid ComponentGuid
        {
            get { return new Guid("52fcb24b-7149-4e4d-b013-19f527524b15"); }
        }
    }
}
