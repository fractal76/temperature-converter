using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TemperatureConverter;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public float CtoF(float c)
        {
            return ConvertTemperature.CelsiusToFarenheit(c);
        }

        [WebMethod]
        public float FtoC(float f)
        {
            return ConvertTemperature.FarenheitToCelsius(f);
        }

        [WebMethod]
        public float CtoK(float c)
        {
            return ConvertTemperature.CelsiusToKelvin(c);
        }

        [WebMethod]
        public float KtoC(float k)
        {
            return ConvertTemperature.KelvinToCelsius(k);
        }

        [WebMethod]
        public float FtoK(float f)
        {
            return ConvertTemperature.FarenheitToKelvin(f);
        }

        [WebMethod]
        public float KtoF(float k)
        {
            return ConvertTemperature.KelvinToFarenheit(k);
        }
    }
}
