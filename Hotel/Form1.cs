using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form   // part of class
    {
        public delegate void Delegate(); //delegate
        public event Delegate DisabledBtn;

        public Form1()
        {
            InitializeComponent();
            DisabledBtn += btnBookEnabled;
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime from = dataFrom.Value;
                DateTime to = dataTo.Value;
                if ((to - from).TotalDays + 1 <= 0 || (to - DateTime.Now).TotalDays + 1 <= 0 || (from - DateTime.Now).TotalDays + 1 <= 0)
                    // check if date is real
                    throw new InvalidDateException();
                else
                { //if date is real
                    IRoomTable roomTable = new TableRoom();
                    LbNumbers.DataSource = roomTable.GetAvailableRoomsByPeriodAndType(from, to, ((ClassRoom)cbClasses.SelectedItem).RoomClass);
                    // show available rooms (their numbers) in listbox
                    if (LbNumbers.Items.Count == 0) //if no rooms are available
                        Lmoney.Text = "";
                    else
                    { //if at least one room is available
                        btnBook.Enabled = true;
                        double money = ((ClassRoom)cbClasses.SelectedItem).Money;
                        Lmoney.Text = "You should pay $ " + Math.Round(((to - from).TotalDays + 1) * money, 1); //write needed money
                    }
                }
            }
            catch (InvalidDateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TableClassRoom classRoomTable = new TableClassRoom();             
            cbClasses.DataSource = classRoomTable.ReadAll();     //read all rows from db
            Lmoney.Text = "";
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            TableClient classClientTable = new TableClient();
            DateTime from = dataFrom.Value;  //date come here
            DateTime to = dataTo.Value;      //date go away
            int roomID = ((Room)LbNumbers.SelectedItem).ID;  //room ID
            Client client = new Client
            {
                RoomID = roomID,    
                DataFrom = from,
                DataTo = to
            };
            if (classClientTable.Add(client))        //add RoomID, DataFrom, DataTo to our table ("clients")
                MessageBox.Show("IT`S BOOKED");
            else
                MessageBox.Show("IT`S NOT BOOKED. TRY AGAIN");
            DisabledBtn.Invoke();       
        }
        

        private void dataFrom_ValueChanged(object sender, EventArgs e)
        {
            DisabledBtn.Invoke();
        }

        private void dataTo_ValueChanged(object sender, EventArgs e)
        {
            DisabledBtn.Invoke();
        }

        private void btnBookEnabled()
        {
            btnBook.Enabled = false;
        }
    }
}
