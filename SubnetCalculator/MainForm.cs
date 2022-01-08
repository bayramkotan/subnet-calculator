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
		
		
			
			// ADDITION OF TWO BINARY NUMBERS
			
		public string add2binary(string a, string b) 
   		 { 
          
	        string result = "";  
	        int s = 0;          
  		
	        if(a=="0")
	        {
	        	return b;
	        }
	        if(b=="0")
	        {
	        	return a;
	        }

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




        /// /////////////////////////////////////////////////////////////////


		void cmbMaskBitSelectedIndexChanged(object sender, EventArgs e)
		{

            lbl_number_of_networks.Text = "";

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
						
						lblMaskBit.Text=cmbMaskBit.Text;
						
						lblHostNumber2.BackColor=Color.Empty;
						
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
						

						
						string NetworkIDBits = lblFirstNetworkIDBits.Text + lblSecondNetworkIDBits.Text+lblThirdNetworkIDBits.Text+lblFourthNetworkIDBits.Text;
						
						
						//Add 
						
						string totalInBits=add2binary(available_host_number_binary_string,NetworkIDBits);
						
						if(number_of_hostbits>0)   // not /32
						{
						
						string totalInBits1 = totalInBits.Substring(0, 8);
						string totalInBits2 = totalInBits.Substring(8, 8);
						string totalInBits3 = totalInBits.Substring(16, 8);
						string totalInBits4 = totalInBits.Substring(24, 8);
						

						
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
						
						//BC BITS and IP
						string BCbitsTotal=add2binary(totalInBits,"1");
						
						string BCbitsTotal1 = BCbitsTotal.Substring(0, 8);
						string BCbitsTotal2 = BCbitsTotal.Substring(8, 8);
						string BCbitsTotal3 = BCbitsTotal.Substring(16, 8);
						string BCbitsTotal4 = BCbitsTotal.Substring(24, 8);
						
						lblBC_IP1Bits.Text=BCbitsTotal1;
						lblBC_IP2Bits.Text=BCbitsTotal2;
						lblBC_IP3Bits.Text=BCbitsTotal3;
						lblBC_IP4Bits.Text=BCbitsTotal4;
						
						lblBC_IP1.Text=Convert.ToString(Convert.ToInt32(lblBC_IP1Bits.Text,2));
						lblBC_IP2.Text=Convert.ToString(Convert.ToInt32(lblBC_IP2Bits.Text,2));
						lblBC_IP3.Text=Convert.ToString(Convert.ToInt32(lblBC_IP3Bits.Text,2));
						lblBC_IP4.Text=Convert.ToString(Convert.ToInt32(lblBC_IP4Bits.Text,2));
						
							if(number_of_hostbits==1) // if /31 then 
								{
								lblLastHost4.Text=lblFirstHost4.Text;
								lblLastHost4Bits.Text=lblFirstHost4Bits.Text;
								lblHostNumber.Text="1";
								lblHostNumber2.BackColor=Color.Red;
								}


						}
						else          // /32
						{
						
						//LAST HOST BITS and IP//FIRS HOST BITS and IP //BC BITS and IP
						lblLastHost1Bits.Text=lblBC_IP1Bits.Text=lblFirstHost1Bits.Text=Convert.ToString((Convert.ToInt32(lblNetworkDigit1.Text,2)) & (Convert.ToInt32(lblNetMaskDigit1.Text,2)),2).PadLeft(8,'0');
						lblLastHost2Bits.Text=lblBC_IP2Bits.Text=lblFirstHost2Bits.Text= Convert.ToString((Convert.ToInt32(lblNetworkDigit2.Text,2)) & (Convert.ToInt32(lblNetMaskDigit2.Text,2)),2).PadLeft(8,'0');
						lblLastHost3Bits.Text=lblBC_IP3Bits.Text=lblFirstHost3Bits.Text= Convert.ToString((Convert.ToInt32(lblNetworkDigit3.Text,2)) & (Convert.ToInt32(lblNetMaskDigit3.Text,2)),2).PadLeft(8,'0');
						lblLastHost4Bits.Text=lblBC_IP4Bits.Text=lblFirstHost4Bits.Text= Convert.ToString((Convert.ToInt32(lblNetworkDigit4.Text,2)) & (Convert.ToInt32(lblNetMaskDigit4.Text,2)),2).PadLeft(8,'0');
						
						lblLastHost1.Text=lblFirstHost1.Text=lblBC_IP1.Text=Convert.ToString(Convert.ToInt32(lblFirstNetworkIDBits.Text,2));
						lblLastHost2.Text=lblFirstHost2.Text=lblBC_IP2.Text=Convert.ToString(Convert.ToInt32(lblSecondNetworkIDBits.Text,2));
						lblLastHost3.Text=lblFirstHost3.Text=lblBC_IP3.Text=Convert.ToString(Convert.ToInt32(lblThirdNetworkIDBits.Text,2));
						lblLastHost4.Text=lblFirstHost4.Text=lblBC_IP4.Text=Convert.ToString(Convert.ToInt32(lblFourthNetworkIDBits.Text,2));
						
						lblHostNumber2.BackColor=Color.Red;

                        lblHostNumber.Text = "1";

                }





                if ((firstDigitTXT.Text=="10") || (firstDigitTXT.Text=="127") || ((firstDigitTXT.Text=="192") && (secondDigitTXT.Text=="168")) ||((firstDigitTXT.Text=="169") && (secondDigitTXT.Text=="254")) || ((firstDigitTXT.Text=="172")&& ((Convert.ToInt32(secondDigitTXT.Text) >=16) && (Convert.ToInt32(secondDigitTXT.Text) <=31) )))
			{
				lblFirstNetworkID.BackColor=Color.Orange;
				lblSecondNetworkID.BackColor=Color.Orange;
				lblThirdNetworkID.BackColor=Color.Orange;
				lblFourthNetworkID.BackColor=Color.Orange;
				
				lblFirstHost1.BackColor=Color.Orange;
				lblFirstHost2.BackColor=Color.Orange;
				lblFirstHost3.BackColor=Color.Orange;
				lblFirstHost4.BackColor=Color.Orange;
				
				lblLastHost1.BackColor=Color.Orange;
				lblLastHost2.BackColor=Color.Orange;
				lblLastHost3.BackColor=Color.Orange;
				lblLastHost4.BackColor=Color.Orange;
				
				lblBC_IP1.BackColor=Color.Orange;
				lblBC_IP2.BackColor=Color.Orange;
				lblBC_IP3.BackColor=Color.Orange;
				lblBC_IP4.BackColor=Color.Orange;
				
				lblMaskBit.BackColor=Color.Orange;
				

				
				lblPublicPrivateIP.ForeColor=Color.Orange;
				lblFirstDigtZero.ForeColor=Color.Orange;


									   	



				}
			else
			{
				lblFirstNetworkID.BackColor=Color.Azure;
				lblSecondNetworkID.BackColor=Color.Azure;
				lblThirdNetworkID.BackColor=Color.Azure;
				lblFourthNetworkID.BackColor=Color.Azure;
				
				lblFirstHost1.BackColor=Color.Azure;
				lblFirstHost2.BackColor=Color.Azure;
				lblFirstHost3.BackColor=Color.Azure;
				lblFirstHost4.BackColor=Color.Azure;
				
				lblLastHost1.BackColor=Color.Azure;
				lblLastHost2.BackColor=Color.Azure;
				lblLastHost3.BackColor=Color.Azure;
				lblLastHost4.BackColor=Color.Azure;
				
				lblBC_IP1.BackColor=Color.Azure;
				lblBC_IP2.BackColor=Color.Azure;
				lblBC_IP3.BackColor=Color.Azure;
				lblBC_IP4.BackColor=Color.Azure;
				
				lblMaskBit.BackColor=Color.Azure;
				
				lblPublicPrivateIP.Text="Public IP";
				lblPublicPrivateIP.ForeColor=Color.Blue;
				
							if((firstDigitTXT.Text=="0") || (lblFirstHost1.Text=="0"))
							{
								lblFirstDigtZero.Text="Not Applicable!";
								lblFirstDigtZero.BackColor=Color.Red;
							}
							else 
							{
								lblFirstDigtZero.Text="";
								lblFirstDigtZero.BackColor=Color.Empty;
							}
			}				
			}

			//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			if (firstDigitTXT.Text == "10")
			{
				if (lblFirstHost1.Text != "10") { lbl_first.Text = "Public"; } else { lbl_first.Text = "Private"; }
				if (lblLastHost1.Text != "10") { lbl_last.Text = "Public"; } else { lbl_last.Text = "Private"; }
				if (lblBC_IP1.Text != "10") { lbl_broadcast.Text = "Public"; } else { lbl_broadcast.Text = "Private"; }
			}
			//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


			//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			else if ((firstDigitTXT.Text == "169") && (secondDigitTXT.Text == "254"))
			{
				lblFirstDigtZero.Text = "APIPA";
				if ((lblFirstHost1.Text != "169") || (lblFirstHost2.Text != "254")) { lbl_first.Text = "Public"; } else { lbl_first.Text = "Private"; }
				if ((lblLastHost1.Text != "169") || (lblLastHost2.Text != "254")) { lbl_last.Text = "Public"; } else { lbl_last.Text = "Private"; }
				if ((lblBC_IP1.Text != "169") || (lblBC_IP2.Text != "254")) { lbl_broadcast.Text = "Public"; } else { lbl_broadcast.Text = "Private"; }
			}
			//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

			//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			else if ((firstDigitTXT.Text == "192") && (secondDigitTXT.Text == "168"))
			{
				if ((lblFirstHost1.Text != "192") || (lblFirstHost2.Text != "168")) { lbl_first.Text = "Public"; } else { lbl_first.Text = "Private"; }
				if ((lblLastHost1.Text != "192") || (lblLastHost2.Text != "168")) { lbl_last.Text = "Public"; } else { lbl_last.Text = "Private"; }
				if ((lblBC_IP1.Text != "192") || (lblBC_IP2.Text != "168")) { lbl_broadcast.Text = "Public"; } else { lbl_broadcast.Text = "Private"; }
			}
			//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

			else if ((firstDigitTXT.Text == "172") && (Convert.ToInt64(secondDigitTXT.Text) >= 16) && (Convert.ToInt64(secondDigitTXT.Text) <= 31))
			{
				if ((lblFirstHost1.Text != "172") || (Convert.ToInt64(lblFirstHost2.Text) < 16) || (Convert.ToInt64(lblFirstHost2.Text) > 31)) { lbl_first.Text = "Public"; } else { lbl_first.Text = "Private"; }
				if ((lblLastHost1.Text != "172") || (Convert.ToInt64(lblLastHost2.Text) < 16) || (Convert.ToInt64(lblLastHost2.Text) > 31)) { lbl_last.Text = "Public"; } else { lbl_last.Text = "Private"; }
				if ((lblBC_IP1.Text != "172") || (Convert.ToInt64(lblBC_IP2.Text) < 16) || (Convert.ToInt64(lblBC_IP2.Text) > 31)) { lbl_broadcast.Text = "Public"; } else { lbl_broadcast.Text = "Private"; }
			}
			//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

			//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

			else if (firstDigitTXT.Text == "127")
			{
				lblFirstDigtZero.Text = "LOOPBACK";
				if (lblFirstHost1.Text != "127") { lbl_first.Text = "Public"; } else { lbl_first.Text = "Private"; }
				if (lblLastHost1.Text != "127") { lbl_last.Text = "Public"; } else { lbl_last.Text = "Private"; }
				if (lblBC_IP1.Text != "127") { lbl_broadcast.Text = "Public"; } else { lbl_broadcast.Text = "Private"; }
			}

			//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			///
			else
			{
				
					lbl_first.Text = "Public";
					lbl_last.Text = "Public";
					lbl_broadcast.Text = "Public";
				
			}

			if ((firstDigitTXT.Text == "0") || (lblFirstHost1.Text == "0"))
			{
				lblFirstDigtZero.Text = "Not Applicable!";
				lblFirstDigtZero.BackColor = Color.Red;
			}
			else
			{
				lblFirstDigtZero.Text = "";
				lblFirstDigtZero.BackColor = Color.Empty;
			}

			if (firstDigitTXT.Text != lblFirstNetworkID.Text)
			{
				lblPublicPrivateIP.Text = "Not Private IP!";

			}
			else
			{
				lblPublicPrivateIP.Text = "Private IP";
			}


		}

       ///////////////////////////////////////////////////////////////////////



		void MainFormLoad(object sender, EventArgs e)
		{

			///////////////// IPv4 /////////////////////////

			cmbMaskBit.Items.AddRange(new object[] {"32","31","30","29","28","27","26","25","24","23","22","21","20","19","18","17","16","15","14","13","12","11","10","9","8","7","6","5","4","3","2","1"});
			cmbNetMaskDigit1.Items.AddRange(new object[] {"255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","254","252","248","240","224","192","128"});
			cmbNetMaskDigit2.Items.AddRange(new object[] {"255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","255","254","252","248","240","224","192","128","0","0","0","0","0","0","0","0"});
			cmbNetMaskDigit3.Items.AddRange(new object[] {"255","255","255","255","255","255","255","255","255","254","252","248","240","224","192","128","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"});
			cmbNetMaskDigit4.Items.AddRange(new object[] {"255","254","252","248","240","224","192","128","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"});

			//Default values
			//firstDigitTXT.Text="1";
			//secondDigitTXT.Text="1";
			//thirdDigitTXT.Text="1";
			//fourthDigitTXT.Text="1";
			//cmbMaskBit.SelectedIndex=2; //32-2=30 --> /30 

			ToolStripMenuItem2Click(sender,e);   // Load 192.168.0.0/16 


			///////////////// IPv6 /////////////////////////


			for (int i = 128; i >= 1; i--)
			{
				string a = i.ToString();
				cmb_IPv6MaskBit.Items.Add(a);
			}

			cmb_IPv6MaskBit.SelectedIndex = 0;



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
		
				
		void CmbMaskBitTextChanged(object sender, EventArgs e)
		{
			
				if(!string.IsNullOrWhiteSpace(cmbMaskBit.Text))
				{

							int mask = Convert.ToInt32(cmbMaskBit.Text);
			
							if (mask > 0 && mask < 33)
								{
									int index=32-mask;
									cmbMaskBit.SelectedIndex=index;
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
        		
//        		for(int i=0;i<s.Length;i++)
//        		{
//        			if(int.TryParse(s, out i))
//        			{

               		 int value = Convert.ToInt32(s);
               		 
                	 if ((value >= 0) && (value <= 255))
               			 {

                   			 cmbMaskBitSelectedIndexChanged(sender, e);
                		 }

                	else
               			 {
                			string textboxText=((TextBox)sender).Text;
                			int textboxLength=((TextBox)sender).TextLength;
                			((TextBox)sender).Text=textboxText.Substring(0, textboxLength-1);;
                  		    MessageBox.Show("Please enter a number between 0 and 255!");
             		     }
//        			}
//        			else
//        				return;
//        		}

            }

        }


		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
				Application.Exit();
		}
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
				 var frm = new about();
            	 frm.ShowDialog();
		}
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab = tabIPv4;
			firstDigitTXT.Text="192";
			secondDigitTXT.Text="168";
			thirdDigitTXT.Text="0";
			fourthDigitTXT.Text="0";
			cmbMaskBit.SelectedIndex=16; //32-16=16 --> /16 
			
		}
		void ToolStripMenuItem3Click(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab = tabIPv4;
			firstDigitTXT.Text="172";
			secondDigitTXT.Text="16";
			thirdDigitTXT.Text="0";
			fourthDigitTXT.Text="0";
			cmbMaskBit.SelectedIndex=20; //32-20=12 --> /12 
			
		}
		void ToolStripMenuItem4Click(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab = tabIPv4;
			firstDigitTXT.Text="10";
			secondDigitTXT.Text="0";
			thirdDigitTXT.Text="0";
			fourthDigitTXT.Text="0";
			cmbMaskBit.SelectedIndex=24; //32-24=8 --> /8 
			
		}
		void ToolStripMenuItem5Click(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab = tabIPv4;
			firstDigitTXT.Text="127";
			secondDigitTXT.Text="0";
			thirdDigitTXT.Text="0";
			fourthDigitTXT.Text="0";
			cmbMaskBit.SelectedIndex=24; //32-24=8 --> /8 
		}
		void XXToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab = tabIPv4;
			firstDigitTXT.Text="169";
			secondDigitTXT.Text="254";
			thirdDigitTXT.Text="0";
			fourthDigitTXT.Text="0";
			cmbMaskBit.SelectedIndex=16; //32-16=16 --> /16 
		}


		void changeMasktool(object sender,EventArgs e)
		{
			this.tabControl1.SelectedTab = tabIPv4;
			string tool_number_string = (((ToolStripMenuItem)sender).Name).Substring(8, 2);
		   
			cmbMaskBit.SelectedIndex=32-Convert.ToInt32(tool_number_string);
		}
		
		
		void onlyInteger(object sender, KeyPressEventArgs e)
		{
			this.tabControl1.SelectedTab = tabIPv4;

			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				{
   					 e.Handled = true;
				}
		}
		
		
		
		void noempty(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab = tabIPv4;

			string textboxText =((TextBox)sender).Text;
			if(textboxText=="")
			{
				((TextBox)sender).Text="0";
			}
		}
		void CmbMaskBitLeave(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab = tabIPv4;

			if (string.IsNullOrWhiteSpace(cmbMaskBit.Text))
			{
                cmbMaskBit.SelectedIndex=8;  // if it is empity then make it /24
            }
		}

        private void divideNetwork_Click(object sender, EventArgs e)             ///// by Number of Networks
        {
			//if(cmbMaskBit.Text=="1")
			//{
			//	lbl_number_of_networks.Text = "Please change the network mask!";
			//	return;
			//}
            String network_size_string = txtNumberOfNetwork.Text;
            double number_of_available_ips = Convert.ToDouble(lblHostNumber.Text) + 2;
            double network_size;
            double number_of_network;

            if ((!string.IsNullOrWhiteSpace(network_size_string)) && (txtNumberOfNetwork.Text != "1"))
            {
                network_size = Convert.ToDouble(network_size_string);

                double i, k = 1;
                for (i = 1; ; i++)
                {
                    k *= 2;
                    if (k >= network_size)
                        break;
                }


				

				network_size = k; //new network size
                number_of_network = number_of_available_ips / network_size;


				double j;  ///how many time divided by 2
				k = 1;
				for (j = 1; ; j++)
				{
					k *= 2;
					if (k >= number_of_network)
					{ break; }
				}

				double new_MaskBit = i + Convert.ToDouble(cmbMaskBit.Text);
                if (new_MaskBit <= 30)
                {
					
					lbl_number_of_networks.Text= "Number of Networks = " + network_size.ToString() + " = 2^" + i.ToString() + " >= " + txtNumberOfNetwork.Text.ToString() +  "\n\nNew Mask for each network = /(" + lblMaskBit.Text.ToString() + "+" + i.ToString() + ") = /" + new_MaskBit.ToString() + "\n\nSize of Networks = " + " 2^" + lblHostbit.Text.ToString() + " / 2^" + i.ToString() + " = "  + " 2^" + j.ToString() + " = " + number_of_network.ToString();

				}
				else if ((new_MaskBit==31)||(new_MaskBit == 32))
                {
                    lbl_number_of_networks.Text = "Number of Networks = 0\n\nNew Mask for each IP = /" + new_MaskBit.ToString();
                }
                else
                {
                    lbl_number_of_networks.Text = "Please enter a number less than " + Convert.ToString(number_of_available_ips + 1) + "\nNumber of Available IPs = " + Convert.ToString(number_of_available_ips);
                    txtNumberOfNetwork.Text = Convert.ToString(number_of_available_ips);
                }

            }
            else
            {
                lbl_number_of_networks.Text="Please enter greater than 1";
                txtNumberOfNetwork.Text = "2";
            }
        }
         



        private void divideNetwork2_Click(object sender, EventArgs e)  ///// by Size of Networks
        {
			//if (cmbMaskBit.Text == "1")
			//{
			//	lbl_number_of_networks.Text = "Please change the network mask!";
			//	return;
			//}

			double network_size= Convert.ToDouble(txtSizeOfNetwork.Text);
            double number_of_network;

			double number_of_available_ips = Convert.ToDouble(lblHostNumber.Text) + 2;


            if(network_size<4)
            {
                txtSizeOfNetwork.Text = "4";
                MessageBox.Show("The Smallest Network cannot have less than 4 IPs\nOne IP for Network ID\nOne IP for Broadcast\nTwo for Hosts");
                network_size = 4;
            }

			if ((!string.IsNullOrWhiteSpace(txtSizeOfNetwork.Text)) && (Convert.ToDouble(txtSizeOfNetwork.Text) >= 4))
			{

				double i, k = 1;
				for (i = 1; ; i++)
				{
					k *= 2;
					if (k >= network_size)
					{ break; }
				}

				network_size = Convert.ToDouble(Math.Pow(2, i));   /// new network size 2^i
				number_of_network = (number_of_available_ips / network_size);

				//MessageBox.Show(Convert.ToString(Math.Pow(2,i)));


				double j;  ///how many time divided by 2
				k = 1;
				for (j = 1; ; j++)
				{
					k *= 2;
					if (k >= number_of_network)
					{ break; }
				}

				/////////////
				double new_MaskBit = Convert.ToDouble(cmbMaskBit.Text);
				if (number_of_network > 1)
				{
					new_MaskBit += j;
				}  /// new mask
				///////////////////

				if (new_MaskBit <= 30)
				{
					if (Convert.ToInt32(lblHostbit.Text) > i)
					{
						lbl_number_of_networks.Text = "Size of Networks = " + network_size.ToString() + " =  2^" + i.ToString() + " >= " + txtSizeOfNetwork.Text.ToString() + "\n\nNumber of Networks = 2^" + lblHostbit.Text.ToString() + " / 2^" + i.ToString() + " = 2^" + j.ToString() + " = " + (number_of_network).ToString() + "\n\nNew Mask for each network = /(" + lblMaskBit.Text.ToString() + "+" + j.ToString() + ") = /" + new_MaskBit.ToString();
					}
					else if (Convert.ToInt32(lblHostbit.Text) == i)
					{
						lbl_number_of_networks.Text = "Size of Networks = " + network_size.ToString() + " =  2^" + i.ToString() + " >= " + txtSizeOfNetwork.Text.ToString() + "\n\nNumber of Networks = 2^" + lblHostbit.Text.ToString() + " / 2^" + i.ToString() + " = 2^0" + " = " + (number_of_network).ToString() + "\n\nNew Mask for each network = /(" + lblMaskBit.Text.ToString() + "+ 0 ) = /" + new_MaskBit.ToString();

					}
					else // (Convert.ToInt32(lblHostbit.Text) < i)
					{
						lbl_number_of_networks.Text = "Please enter a smaller value than " + Convert.ToString(Convert.ToInt32(lblHostNumber.Text) + 3);
					}
				}
				else if ((new_MaskBit == 31) || (new_MaskBit == 32))
				{
					lbl_number_of_networks.Text = "Number of Networks = 0\n\nNew Mask for each IP = /" + new_MaskBit.ToString();
				}
				else
				{
					lbl_number_of_networks.Text = "Please enter a number less than " + Convert.ToString(number_of_available_ips + 1) + "\nNumber of Available IPs = " + Convert.ToString(number_of_available_ips);
					txtNumberOfNetwork.Text = Convert.ToString(number_of_available_ips);
				}

            }
            else
            {
                lbl_number_of_networks.Text = "Please enter greater than 1";
                txtNumberOfNetwork.Text = "2";
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
			this.tabControl1.SelectedTab = tabIPv4;

			firstDigitTXT.Text = "224";
			secondDigitTXT.Text = "0";
			thirdDigitTXT.Text = "0";
			fourthDigitTXT.Text = "0";
			cmbMaskBit.SelectedIndex = 28; //32-16=16 --> /16 
		}

        private void classEToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.tabControl1.SelectedTab = tabIPv4;

			firstDigitTXT.Text = "240";
			secondDigitTXT.Text = "0";
			thirdDigitTXT.Text = "0";
			fourthDigitTXT.Text = "0";
			cmbMaskBit.SelectedIndex = 28; //32-16=16 --> /16 
		}

        private void unspecifiedAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.tabControl1.SelectedTab = tabIPv6;
			txtIPv6_1Block.Text = "0000";
			txtIPv6_2Block.Text = "0000";
			txtIPv6_3Block.Text = "0000";
			txtIPv6_4Block.Text = "0000";
			txtIPv6_5Block.Text = "0000";
			txtIPv6_6Block.Text = "0000";
			txtIPv6_7Block.Text = "0000";
			txtIPv6_8Block.Text = "0000";

			cmb_IPv6MaskBit.SelectedIndex = 0;  //    128-0 --> /128

		}

        private void loopbackAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.tabControl1.SelectedTab = tabIPv6;
			txtIPv6_1Block.Text = "0000";
			txtIPv6_2Block.Text = "0000";
			txtIPv6_3Block.Text = "0000";
			txtIPv6_4Block.Text = "0000";
			txtIPv6_5Block.Text = "0000";
			txtIPv6_6Block.Text = "0000";
			txtIPv6_7Block.Text = "0000";
			txtIPv6_8Block.Text = "0001";

			cmb_IPv6MaskBit.SelectedIndex = 0;   //    128-0 --> /128
		}

        private void globalUnicastAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.tabControl1.SelectedTab = tabIPv6;
			txtIPv6_1Block.Text = "2001";
			txtIPv6_2Block.Text = "0000";
			txtIPv6_3Block.Text = "0000";
			txtIPv6_4Block.Text = "0000";
			txtIPv6_5Block.Text = "0000";
			txtIPv6_6Block.Text = "0000";
			txtIPv6_7Block.Text = "0000";
			txtIPv6_8Block.Text = "0000";

			cmb_IPv6MaskBit.SelectedIndex = 125;  //    128-125 --> /3
		}

        private void uniqueLocalUncastAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.tabControl1.SelectedTab = tabIPv6;
			txtIPv6_1Block.Text = "FC00";
			txtIPv6_2Block.Text = "0000";
			txtIPv6_3Block.Text = "0000";
			txtIPv6_4Block.Text = "0000";
			txtIPv6_5Block.Text = "0000";
			txtIPv6_6Block.Text = "0000";
			txtIPv6_7Block.Text = "0000";
			txtIPv6_8Block.Text = "0000";

			cmb_IPv6MaskBit.SelectedIndex = 121;   // 128-121--> /7
		}

        private void linkLocalUnicastAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.tabControl1.SelectedTab = tabIPv6;
			txtIPv6_1Block.Text = "FE80";
			txtIPv6_2Block.Text = "0000";
			txtIPv6_3Block.Text = "0000";
			txtIPv6_4Block.Text = "0000";
			txtIPv6_5Block.Text = "0000";
			txtIPv6_6Block.Text = "0000";
			txtIPv6_7Block.Text = "0000";
			txtIPv6_8Block.Text = "0000";

			cmb_IPv6MaskBit.SelectedIndex = 118;   // 128-118--> /10
		}
    }
}
