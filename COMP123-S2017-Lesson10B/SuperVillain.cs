using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson10B
{
    /// <summary>
    /// This is the SuperVillain class.
    /// </summary>
    public class SuperVillain : SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _malice;

        // PUBLIC PROPERTIES

        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice = value;
            }
        }

        /// <summary>
        /// This is the main constructor.
        /// It takes two arguments - name (string) - malice (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="malice"></param>
        public SuperVillain(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }


    }
}
