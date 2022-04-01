using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Hospital_Charges
{
    public partial class HospitalCharges : Form
    {

        public HospitalCharges()
        {
            InitializeComponent();
            daysTextBox.Focus();
        }


        private void calcCharges()
        { try
            {
                daysTextBox.Focus();
                decimal days, meds, surgical, lab, rehab;


                if (decimal.TryParse(daysTextBox.Text, out days) && days >= 0)
                {
                    //days is valid

                    if (decimal.TryParse(medChargesTextBox.Text, out meds) && meds >= 0)
                    {
                        // medCharges is valid

                        if (decimal.TryParse(surgicalChargesTextBox.Text, out surgical) && surgical >= 0)
                        {
                            // surgical charges is valid
                            if (decimal.TryParse(labFeesTextBox.Text, out lab) && lab >= 0)
                            {
                                // lab charges is valid

                                if (decimal.TryParse(rehabFeeTextBox.Text, out rehab) && rehab >= 0)
                                {
                                    //rehab is valid
                                }
                                else
                                {
                                    //rehab is invalid
                                    MessageBox.Show("Phycial rehabilitation charges are invalid. Please enter a valid number or 0 if no charge");
                                    rehabFeeTextBox.Focus();
                                    rehabFeeTextBox.SelectAll();
                                    return;
                                }
                            }
                            else
                            {
                                //lab charges is invalid
                                MessageBox.Show("Lab fees are invalid. Please enter a valid number or 0 if no charge");
                                labFeesTextBox.Focus();
                                labFeesTextBox.SelectAll();
                                return;
                            }
                        }
                        else
                        {
                            // surgical charges is invalid
                            MessageBox.Show("Surgical charges are invalid. Please enter a valid number or 0 if no charge");
                            surgicalChargesTextBox.Focus();
                            surgicalChargesTextBox.SelectAll();
                            return;
                        }
                    }
                    else
                    {
                        // medCharges is invalid
                        MessageBox.Show("Medication charges are invalid. Please enter a valid number or 0 if no charge");
                        medChargesTextBox.Focus();
                        medChargesTextBox.SelectAll();
                        return;
                    }

                }

                else
                {
                    //days is invalid
                    MessageBox.Show("Length of stay (days) is invalid. Please enter a valid number or 0 if not admitted");
                    daysTextBox.Focus();
                    daysTextBox.SelectAll();
                    return;
                }

                decimal calcStayCharges, calcMiscCharges, calcTotalCharges;
                string myMessage = "";
                calcStayCharges = days * 350;
                stayChargesOutputLabel.Text = calcStayCharges.ToString("c2");

                calcMiscCharges = meds + surgical + lab + rehab;
                miscChargesOutputLabel.Text = calcMiscCharges.ToString("c2");
                calcTotalCharges = calcStayCharges + calcMiscCharges;
                totalChargesOutputLabel.Text = calcTotalCharges.ToString("c2");

                myMessage = dateTimePicker2.Value.ToString() + " The Stay charges of " + calcStayCharges.ToString("c") + ", plus Misc charges of "
                    + calcMiscCharges.ToString("c") + ", equals a grand total of " + calcTotalCharges.ToString("c");
                writeFile(myMessage);

            }// End Try block

            // Begin Catch block
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } // End catch
            
        }


        private void writeFile(string myMess)
        {
            StreamWriter outputFile;
            string myFileName = "";

            saveFileDialog.Filter = "txt file|*.txt|All files|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                myFileName = saveFileDialog.FileName;

                outputFile = File.AppendText(myFileName);
                outputFile.WriteLine(myMess + "\n");

                outputFile.Close();
            }
        }
    
        private void resetForm()
        { // Resets the form and adjusts focus 
            daysTextBox.Text = "";
            medChargesTextBox.Text = "";
            surgicalChargesTextBox.Text = "";
            labFeesTextBox.Text = "";
            rehabFeeTextBox.Text = "";
            stayChargesOutputLabel.Text = "";
            miscChargesOutputLabel.Text = "";
            totalChargesOutputLabel.Text = "";
            daysTextBox.Focus();


        }
        private void exitButton_Click(object sender, EventArgs e)
        { //Closes the form
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { //Closes the form
            Close();
        }

        private void clearFormToolStripMenuItem_Click(object sender, EventArgs e)
        { //Execute "resetForm" method
            resetForm();
        }

        private void clearFormButton_Click(object sender, EventArgs e)
        { //Execute "resetForm" method
            resetForm();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        { //Execute "calcCharges" method
            calcCharges();
            daysTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        { //Execute "calcCharges" method
            calcCharges();
            daysTextBox.Focus();
        }
    }
}