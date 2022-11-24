namespace TabbedMenuExample3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //point is a default datatype with x & y representing integers
            Point MainPoint = gbx_Tab1.Location;

            //gbx_Tab1 is in the correct position, so the other boxes are set to
            //the same position
            gbx_Tab2.Location = MainPoint;
            gbx_Tab3.Location = MainPoint;
            gbx_Tab4.Location = MainPoint;
        }

        private void btn_Tab_Click(object sender, EventArgs e)
        {
            Button BTN = (Button)sender;
            
            //sends all the buttons to the back except the first
            btn_Tab2.SendToBack();
            btn_Tab3.SendToBack();
            btn_Tab4.SendToBack();

            //brings the clicked button to the front
            BTN.BringToFront();

            //every button has a tag value that corresponds to it's groupbox
            //so btn_Tab1 has a tag of 1, btnTab2 has a tag of 2 etc.
            switch (Convert.ToInt16(BTN.Tag))
            {//these simply bring the corresponding gbx to the front
                case 1:
                    {
                        gbx_Tab1.BringToFront();
                        break;
                    }
                case 2:
                    {
                        gbx_Tab2.BringToFront();
                        break;
                    }
                case 3:
                    {
                        gbx_Tab3.BringToFront();
                        break;
                    }
                case 4:
                    {
                        gbx_Tab4.BringToFront();
                        break;
                    }
                default:
                    break;
            }
        }

        #region unimportant stuffs
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            nud_Progress.Value = 0;
            pbr_Movement.Value = 0;
        }

        private void nud_Progress_ValueChanged(object sender, EventArgs e)
        {pbr_Movement.Value = (int)nud_Progress.Value;}

        private void nud_Red_ValueChanged(object sender, EventArgs e)
        {
            DC.Red = (int)nud_Red.Value;
            UpdateColours();
        }

        private void nud_Green_ValueChanged(object sender, EventArgs e)
        {
            DC.Green = (int)nud_Green.Value;
            UpdateColours();
        }

        private void nud_Blue_ValueChanged(object sender, EventArgs e)
        {
            DC.Blue = (int)nud_Blue.Value;
            UpdateColours();
        }

        private void UpdateColours()
        {
            Color clr = Color.FromArgb(DC.Red, DC.Green, DC.Blue);
            pbx_Colours.BackColor = clr;
        }

        private void rdi_Result_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RDI = (RadioButton)sender;
            txt_Result.Text = RDI.Text;
        }

        private Colour DC = new Colour();

        private struct Colour
        {
            public int Red, Green, Blue;
        }

        private void btn_RollNumber_Click(object sender, EventArgs e)
        {
            Random RND = new Random();

            txt_Number.Text = RND.Next(0, 300).ToString();
        }
        #endregion
    }
}