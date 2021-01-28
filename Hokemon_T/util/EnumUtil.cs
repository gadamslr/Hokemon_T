using System;

namespace Hokemon_T.util {
    
    public class EnumUtil {
        
        /**
         * Converts an Input String to an Enum value of Type T
         */
        public static T GetEnumValue<T>(string input) where T : struct, IComparable {

            T found;
            
            foreach (var i in Enum.GetNames(typeof(T))) {
                if (i.Equals(input, StringComparison.InvariantCultureIgnoreCase)) {
                    return Enum.Parse<T>(i);
                }
            }

            return default(T);
        }
        
    }
}