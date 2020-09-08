//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Threading.Tasks;
//using FaultApp2.Shared;

//namespace FaultApp2.Server.Controllers
//{
//    [TypeConverter(typeof(MakinaController))]
//    public class MakineGrubuConverter: TypeConverter
//    {

//        public override bool CanConvertFrom(ITypeDescriptorContext context,
//    Type sourceType)
//        {
//            return sourceType == typeof(string);
//        }

//        public override object ConvertFrom(ITypeDescriptorContext context,
//            System.Globalization.CultureInfo culture, object value)
//        {
//            return new MakinaGrubuController((string)value);
//        }

//        public override bool CanConvertTo(ITypeDescriptorContext context,
//            Type destinationType)
//        {
//            return destinationType == typeof(string);
//        }

//        public override object ConvertTo(ITypeDescriptorContext context,
//            System.Globalization.CultureInfo culture, object value, Type destinationType)
//        {
//            return value == null ? null : string.Join(", ", (MakinaGrubuController)value);
//        }


//    }
//}
