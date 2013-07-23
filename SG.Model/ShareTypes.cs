using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG.Model
{
    public class ShareType
    {
        public int Value { get; private set; }

        private ShareType() : this(default(ShareTypes))
        {
            
        }

        public ShareType(int value)
        {
            Value = value;
        }

        public ShareType(ShareTypes type)
        {
            Value = (int) type;
        }

        public static implicit operator int(ShareType type)
        {
            return type.Value;
        }

        public static implicit operator ShareType(int value)
        {
            return new ShareType(value);
        }

        public static implicit operator ShareTypes(ShareType type)
        {
            return (ShareTypes) type.Value;
        }
        public static implicit operator ShareType(ShareTypes type)
        {
            return new ShareType(type);
        }

    }
    
    
    public enum ShareTypes : int { Half = 0 , Whole = 1}
}
