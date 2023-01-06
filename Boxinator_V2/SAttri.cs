using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boxinator_V2.Usercontrol
{
    public class SAttri : UserControl
    {
        private string name;
		public string Namee{
			get{return name;}
			set{name = value;}
		}
		
		// public string Getname()
		// {
		// 	return name;
		// }
		// public void Setname(string value)
		// {
		// 	name = value;
		// }
    }
}

// namespace Boxinator_V2.Usercontrol
// {
// 	[AttributeUsage(AttributeTargets.Class)]
// 	public class SAttri : Attribute {
// 		public string name{get;set;}
// 	}
	
// 	[SAttri]
// 	public class Test{
// 		public string name {get;set;}
// 		public void sa(){
// 			var category =  
// 		}
// 	}
	
	
// }