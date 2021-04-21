using SimplePhotoDiary.Data_Access_Layer.Entities;
using SimplePhotoDiary.Service_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePhotoDiary.Presentation_Layer
{
    public partial class EventActions : Form
    {
        private int usingUserId;
        public EventActions(int userid)
        {
            InitializeComponent();
            this.usingUserId = userid;
        }

        private void EventActions1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EventActions_Load(object sender, EventArgs e)
        {
            EventDataService eventDataService = new EventDataService();
            eventListView.DataSource = eventDataService.GetEventList(this.usingUserId);
        }

        private void AEventB_Click(object sender, EventArgs e)
        {
            EventDataService eventDataService = new EventDataService();
            int result = eventDataService.AddEvent(EventNameBox.Text, ImportanceBox.Text, CreationDateBox.Text, usingUserId);
            if (result > 0)
            {
                MessageBox.Show("Event Added Succesfully!");
                eventListView.DataSource = eventDataService.GetEventList(this.usingUserId);
                EventNameBox.Text = ImportanceBox.Text = CreationDateBox.Text = null;
            }
            else
            {
                MessageBox.Show("Sorry There Was An Error!");
                eventListView.DataSource = eventDataService.GetEventList(this.usingUserId);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EventDataService eventDataService = new EventDataService();
            int result = eventDataService.UpdateEvent(Upd_EventName.Text ,Upd_Importance.Text, Convert.ToInt32(Upd_EventID.Text), usingUserId);
            if (result > 0)
            {
                MessageBox.Show("Event Updated Succesfully!");
                
                Upd_EventID.Text = Upd_EventName.Text = Upd_Importance.Text = null;
                eventListView.DataSource = eventDataService.GetEventList(this.usingUserId);
            }
            else
            {
                MessageBox.Show("Sorry There Was An Error!");
                Upd_EventID.Text = Upd_EventName.Text = Upd_Importance.Text = null;
                eventListView.DataSource = eventDataService.GetEventList(this.usingUserId);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventDataService eventDataService = new EventDataService();
            Event events = eventDataService.GetTheEvent(Convert.ToInt32(Upd_EventID.Text), usingUserId);
            if (events != null)
            {
                Upd_EventName.Text = events.EventName;
                Upd_Importance.Text = events.Importance;
            }
            else
            {
                MessageBox.Show("Invalid Event Id");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EventDataService eventDataService = new EventDataService();
            int result = eventDataService.DeleteEvent(Convert.ToInt32(Del_EventID.Text), usingUserId);
            if (result > 0)
            {
                MessageBox.Show("Event Deleted Succesfully!");
                eventListView.DataSource = eventDataService.GetEventList(this.usingUserId);

            }
            else
            {
                MessageBox.Show("Sorry There Was An Error!");
                
                eventListView.DataSource = eventDataService.GetEventList(this.usingUserId);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            EventDataService eventDataService = new EventDataService();
            Event events = eventDataService.GetTheEvent(Convert.ToInt32(GoEventID.Text), usingUserId);
            if (events != null)
            {
                this.Hide();
                ImageActions imageActions = new ImageActions(Convert.ToInt32(GoEventID.Text), usingUserId);
                imageActions.Show();
            }
            else
            {
                MessageBox.Show("Invalid Event Id");
                GoEventID.Text =  null;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void eventListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Upd_EventID.Text = eventListView.Rows[e.RowIndex].Cells[0].Value.ToString();
            GoEventID.Text = eventListView.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
