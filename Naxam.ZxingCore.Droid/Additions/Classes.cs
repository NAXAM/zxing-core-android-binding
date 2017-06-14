
namespace Com.Google.Zxing.Client.Result
{
    partial class AddressBookAUResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseAddressBook(p0);
        }
    }
    partial class AddressBookDoCoMoResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseAddressBook(p0);
        }
    }
    partial class BizcardResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseBizcard(p0);
        }
    }
    partial class BookmarkDoCoMoResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseBookmark(p0);
        }
    }
    partial class EmailAddressResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseEmailAddress(p0);
        }
    }
    partial class EmailDoCoMoResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseEmail(p0);
        }
    }
    partial class ExpandedProductResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseProduct(p0);
        }
    }
    partial class GeoResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseGeo(p0);
        }
    }
    partial class ISBNResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseISBN(p0);
        }
    }
    partial class ProductResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseProduct(p0);
        }
    }
    partial class SMSMMSResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseSMSMMS(p0);
        }
    }
    partial class SMSTOMMSTOResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseSMSTOMMSTO(p0);
        }
    }
    partial class SMTPResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseSMTP(p0);
        }
    }
    partial class TelResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseTel(p0);
        }
    }
    partial class URIResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseURI(p0);
        }
    }
    partial class URLTOResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseURLTO(p0);
        }
    }
    partial class VCardResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseVCard(p0);
        }
    }
    partial class VEventResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseVEvent(p0);
        }
    }
    partial class VINResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseVIN(p0);
        }
    }
    partial class WifiResultParser
    {
        public override ParsedResult Parse(Zxing.Result p0)
        {
            return ParseWifi(p0);
        }
    }
}