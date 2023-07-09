using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hobbyist_Checklist
{
    public partial class ListView : UserControl
    {
        public ListView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bellow all getters and setters of individual elements will be set
        /// </summary>
        public void setName(string Name)
        {
            this.NameLabel.Text = Name;
        }
        public string getName()
        {
            return this.NameLabel.Text;
        }
        public void setCurrency(string Currency)
        {
            this.CurrencyLabel.Text = Currency;
        }
        public string getCurrency()
        {
            return this.CurrencyLabel.Text;
        }
        public void setID(string ID)
        {
            this.IDLabel.Text = ID;
        }
        public string getID()
        {
            return this.IDLabel.Text;
        }
        public void setDate(string Date)
        {
            this.DateLabel.Text = Date;
        }
        public string getDate()
        {
            return this.DateLabel.Text;
        }
    }
}
