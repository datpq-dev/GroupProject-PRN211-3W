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
            this.Hide();
            frmRegister.Show();
            
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new();
            this.Hide();
            frmLogin.Show();
        }
    }
}