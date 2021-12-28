/*
 * Created by SharpDevelop.
 * User: bayram
 * Date: 9/22/2018
 * Time: 11:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace SubnetCalculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		// DECIMAL TO BINARY
			public string decimal2binary(double a)
			{
				int num = Convert.ToInt32(a);
           		string result = "";
           		
           		while (num > 1)
           			 {
               			 int remainder = num % 2;
               			 result = Convert.ToString(remainder) + result;
                		 num /= 2;
           			 }
            	result = Convert.ToString(num) + result;
            	return result.PadLeft(8,'0');
			}
			
		
//			// BINARY TO DECIMAL --> NO NEED. Because there is already a process for this
//			public int binary2decimal(string a)
//			{
//				int n1,n,p=1;
//				int dec=0,i=1,j,d;
//	
//  			 n = Convert.ToInt32(a);	
//			
//  			 n1=n;
//			
//  			 for (j=n;j>0;j=j/10)
//				{  
//          			d = j % 10;
//          			
//            		if(i==1){p*=1;}
//            		else{p*=2;}
//					dec=dec+(d*p);
//	 				i++;
//				}
//  			 
//  			 return dec;
//			 }
		
		
			
			// ADDITION OF TWO BINAY NUMBERS
			
		public string add2binary(string a, string b) 
   		 { 
          
	        string result = "";  
	        int s = 0;          
  

	        int i = a.Length - 1;
	        int j = b.Length - 1;
    	 	while (i >= 0 || j >= 0 || s == 1) 
       		 { 
            	s += ((i >= 0)? a[i] - '0': 0); 
            	s += ((j >= 0)? b[j] - '0': 0); 
  		        result = (char)(s % 2 + '0') + result; 
           		s /= 2; 
            	i--; 
            	j--;
        	 } 
    	return result; 
    	
    	} 
			
			
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}



		void cmbMaskBitSelectedIndexChanged(object sender, EventArgs e)
		{
					
			if((!string.IsNullOrWhiteSpace(cmbMaskBit.Text)) )
					{
						int maskbit = cmbMaskBit.SelectedIndex;
						cmbNetMaskDigit1.SelectedIndex=maskbit;
						cmbNetMaskDigit2.SelectedIndex=maskbit;
						cmbNetMaskDigit3.SelectedIndex=maskbit;
						cmbNetMaskDigit4.SelectedIndex=maskbit;
			
			
						lblNetworkDigit1.Text=Convert.ToString(Convert.ToInt32(firstDigitTXT.Text),2).PadLeft(8,'0');
						lblNetworkDigit2.Text=Convert.ToString(Convert.ToInt32(secondDigitTXT.Text),2).PadLeft(8,'0');
						lblNetworkDigit3.Text=Convert.ToString(Convert.ToInt32(thirdDigitTXT.Text),2).PadLeft(8,'0');
						lblNetworkDigit4.Text=Convert.ToString(Convert.ToInt32(fourthDigitTXT.Text),2).PadLeft(8,'0');
			
						lblNetMaskDigit1.Text=Convert.ToString(Convert.ToInt32(cmbNetMaskDigit1.Text),2).PadLeft(8,'0');
						lblNetMaskDigit2.Text=Convert.ToString(Convert.ToInt32(cmbNetMaskDigit2.Text),2).PadLeft(8,'0');
						lblNetMaskDigit3.Text=Convert.ToString(Convert.ToInt32(cmbNetMaskDigit3.Text),2).PadLeft(8,'0');
						lblNetMaskDigit4.Text=Convert.ToString(Convert.ToInt32(cmbNetMaskDigit4.Text),2).PadLeft(8,'0');
						

						
			
						//Avaiable host numbers 2^n-2                1 or BC and 1 for NI
						int number_of_hostbits=32-Convert.ToInt32 (cmbMaskBit.Text);
						lblHostbit.Text=Convert.ToString(number_of_hostbits);
						lblHostbit2.Text=Convert.ToString(" n = 32 - " + cmbMaskBit.Text + " = " + number_of_hostbits);   // show number of hostbits on lblHosbit
						double available_host_number=Math.Pow(2,number_of_hostbits)-2;
						lblHostNumber.Text= Convert.ToString(available_host_number);
						lblHostNumber2.Text=" 2^n - 2 = 2^" + Convert.ToString(number_of_hostbits) + " - 2 ";
						if(number_of_hostbits==0){lblHostNumber.Text="0";}
						
						// AND Operations for NETWORK ID
						
						lblFirstNetworkIDBits.Text= Convert.ToString((Convert.ToInt32(lblNetworkDigit1.Text,2)) & (Convert.ToInt32(lblNetMaskDigit1.Text,2)),2).PadLeft(8,'0');
						lblSecondNetworkIDBits.Text= Convert.ToString((Convert.ToInt32(lblNetworkDigit2.Text,2)) & (Convert.ToInt32(lblNetMaskDigit2.Text,2)),2).PadLeft(8,'0');
						lblThirdNetworkIDBits.Text= Convert.ToString((Convert.ToInt32(lblNetworkDigit3.Text,2)) & (Convert.ToInt32(lblNetMaskDigit3.Text,2)),2).PadLeft(8,'0');
						lblFourthNetworkIDBits.Text= Convert.ToString((Convert.ToInt32(lblNetworkDigit4.Text,2)) & (Convert.ToInt32(lblNetMaskDigit4.Text,2)),2).PadLeft(8,'0');
						
						lblFirstNetworkID.Text=Convert.ToString(Convert.ToInt32(lblFirstNetworkIDBits.Text,2));
						lblSecondNetworkID.Text=Convert.ToString(Convert.ToInt32(lblSecondNetworkIDBits.Text,2));
						lblThirdNetworkID.Text=Convert.ToString(Convert.ToInt32(lblThirdNetworkIDBits.Text,2));
						lblFourthNetworkID.Text=Convert.ToString(Convert.ToInt32(lblFourthNetworkIDBits.Text,2));
						
						// First Host IP // Last Host IP // Broadcast IP
	

						lblFirstHost1.Text=lblFirstNetworkID.Text;
						lblFirstHost1Bits.Text=lblFirstNetworkIDBits.Text;	
						lblLastHost1.Text=lblFirstNetworkID.Text;
						lblLastHost1Bits.Text=lblFirstNetworkIDBits.Text;	
										
						lblFirstHost2.Text=lblSecondNetworkID.Text;
						lblFirstHost2Bits.Text=lblSecondNetworkIDBits.Text;	
						lblLastHost2.Text=lblSecondNetworkID.Text;
						lblLastHost2Bits.Text=lblSecondNetworkIDBits.Text;	
						
						lblFirstHost3.Text=lblThirdNetworkID.Text;
						lblFirstHost3Bits.Text=lblThirdNetworkIDBits.Text;
						lblLastHost3.Text=lblThirdNetworkID.Text;
						lblLastHost3Bits.Text=lblThirdNetworkIDBits.Text;	

						lblFirstHost4.Text=lblFourthNetworkID.Text;
						lblFirstHost4Bits.Text=lblFourthNetworkIDBits.Text;	
						lblLastHost4.Text=lblFourthNetworkID.Text;
						lblLastHost4Bits.Text=lblFourthNetworkIDBits.Text;	
						

						
						string available_host_number_binary_string=decimal2binary(available_host_number);
						
						//MessageBox.Show(add2binary(available_host_number_binary_string,available_host_number_binary_string));
						
						string NetworkIDBits = lblFirstNetworkIDBits.Text + lblSecondNetworkIDBits.Text+lblThirdNetworkIDBits.Text+lblFourthNetworkIDBits.Text;
						
						//MessageBox.Show(NetworkIDBits);
						
						//Add 
						
						string totalInBits=add2binary(available_host_number_binary_string,NetworkIDBits);
						
						//MessageBox.Show("     " + available_host_number_binary_string.PadLeft(32,'0') + "\n     " + NetworkIDBits + "\n" + " = " + totalInBits );
						
						string totalInBits1 = totalInBits.Substring(0, 8);
						string totalInBits2 = totalInBits.Substring(8, 8);
						string totalInBits3 = totalInBits.Substring(16, 8);
						string totalInBits4 = totalInBits.Substring(24, 8);
						
						//MessageBox.Show("     " + available_host_number_binary_string.PadLeft(32,'0') + "\n     " + NetworkIDBits + "\n" + " = " + totalInBits + "\n\n" + totalInBits1 + " " + totalInBits2 + " " + totalInBits3 +" " + totalInBits4);
						
						//LAST HOST BITS and IP
						lblLastHost1Bits.Text=totalInBits1;
						lblLastHost2Bits.Text=totalInBits2;
						lblLastHost3Bits.Text=totalInBits3;
						lblLastHost4Bits.Text=totalInBits4;
						
						lblLastHost1.Text=Convert.ToString(Convert.ToInt32(lblLastHost1Bits.Text,2));
						lblLastHost2.Text=Convert.ToString(Convert.ToInt32(lblLastHost2Bits.Text,2));
						lblLastHost3.Text=Convert.ToString(Convert.ToInt32(lblLastHost3Bits.Text,2));
						lblLastHost4.Text=Convert.ToString(Convert.ToInt32(lblLastHost4Bits.Text,2));
						
						//FIRS HOST BITS and IP
						string firsthostbitsTotal=add2binary(NetworkIDBits,"1");
						
						string firsthostbitsTotal1 = firsthostbitsTotal.Substring(0, 8);
						string firsthostbitsTotal2 = firsthostbitsTotal.Substring(8, 8);
						string firsthostbitsTotal3 = firsthostbitsTotal.Substring(16, 8);
						string firsthostbitsTotal4 = firsthostbitsTotal.Substring(24, 8);
						
						lblFirstHost1Bits.Text=firsthostbitsTotal1;
						lblFirstHost2Bits.Text=firsthostbitsTotal2;
						lblFirstHost3Bits.Text=firsthostbitsTotal3;
						lblFirstHost4Bits.Text=firsthostbitsTotal4;
						
						lblFirstHost1.Text=Convert.ToString(Convert.ToInt32(lblFirstHost1Bits.Text,2));
						lblFirstHost2.Text=Convert.ToString(Convert.ToInt32(lblFirstHost2Bits.Text,2));
						lblFirstHost3.Text=Convert.ToString(Convert.ToInt32(lblFirstHost3Bits.Text,2));
						lblFirstHost4.Text=Convert.ToString(Convert.ToInt32(lblFirstHost4Bits.Text,2));

					}
		}


		void MainFormLoad(object sender, EventArgs e)
		{
			cmbMaskBit.Items.AddRange(new object[] {"32","31","30","29","28","27","26","25","24","23","22","21","20","19","18","17","16","15","14","13","12","11","10","9","8","7","6","5","4","3","2","1"});
			cmbNetMaskDigit1.Items.AddRange(new object[] {"255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","254","252","248","240","224","192","128"});
			cmbNetMaskDigit2.Items.AddRange(new object[] {"255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","254","252","248","240","224","192","128","0","0","0","0","0","0","0","0"});
			cmbNetMaskDigit3.Items.AddRange(new object[] {"255","255","255","255","255","255","255","255","255","254","252","248","240","224","192","128","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"});
			cmbNetMaskDigit4.Items.AddRange(new object[] {"255","254","252","248","240","224","192","128","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"});			
			
			//Default values
			firstDigitTXT.Text="10";
			secondDigitTXT.Text="68";
			thirdDigitTXT.Text="208";
			fourthDigitTXT.Text="0";
			cmbMaskBit.SelectedIndex=7; //32-7=25 --> /25 
			
		}
		
		void MainFormTextChanged(object sender, EventArgs e)
		{
				
		}
		

		void FirstDigitTXTTextChanged(object sender, EventArgs e)
		{
            CheckNumber(sender, e, firstDigitTXT.Text);
        }


		void SecondDigitTXTTextChanged(object sender, EventArgs e)
		{
            CheckNumber(sender, e, secondDigitTXT.Text);
        }

		void ThirdDigitTXTTextChanged(object sender, EventArgs e)
		{
            CheckNumber(sender, e, thirdDigitTXT.Text);
        }

		void FourthDigitTXTTextChanged(object sender, EventArgs e)
		{
            CheckNumber(sender, e, fourthDigitTXT.Text);
        }
		
				
		void CmbNetMaskDigit4SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbMaskBitSelectedIndexChanged(sender,e);
		}
		void CmbMaskBitTextChanged(object sender, EventArgs e)
		{
			
				if(!string.IsNullOrWhiteSpace(cmbMaskBit.Text))
				{

							int mask = Convert.ToInt32(cmbMaskBit.Text);
			
							if (mask > 0 && mask < 33)
								{
									int index=32-mask;
			
									cmbMaskBit.SelectedIndex=index;
				
								// focus cursor at the end of the text
									cmbMaskBit.SelectionStart=cmbMaskBit.Text.Length;
								}
			
							else
								{
									cmbMaskBit.SelectedIndex=8;
									MessageBox.Show("Please enter a number between 1 and 32");
						
								}
						
				}

		}


        // created by Bayram Kotan @ 23 sept 2018
        void CheckNumber(object sender, EventArgs e, String s)
        {
        	if (!string.IsNullOrWhiteSpace(s))
            {
        		
        		for(int i=0;i<s.Length;i++)
        		{
        			if(int.TryParse(s, out i))
        			{

               		 int value = Convert.ToInt32(s);
                	 if ((value >= 0) && (value <= 255))
               			 {

                   			 cmbMaskBitSelectedIndexChanged(sender, e);
                		 }

                	else
               			 {
                  		    MessageBox.Show("Please enter a number between 0 and 255");
             		     }
        			}
        			else
        				return;
        		}

            }

        }





    }
}
