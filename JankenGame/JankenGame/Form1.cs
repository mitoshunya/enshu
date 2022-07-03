namespace JankenGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //�O�[�`���L�p�[�̃{�^���͉����Ȃ��悤�ɂ���
            btnStatus(false);

            //�����Ƒ���̎�̉摜���\���ɂ���
            picPlayerHand.Image = null;
            picEnemyHand.Image = null;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //�X�^�[�g���b�Z�[�W
            MessageBox.Show("�Q�[���X�^�[�g");

            //�O�[�`���L�p�[�̃{�^�����������Ԃɂ���
            btnStatus(true);

            //��̉摜�̏�����
            picPlayerHand.Image = null;
            picEnemyHand.Image = null;  
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayerHand.Image = Properties.Resources.JankenGu;
            GameStarrt(EnumHub.Janken.Rock);
            btnStatus(false);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            picPlayerHand.Image= Properties.Resources.JankenChoki;
            GameStarrt(EnumHub.Janken.Scissors);
            btnStatus(false);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayerHand.Image = Properties.Resources.jankenPa;
            GameStarrt(EnumHub.Janken.Paper);
            btnStatus(false);
        }

        private void GameStarrt(EnumHub.Janken myhand)
        {
            Random rd = new Random();
            EnumHub.Janken enemyHand = (EnumHub.Janken)rd.Next(0, 3);

            switch(enemyHand)
            {
                case EnumHub.Janken.Rock:
                    picEnemyHand.Image = Properties.Resources.JankenGu;
                    break;
                case EnumHub.Janken.Scissors:
                    picEnemyHand.Image = Properties.Resources.JankenChoki;
                    break;
                case EnumHub.Janken.Paper:
                    picEnemyHand.Image = Properties.Resources.jankenPa;
                    break;
                default:
                    picEnemyHand.Image = null;
                    break;
            }

            if(myhand == enemyHand)
            {
                MessageBox.Show("�������ł��I");
            }
            else if (myhand == EnumHub.Janken.Rock      && enemyHand == EnumHub.Janken.Scissors ||
                        myhand == EnumHub.Janken.Scissors && enemyHand == EnumHub.Janken.Paper ||
                        myhand == EnumHub.Janken.Paper     && enemyHand == EnumHub.Janken.Rock)
            {
                MessageBox.Show("���Ȃ��̏����ł��I");
            }
            else if (myhand == EnumHub.Janken.Rock      && enemyHand == EnumHub.Janken.Paper ||
                        myhand == EnumHub.Janken.Scissors && enemyHand == EnumHub.Janken.Rock ||
                        myhand == EnumHub.Janken.Paper     && enemyHand == EnumHub.Janken.Scissors)
            {
                MessageBox.Show("���Ȃ��̕����ł��I");
            }
            else
                MessageBox.Show("�G���[�ł�");

        }
        private void btnStatus(bool value)
        {
            btnRock.Enabled = value;
            btnScissors.Enabled = value;
            btnPaper.Enabled = value;
        }
    }
}