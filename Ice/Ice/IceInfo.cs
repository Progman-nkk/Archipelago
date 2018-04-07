using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Ice
{
    public class IceInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "Ice";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("50de6d6e-451f-4dde-9ac3-1d2e88996ce8");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
