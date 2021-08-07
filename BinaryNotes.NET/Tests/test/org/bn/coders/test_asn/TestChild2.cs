
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
    [ASN1Choice(Name = "TestChild2")]
    public class TestChild2 : IASN1PreparedElement 
    {
        
        private BigInteger field10_;
        private bool  field10_selected = false;

        [ASN1Integer( Name = "" )]
    
		[ASN1Element(Name = "field10", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public BigInteger Field10
        {
            get { return field10_; }
            set { selectField10(value); }
        }
  
        private byte[] field20_;
        private bool  field20_selected = false;

        [ASN1OctetString( Name = "" )]
    
		[ASN1Element(Name = "field20", IsOptional = true, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public byte[] Field20
        {
            get { return field20_; }
            set { selectField20(value); }
        }
  
        private string field30_;
        private bool  field30_selected = false;

        
		[ASN1String(Name = "", StringType = UniversalTags.UTF8String, IsUCS = false)]
		[ASN1Element(Name = "field30", IsOptional = false, HasTag = true, Tag = 2, HasDefaultValue = false)]
        public string Field30
        {
            get { return field30_; }
            set { selectField30(value); }
        }
  
        private BigInteger field40_;
        private bool  field40_selected = false;

        [ASN1Integer( Name = "" )]
    
		[ASN1Element(Name = "field40", IsOptional = false, HasTag = true, Tag = 3, HasDefaultValue = false)]
        public BigInteger Field40
        {
            get { return field40_; }
            set { selectField40(value); }
        }
  
        public bool isField10Selected()
        {
            return this.field10_selected;
        }

        

        public void selectField10 (BigInteger val) 
        {
            this.field10_ = val;
            this.field10_selected = true;
            
            this.field20_selected = false;
            
            this.field30_selected = false;
            
            this.field40_selected = false;
            
        }
  
        public bool isField20Selected()
        {
            return this.field20_selected;
        }

        

        public void selectField20 (byte[] val) 
        {
            this.field20_ = val;
            this.field20_selected = true;
            
            this.field10_selected = false;
            
            this.field30_selected = false;
            
            this.field40_selected = false;
            
        }
  
        public bool isField30Selected()
        {
            return this.field30_selected;
        }

        

        public void selectField30 (string val) 
        {
            this.field30_ = val;
            this.field30_selected = true;
            
            this.field10_selected = false;
            
            this.field20_selected = false;
            
            this.field40_selected = false;
            
        }
  
        public bool isField40Selected()
        {
            return this.field40_selected;
        }

        

        public void selectField40 (BigInteger val) 
        {
            this.field40_ = val;
            this.field40_selected = true;
            
            this.field10_selected = false;
            
            this.field20_selected = false;
            
            this.field30_selected = false;
            
        }
  
        private string field5_;
        private bool  field5_selected = false;

        
		[ASN1String(Name = "", StringType = UniversalTags.UTF8String, IsUCS = false)]
		[ASN1Element(Name = "field5", IsOptional = false, HasTag = true, Tag = 4, HasDefaultValue = false)]
        public string Field5
        {
            get { return field5_; }
            set { selectField5(value); }
        }
  
        private string field6_;
        private bool  field6_selected = false;

        
		[ASN1String(Name = "", StringType = UniversalTags.UTF8String, IsUCS = false)]
		[ASN1Element(Name = "field6", IsOptional = false, HasTag = true, Tag = 7, HasDefaultValue = false)]
        public string Field6
        {
            get { return field6_; }
            set { selectField6(value); }
        }
  
        public bool isField6Selected()
        {
            return this.field6_selected;
        }

        

        public void selectField6 (string val) 
        {
            this.field6_ = val;
            this.field6_selected = true;
            
        }
  
        public bool isField5Selected()
        {
            return this.field5_selected;
        }

        

        public void selectField5 (string val) 
        {
            this.field5_ = val;
            this.field5_selected = true;
            
        }
  

        public void initWithDefaults()
        {
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(TestChild2));
        public IASN1PreparedElementData PreparedData 
        {
            get { return preparedData; }
        }

    }
            
}
