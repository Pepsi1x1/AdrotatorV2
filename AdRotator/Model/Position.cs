using AdRotator.AdProviders;

namespace AdRotator.Model
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdProviderNone))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdProviderDefaultHouseAd))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdProviderSmaato))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdProviderMobFox))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdProviderInnerActive))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdProviderAdDuplex))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdProviderAdMob))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdProviderPubCenter))]
    public class Position
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Latitude;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Longitude;
    }
}
