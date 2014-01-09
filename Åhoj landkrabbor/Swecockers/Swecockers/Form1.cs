using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swecockers
{
    public partial class Form1 : Form
    {
        LTSTDataContext db = new LTSTDataContext();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BandDGV.DataSource = BandBS;
            BandBS.DataSource = from data in db.Bands
                                select data;
            //  MessageBox.Show(db.Connection.Database);
        }

        private void bandAddBtn_Click(object sender, EventArgs e)
        {
            Band b = new Band();

            try
            {

                b.Band_Name = bandNameTbx.Text;
                b.Members = int.Parse(bandCountTbx.Text);
                b.From_Location = UrsprungTbx.Text;
                b.Info = bandInfoTbx.Text;
                b.Startyear = bandStartYearTbx.Text;

                db.Bands.InsertOnSubmit(b);
                db.SubmitChanges();

                BandBS.DataSource = from data in db.Bands
                                    orderby data.Band_Name
                                    select data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BandRemoveBtn_Click(object sender, EventArgs e)
        {

            if (BandDGV.SelectedRows.Count == 1)
            {
                int selected_id = (int)BandDGV.SelectedRows[0].Cells[0].Value;

                Band b = db.Bands.Single(band => band.Band_ID == selected_id);

                db.Bands.DeleteOnSubmit(b);
                db.SubmitChanges();

                BandBS.DataSource = from data in db.Bands
                                    select data;

            }
        }
        int changeState = 0;
        int tempID;
        private void bandChangeBtn_Click(object sender, EventArgs e)
        {
            if (changeState == 0)
            {

                if (BandDGV.SelectedRows.Count == 1)
                {
                    int selected_id = (int)BandDGV.SelectedRows[0].Cells[0].Value;

                    Band b = db.Bands.Single(band => band.Band_ID == selected_id);


                    tempID = b.Band_ID;
                    bandNameTbx.Text = b.Band_Name;
                    bandInfoTbx.Text = b.Info;
                    bandCountTbx.Text = b.Members.ToString();
                    bandStartYearTbx.Text = b.Startyear;

                    changeState = 1;

                }


            }
            else
            {
                try
                {
                    Band b = db.Bands.Single(band => band.Band_ID == tempID);
                    b.Band_Name = bandNameTbx.Text;
                    b.Info = bandInfoTbx.Text;
                    b.Members = int.Parse(bandCountTbx.Text);
                    b.Startyear = bandStartYearTbx.Text;

                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                changeState = 0;


                }




            }

            private void bandSrchBtn_Click(object sender, EventArgs e)
           {
                if (bandSrchTbx.Text.Trim().Length > 0)
                {
                    string srchWord = bandSrchTbx.Text.Trim().ToLower();

                    var srchResult = from result in db.Bands
                                     where result.Band_ID.ToString().Contains(srchWord)
                                     || result.Band_Name.ToLower().Contains(srchWord)
                                     || result.From_Location.ToLower().Contains(srchWord)
                                     || result.Info.ToLower().Contains(srchWord)
                                     || result.Members.ToString().Contains(srchWord)
                                     || result.Startyear.Contains(srchWord)
                                     orderby result.Band_Name
                                     select result;

                    BandBS.DataSource = srchResult;
                }
                else
                {
                    BandBS.DataSource = from data in db.Bands
                                        orderby data.Band_Name
                                        select data;
                
                
                }


             }





           }

        }


    
