/*
 * Created by SharpDevelop.
 * User: bayram
 * Date: 10/6/2018
 * Time: 12:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SubnetCalculator
{
	/// <summary>
	/// Description of about.
	/// </summary>
	public partial class about : Form
	{
		public about()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void AboutLoad(object sender, EventArgs e)
		{
			lblabout.Text= "SubnetCalculator version 0.2\n" +
            "Author   : Bayram Kotan\n" +
            "Email     : bayramkotan@gmail.com\n" +
            "Website : bayramkotan.com" + 
			"\n\nCopyright©2020\n\n"+
				"This program is free software: you can redistribute it and/or modify"+
				"it under the terms of the GNU General Public License as published by" +
				"the Free Software Foundation, either version 3 of the License, or" + 
				"(at your option) any later version." +

"This program is distributed in the hope that it will be useful," +
"but WITHOUT ANY WARRANTY; without even the implied warranty of" +
"MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for for more details." +

"\n\nYou should have received a copy of the GNU General Public License"+
"along with this program.  If not, see http://www.gnu.org/licenses/.";
		}
	}
}
