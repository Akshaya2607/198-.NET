using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALlayer
{
    public class CategoryBAL
    {
        int _catid;
        public int CategoryID
        {
            get
            {
                return _catid;

            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("category id cannot be null or zero");
                }
                else
                {
                    _catid = value;
                }
            }
        }

        string _name;
        public string Catname
        {
            get { return _name; }
            set
            {
                if(value.Length>0)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentNullException("Name can't be blank or null");
                }
            }
        }

        public string CatDesc { get; set; }
    }
}
