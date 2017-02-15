using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD02
{
    class Collection
    {
        /// <summary>
        /// Collection for CD and song objects for when they are added by a method
        /// </summary>
        private List<CD> cds;
    


        /// <summary>
        /// Constructor defaulted to create collection of CD objects
        /// </summary>
        public Collection()
        {
           cds = new List<CD>();
          

        }
        /// <summary>
        /// Method to add CD objects to collection 
        /// </summary>
        /// <param name="cd"></param>
         public void addCD(CD cd)
        {
            cds.Add(cd);
            
        }

        

        /// <summary>
        /// Prints out all CD objects in CDs collection
        /// </summary>
        public void PrintCollection()
        {
            foreach(CD cd in cds)
            {
                {
                    Console.WriteLine(cd.ToString());
                    
                }
     
            }

            
        }





   
  
    }
}
