using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare
{
    abstract public class ArithmaticWielding
    {
        public static Arithmatics.Addition Addition = new Arithmatics.Addition();
        public static Arithmatics.Subtraction Subtraction = new Arithmatics.Subtraction();
        public static Arithmatics.Division Division = new Arithmatics.Division();
        public static Arithmatics.Multiplication Multiplication = new Arithmatics.Multiplication();
        public static Arithmatics.Root Root = new Arithmatics.Root();
    }
}
