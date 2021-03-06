﻿//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.Fo.Properties
{
    internal class GenericCondPadding : GenericCondLength
    {
        new public static PropertyMaker Maker(string propName)
        {
            return new GenericCondPadding(propName);
        }

        protected GenericCondPadding(string name) : base(name) { }


        public override bool IsInherited()
        {
            return false;
        }

        protected override string getDefaultForLength()
        {
            return "0pt";
        }

    }
}