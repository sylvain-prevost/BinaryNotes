
//
// This file was generated by the BinaryNotes compiler (created by Abdulla Abdurakhmanov, modified by Sylvain Prevost).
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System;
using System.Numerics;

using org.bn.attributes;
using org.bn.attributes.constraints;
using org.bn.coders;
using org.bn.types;
using org.bn;

namespace test.org.bn.coders.test_asn {


    [ASN1PreparedElement]
    [ASN1BoxedType(Name = "FQDN")]
    public class FQDN: IASN1PreparedElement 
    {

        private String val;

        [ASN1String(Name = "FQDN", StringType = UniversalTags.VisibleString, IsUCS = false)]
        
		[ASN1ValueRangeConstraint(Min = 1, Max = 255)]
        public String Value
        {
            get { return val; }
            set { val = value; }
        }
        
        public FQDN() 
        {
        }

        public FQDN(String val) 
        {
            this.val = val;
        }

        public void initWithDefaults() 
        {
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(FQDN));
        public IASN1PreparedElementData PreparedData 
        {
            get { return preparedData; }
        }

    }
            
}
