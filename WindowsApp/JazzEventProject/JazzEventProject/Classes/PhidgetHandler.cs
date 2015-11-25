using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidgets;
using Phidgets.Events;
using System.Windows.Forms;

namespace JazzEventProject.Classes
{
    class PhidgetHandler
    {
        //instance variables
        public RFID myRFIDReader;
        public String RFIDno;

        //constructor
        /// <summary>
        /// This is the constructor for this class and creates an RFIDHandler object that has mainly two methods that must be
        /// used in the forms. Both methods must be used ie. the Phidget must be opened and closed. 
        /// </summary>
        public PhidgetHandler()
        {
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(ShowWhoIsAttached);
                myRFIDReader.Detach += new DetachEventHandler(ShowWhoIsDetached);
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);
            }
            catch (PhidgetException) { MessageBox.Show("error at start-up."); }
        }

        public void OpenRFIDReader()
        {
            try
            {
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                MessageBox.Show("an RFID-reader is found and opened.");
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;
            }
            catch (PhidgetException) { MessageBox.Show("no RFID-reader opened."); }
        }

        public void CloseRFIDReader()
        {
            myRFIDReader.LED = false;
            myRFIDReader.Antenna = false;
            myRFIDReader.close();
            MessageBox.Show("RFID scanner has been closed.");
        }

        //methods

        public String ReadTag(object sender, TagEventArgs e)
        {
            ProcessThisTag(sender, e);
            this.RFIDno=e.Tag.ToString();
            return RFIDno;
        }

        private void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            MessageBox.Show("RFIDReader attached!, serial nr: " + e.Device.SerialNumber.ToString());
        }

        private void ShowWhoIsDetached(object sender, DetachEventArgs e)
        {
            MessageBox.Show("RFIDReader detached!, serial nr: " + e.Device.SerialNumber.ToString());
        }

        public void ProcessThisTag(object sender, TagEventArgs e)
        {
            MessageBox.Show("rfid has tag-nr: " + e.Tag);
        }

        public void SayHello(object sender, TagEventArgs e)
        {
            MessageBox.Show("Hello visitor with rfid-nr " + e.Tag +
                ".\nWelcome at our event ! ! !");
        }

        private void btnAddAnother_Click(object sender, EventArgs e)
        {
            this.myRFIDReader.Tag += new TagEventHandler(SayHello);
        }

        private void btnRemoveAnother_Click(object sender, EventArgs e)
        {
            this.myRFIDReader.Tag -= new TagEventHandler(SayHello);
        }
    }
}
