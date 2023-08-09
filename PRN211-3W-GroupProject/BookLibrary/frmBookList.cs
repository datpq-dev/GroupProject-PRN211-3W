namespace BookLibrary
{
    public partial class frmBookList : Form
    {
        public frmBookList()
        {
            InitializeComponent();
        }



        private void btnSearchAvai_Click(object sender, EventArgs e)
        {

        }



        private void BtnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new();
            frmRegister.ShowDialog();
            this.Hide();
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new();
            frmLogin.ShowDialog();
            this.Hide();
        }
    }
}