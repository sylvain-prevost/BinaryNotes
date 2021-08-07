
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
    [ASN1BoxedType(Name = "StringArray")]
    public class StringArray : IASN1PreparedElement 
    {

        private System.Collections.Generic.ICollection<string> val = null; 
        
        
		[ASN1String(Name = "", StringType = UniversalTags.PrintableString, IsUCS = false)]
        [ASN1SequenceOf(Name = "StringArray", IsSetOf = false)]

        public System.Collections.Generic.ICollection<string> Value
        {
            get { return val; }
            set { val = value; }
        }
        
        public void initValue() 
        {
            this.Value = new System.Collections.Generic.List<string>();
        }
        
        public void Add(string item) 
        {
            this.Value.Add(item);
        }

        public void initWithDefaults()
        {
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(StringArray));
        public IASN1PreparedElementData PreparedData 
        {
            get { return preparedData; }
        }

    }
            
}
