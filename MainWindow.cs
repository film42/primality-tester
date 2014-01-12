using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace project1 {
  public partial class PrimalityTester : Form {
    public PrimalityTester() {
      InitializeComponent();
    }

    private void buttonSolve(object sender, EventArgs e) {
      BigInteger num = BigInteger.Parse(inputNumber.Text);
      Primality logic = new Primality();
      bool result = logic.testPrimality(num, 10);

      probabilityTextBox.Text = result.ToString() + " - Probability of " + logic.determineProbability(10) + "%";
    }
  }
}
