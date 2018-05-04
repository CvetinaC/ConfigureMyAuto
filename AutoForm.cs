using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigureMyAuto
{
    public partial class AutoForm : Form
    {
        int sumAudi = 139000;
        int sumChevrolet = 47000;
        int sumRover = 58000;
        int discount = 0;
        public AutoForm()
        {
            InitializeComponent();
            BeforeChange();
        }
        void BeforeChange()
        {
            rbCash.Checked = false;
            rbCreditCard.Checked = false;
            rbCheque.Checked = false;
            cbAbs.Checked = false;
            cbChains.Checked = false;
            cbFog.Checked = false;
            lblPriceOfAuto.Text = "0 лв";
            lblTotalPrice.Text = "0 лв";
            lblDiscountAuto.Text = "0 %";
            sumAudi = 139000;
            sumChevrolet = 47000;
            sumRover = 58000;
            discount = 0;
        }

        private void cbAbs_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAbs.Checked && cbChains.Checked && cbFog.Checked)
            {
                discount += 10;
                lblDiscountAuto.Text = discount.ToString() + "%";
            }
            else
            {
                if (rbCash.Checked)
                {
                    discount = 5;
                    lblDiscountAuto.Text = discount.ToString() + "%";
                }
                else
                {
                    discount = 0;
                    lblDiscountAuto.Text = discount.ToString() + "%";
                }
            }
            if (rbAudi.Checked)
            {
                if(cbAbs.Checked==false)
                {
                    sumAudi -= 2500;
                    lblPriceOfAuto.Text = sumAudi.ToString() + "лв";
                }
                else
                {
                    sumAudi+=2500;
                    lblPriceOfAuto.Text = sumAudi.ToString() + "лв";
                }
            }
            if(rbRover.Checked)
            {
                if(cbAbs.Checked==false)
                {
                    sumRover -= 4000;
                    lblPriceOfAuto.Text = sumRover.ToString() + "лв";
                }
                else
                {
                    sumRover += 4000;
                    lblPriceOfAuto.Text = sumRover.ToString() + "лв";
                }
            }
            if(rbChevrolet.Checked)
            {
                if(cbAbs.Checked==false)
                {
                    sumChevrolet -= 2000;
                    lblPriceOfAuto.Text = sumChevrolet.ToString() + "лв";
                }
                else
                {
                    sumChevrolet += 2000;
                    lblPriceOfAuto.Text = sumChevrolet.ToString() + "лв";
                }
            }
        }

        private void cbFog_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAbs.Checked && cbChains.Checked && cbFog.Checked)
            {
                discount += 10;
                lblDiscountAuto.Text = discount.ToString() + "%";
            }
            else
            {
                if (rbCash.Checked)
                {
                    discount = 5;
                    lblDiscountAuto.Text = discount.ToString() + "%";
                }
                else
                {
                    discount = 0;
                    lblDiscountAuto.Text = discount.ToString() + "%";
                }
            }
            if (rbAudi.Checked)
            {
                if (cbFog.Checked == false)
                {
                    sumAudi -=1500;
                    lblPriceOfAuto.Text = sumAudi.ToString() + "лв";
                }
                else
                {
                    sumAudi += 1500;
                    lblPriceOfAuto.Text = sumAudi.ToString() + "лв";
                }
            }
            if (rbRover.Checked)
            {
                if (cbFog.Checked == false)
                {
                    sumRover -= 3500;
                    lblPriceOfAuto.Text = sumRover.ToString() + "лв";
                }
                else
                {
                    sumRover += 3500;
                    lblPriceOfAuto.Text = sumRover.ToString() + "лв";
                }
            }
            if (rbChevrolet.Checked)
            {
                if (cbFog.Checked == false)
                {
                    sumChevrolet -=1800;
                    lblPriceOfAuto.Text = sumChevrolet.ToString() + "лв";
                }
                else
                {
                    sumChevrolet += 1800;
                    lblPriceOfAuto.Text = sumChevrolet.ToString() + "лв";
                }
            }
        }

        private void cbChains_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAbs.Checked && cbChains.Checked && cbFog.Checked)
            {
                discount += 10;
                lblDiscountAuto.Text = discount.ToString() + "%";
            }
            else
            {
                if (rbCash.Checked)
                {
                    discount = 5;
                    lblDiscountAuto.Text = discount.ToString() + "%";
                }
                else
                {
                    discount = 0;
                    lblDiscountAuto.Text = discount.ToString() + "%";
                }
                if (rbAudi.Checked)
                {
                    if (cbChains.Checked == false)
                    {
                        sumAudi -= 500;
                        lblPriceOfAuto.Text = sumAudi.ToString() + "лв";
                    }
                    else
                    {
                        sumAudi += 500;
                        lblPriceOfAuto.Text = sumAudi.ToString() + "лв";
                    }
                }
                if (rbRover.Checked)
                {
                    if (cbAbs.Checked == false)
                    {
                        sumRover -= 800;
                        lblPriceOfAuto.Text = sumRover.ToString() + "лв";
                    }
                    else
                    {
                        sumRover += 800;
                        lblPriceOfAuto.Text = sumRover.ToString() + "лв";
                    }
                }
                if (rbChevrolet.Checked)
                {
                    if (cbAbs.Checked == false)
                    {
                        sumChevrolet -= 1000;
                        lblPriceOfAuto.Text = sumChevrolet.ToString() + "лв";
                    }
                    else
                    {
                        sumChevrolet += 1000;
                        lblPriceOfAuto.Text = sumChevrolet.ToString() + "лв";
                    }
                }

            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbAudi.Checked)
            {
                if (discount==0)
                {
                    lblTotalPrice.Text = sumAudi.ToString() + "лв";
                }
                else
                {
                    lblTotalPrice.Text = (sumAudi - ((discount * sumAudi) / 100)).ToString() + "лв";
                }
            }
            if(rbChevrolet.Checked)
            {
                if (discount == 0)
                {
                    lblTotalPrice.Text = sumChevrolet.ToString() + "лв";
                }
                else
                {
                    lblTotalPrice.Text = (sumChevrolet - ((discount * sumChevrolet) / 100)).ToString() + "лв";
                }
            }
            if(rbRover.Checked)
            {
                if (discount == 0)
                {
                    lblTotalPrice.Text = sumRover.ToString() + "лв";
                }
                else
                {
                    lblTotalPrice.Text = (sumRover - ((discount * sumRover) / 100)).ToString() + "лв";
                }
            }
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCash.Checked==true)
            {
                discount += 5;
                lblDiscountAuto.Text = discount.ToString() + "%";
            }
            else
            {
                discount -= 5;
                lblDiscountAuto.Text = discount.ToString() + "%";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rbAudi.Checked = false;
            rbCheque.Checked = false;
            rbRover.Checked = false;
            rbCash.Checked = false;
            rbCreditCard.Checked = false;
            rbCheque.Checked = false;
            cbAbs.Checked = false;
            cbChains.Checked = false;
            cbFog.Checked = false;
            pbAuto.Image = null;
            lblPriceOfAuto.Text = "0 лв";
            lblTotalPrice.Text = "0 лв";
            lblDiscountAuto.Text = "0 %";
            sumAudi = 139000;
            sumChevrolet = 47000;
            sumRover = 58000;
            discount = 0;
        }

        private void AutoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close the form ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void rbChevrolet_CheckedChanged(object sender, EventArgs e)
        {
            BeforeChange();
            pbAuto.Image = Properties.Resources._2017_chevrolet_camaro_zl1_2560x1440;
            lblPriceOfAuto.Text = sumChevrolet.ToString() + " лв"; 
        }

        private void rbRover_CheckedChanged(object sender, EventArgs e)
        {
            BeforeChange();
            pbAuto.Image = Properties.Resources.land_rover_range_rover_vogue_white_side_view_108581_3840x2400;
            lblPriceOfAuto.Text = sumRover.ToString() + " лв";
        }

        private void rbAudi_CheckedChanged(object sender, EventArgs e)
        {
            BeforeChange();
            pbAuto.Image = Properties.Resources._479373;
            lblPriceOfAuto.Text = sumAudi.ToString() + " лв";
        }
    }
}
