namespace Library
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void guide_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guide guide = new Guide();
            guide.Show();
        }

        private void place_Click(object sender, EventArgs e)
        {
            this.Hide();
            Place place = new Place();
            place.Show();
        }

        private void readers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Readers reader = new Readers ();
            reader.Show();
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            Purchase purchase = new Purchase();
            purchase.Show();
        }

        private void providers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Providers providers = new Providers();
            providers.Show();
        }
         
         private void cards_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cards cards = new Cards();
            cards.Show();
        }

        private void cancellation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cancellation cancellation = new Cancellation();
            cancellation.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
