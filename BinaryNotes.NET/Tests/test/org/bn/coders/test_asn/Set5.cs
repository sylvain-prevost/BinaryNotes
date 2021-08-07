
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
    [ASN1BoxedType(Name = "Set5")]
    public class Set5: IASN1PreparedElement 
    {

        private System.Collections.Generic.ICollection<Set3> val;

        
		[ASN1SequenceOf(Name = "Set5", IsSetOf = true)]
    
		[ASN1Element(Name = "Set5", IsOptional = false, HasTag = true, Tag = 127, TagClass = TagClasses.Application, HasDefaultValue = false)]
        public System.Collections.Generic.ICollection<Set3> Value
        {
            get { return val; }
            
            set { val = value; }
            
        }

        
        
        public Set5 ()
        {
        }

        public void initWithDefaults()
        {
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Set5));
        public IASN1PreparedElementData PreparedData 
        {
            get { return preparedData; }
        }

    }
            
}
