
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
    [ASN1BoxedType(Name = "Config2")]
    public class Config2: IASN1PreparedElement 
    {

        private Config2SequenceType val;

        
    [ASN1PreparedElement]
    [ASN1Sequence(Name = "Config2", IsSet = false)]
    public class Config2SequenceType : IASN1PreparedElement
    {
        
        private LstVersion lstVersion_;
        
		[ASN1Element(Name = "lstVersion", IsOptional = false, HasTag = false, HasDefaultValue = false)]
        public LstVersion LstVersion
        {
            get { return lstVersion_; }
            set { lstVersion_ = value;  }
        }
  
        private Major major_config_;
        
		[ASN1Element(Name = "major_config", IsOptional = false, HasTag = false, HasDefaultValue = false)]
        public Major Major_config
        {
            get { return major_config_; }
            set { major_config_ = value;  }
        }
  
        
        public void initWithDefaults() 
        {
            
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Config2SequenceType));
        public IASN1PreparedElementData PreparedData 
        {
            get { return preparedData; }
        }
    }
                
		[ASN1Element(Name = "Config2", IsOptional = false, HasTag = true, Tag = 79, TagClass = TagClasses.Application, HasDefaultValue = false)]
        public Config2SequenceType Value
        {
            get { return val; }
            
            set { val = value; }
            
        }

        
        
        public Config2 ()
        {
        }

        public void initWithDefaults()
        {
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Config2));
        public IASN1PreparedElementData PreparedData 
        {
            get { return preparedData; }
        }

    }
            
}
