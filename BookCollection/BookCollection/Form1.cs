using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int index = 0;

        List<Title> listTitle = new List<Title>();
        List<Author> listAuthor = new List<Author>();
        List<ISBN> listISBN = new List<ISBN>();
        List<Price> listPrice = new List<Price>();


        private void buttonShow_Click(object sender, EventArgs e)
        {
            using (var myEntities = new BookCollectionEntities())
            {
                Title addedTitle = new Title();

                addedTitle.Name = textTitle.Text;

                Author addedAuthor = new Author();

                addedAuthor.Name = textAuthor.Text;

                //ISBN addedISBN = new ISBN();

                //addedISBN.Number = numberISBN.Number;

                Price addedPrice = new Price();

                addedTitle.Name = textAuthor.Text;

                myEntities.Titles.Add(addedTitle);

                myEntities.Authors.Add(addedAuthor);

                //myEntities.ISBNs.Add(addedISBN);
                //myEntities.SaveChanges();

                myEntities.Prices.Add(addedPrice);
                myEntities.SaveChanges();

            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }
    }
}
