using System.Diagnostics;

namespace csharp_net_forms_simon_says
{
    public partial class Form1 : Form
    {
        int blocksX = 180;
        int blocksY = 80;
        int score = 0;
        int level = 3;

        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<PictureBox> choseBoxes = new List<PictureBox>();
        Random rand = new Random();

        Color temp;

        int index = 0;
        int tries = 0;

        int timeLimit = 0;
        bool selectingColours = false;

        string correctOrder = string.Empty;
        string playerOrder = string.Empty;


        public Form1()
        {
            InitializeComponent();
            SetUpBlock();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (score > 3 && level < 7)
            {
                level++;
                score = 0;
            }

            correctOrder = string.Empty;
            playerOrder = string.Empty;
            choseBoxes.Clear();
            choseBoxes = pictureBoxes.OrderBy(x => rand.Next()).Take(level).ToList();

            for (int i = 0; i < choseBoxes.Count; i++)
            {
                correctOrder += choseBoxes[i].Name + " ";
            }

            foreach (PictureBox x in pictureBoxes)
            {
                x.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            }

            Debug.WriteLine(correctOrder);
            index = 0;
            timeLimit = 0;
            selectingColours = true;
            SecondTimer.Start();
        }

        private void SetUpBlock()
        {
            for (int i = 1; i < 17; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Name = "pic_" + i;
                newPic.Height = 60;
                newPic.Width = 60;
                newPic.BackColor = Color.Black;
                newPic.Left = blocksX;
                newPic.Top = blocksY;
                newPic.Click += ClickOnPictureBox;

                if (i == 4 || i == 8 || i == 12)
                {
                    blocksY += 65;
                    blocksX = 180;
                }
                else
                {
                    blocksX += 65;
                }

                this.Controls.Add(newPic);
                pictureBoxes.Add(newPic);
            }


        }

        private void ClickOnPictureBox(object? sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SecondTimerEvent(object sender, EventArgs e)
        {

        }
    }

}
