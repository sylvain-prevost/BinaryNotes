
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
    [ASN1BoxedType(Name = "ITUType4")]
    public class ITUType4: IASN1PreparedElement 
    {

        private ITUType3 val;

        
		[ASN1Element(Name = "ITUType4", IsOptional = false, HasTag = true, Tag = 7, TagClass = TagClasses.Application, HasDefaultValue = false)]
        public ITUType3 Value
        {
            get { return val; }
            
            set { val = value; }
            
        }

        
        
        public ITUType4 ()
        {
        }

        public void initWithDefaults()
        {
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(ITUType4));
        public IASN1PreparedElementData PreparedData 
        {
            get { return preparedData; }
        }

    }
            
}
