
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System;
using org.bn.attributes;
using org.bn.attributes.constraints;
using org.bn.coders;
using org.bn.types;
using org.bn;

namespace test.org.bn.coders.test_asn {


    [ASN1PreparedElement]
    [ASN1Sequence ( Name = "SequenceWithEnum", IsSet = false  )]
    public class SequenceWithEnum : IASN1PreparedElement {
                    
	private string item_ ;
	[ASN1String( Name = "", 
        StringType =  UniversalTags.PrintableString , IsUCS = false )]
        [ASN1Element ( Name = "item", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public string Item
        {
            get { return item_; }
            set { item_ = value;  }
        }
        
                
          
	private ContentSchema enval_ ;
	
        [ASN1Element ( Name = "enval", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public ContentSchema Enval
        {
            get { return enval_; }
            set { enval_ = value;  }
        }
        
                
          
	private ContentSchema taggedEnval_ ;
	
        [ASN1Element ( Name = "taggedEnval", IsOptional =  false , HasTag =  true, Tag = 1 , HasDefaultValue =  false )  ]
    
        public ContentSchema TaggedEnval
        {
            get { return taggedEnval_; }
            set { taggedEnval_ = value;  }
        }
        
                
  

            public void initWithDefaults() {
                
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(SequenceWithEnum));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
