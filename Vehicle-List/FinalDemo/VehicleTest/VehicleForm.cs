using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleLibrary;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace VehicleTest
{
    public partial class VehicleForm : Form
    {
        public VehicleForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRightNew_Click(object sender, EventArgs e)
        {
            const string FileName = @"..\..\..\..\Vehicle.bin";
            
            SUV suv = new SUV("Honda CRV", "Blue", 2000, 170000, 5, 5000, 6000);
            Vehicle suv2 = (Vehicle)suv.Clone();
            Compact sedan = new Compact("Toyato Camry", "Green", 2011, 100, 5, 10000, 15000);
            Vehicle sedan2 = (Vehicle)sedan.Clone();
           




           
            Stream VehicleFileStream = File.Create(FileName);
            BinaryFormatter serializer = new BinaryFormatter();//overwrites
            var myVehicleList = new List<Vehicle> { suv, suv2, sedan, sedan2, };
           
            foreach (Vehicle v in myVehicleList)
            {
                serializer.Serialize(VehicleFileStream,v);
            }
            VehicleFileStream.Close();
        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            const string FileName = @"..\..\..\..\Vehicle.bin";
            var myVehicleListRead = new List<Vehicle>();

            if (File.Exists(FileName))
            {
                Stream TestFileStreamRead = File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                int count = 0;
                try
                {
                    while (true)
                    {
                        myVehicleListRead.Add((Vehicle)deserializer.Deserialize(TestFileStreamRead));
                        count++;
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show($"{count} vehicles read from file.");
                }
                finally
                {
                    TestFileStreamRead.Close();
                }

                var vehicleBindingList = new BindingList<Vehicle>(myVehicleListRead);
                var vehicleSource = new BindingSource(vehicleBindingList, null);
                VehicleGridView.DataSource = vehicleSource;
            }
        }

        private void Heading_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in VehicleGridView.Columns)
            {

                MessageBox.Show(column.HeaderText + " " + String.Concat("Column ",
                    column.Index.ToString()));
                if (column.HeaderText == "RetailPrice") 
                {

                }
            }
            
            int i = 0;
            foreach (DataGridViewRow row in VehicleGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //do operations with cell
                    i = cell.ColumnIndex;
                }
            }
        }
    }

    }
